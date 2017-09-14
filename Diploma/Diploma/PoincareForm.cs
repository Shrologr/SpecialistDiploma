using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public partial class PoincareForm : Form
    {
        bool isAddingActive;
        public delegate void PictureBoxCall();
        public delegate void ProgressBarCall(double t);
        Derives derives;
        Pen axisPen = new Pen(Color.Black, 2.5F);
        List<CustomPoint> points;
        List<CustomPoint> reservedPoints;
        ColorDialog colorDialog;
        DrawState drawState;
        public PoincareForm()
        {
            points = new List<CustomPoint>();
            reservedPoints = new List<CustomPoint>();
            derives = new Derives();
            colorDialog = new ColorDialog();
            drawState = new DrawState(derives, 0, 0, points);
            InitializeComponent();
            double.TryParse(CircularSpeedTextBox.Text, out derives.V);
            double.TryParse(StraightSpeedTextBox.Text, out derives.U);
            double.TryParse(RadiusTextBox.Text, out derives.A);
            double.TryParse(PeriodTextBox.Text, out derives.Period);
            

        }
        void AddNewPoint(List<CustomPoint> pointList, double X, double Y)
        {
            double x = TransformXtoLocal(X);
            double y = TransformYtoLocal(Y);
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
                pointList.Add(new CustomPoint(new double[] { x, y }, colorDialog.Color));
        }

        private void DrawPlane_MouseMove(object sender, MouseEventArgs e)
        {
            if (isAddingActive)
            {
                if (e.Button == MouseButtons.Right)
                {
                    double xpos = TransformXtoLocal(e.X);
                    double ypos = TransformYtoLocal(e.Y);
                    for (int i = 0; i < points.Count; i++)
                    {
                        if (Math.Abs(points[i].Coordinates[0] - xpos) < derives.A / 20 && Math.Abs(points[i].Coordinates[1] - ypos) < derives.A / 20)
                            points.RemoveAt(i);
                    }
                }
                else
                    AddNewPoint(points, e.X, e.Y);
            }
            DrawPlane.Refresh();
        }
        private void Radius_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(RadiusTextBox.Text, out derives.A);
        }

        private void StraightSpeed_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(StraightSpeedTextBox.Text, out derives.U);
        }

        private void CircularSpeed_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(CircularSpeedTextBox.Text, out derives.V);
        }
        private void DrawPlane_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawArc(axisPen, DrawPlane.Width * 0.1F, DrawPlane.Height * 0.1F, DrawPlane.Width * 0.8F, DrawPlane.Height * 1.6F, 180.0F, 180.0F);
            e.Graphics.DrawLine(axisPen, DrawPlane.Width / 2, DrawPlane.Height * 0.9F, DrawPlane.Width / 2, 0);
            e.Graphics.DrawLine(axisPen, 0, DrawPlane.Height * 0.9F, DrawPlane.Width, DrawPlane.Height * 0.9F);
            e.Graphics.DrawString("" + (-derives.A), new Font("Courier New", 12), new SolidBrush(Color.Black), DrawPlane.Width * 0.1F, DrawPlane.Height * 0.91F);
            e.Graphics.DrawString("" + (derives.A), new Font("Courier New", 12), new SolidBrush(Color.Black), DrawPlane.Width * 0.9F - derives.A.ToString().Length * 11.7F, DrawPlane.Height * 0.91F);
            e.Graphics.DrawString("" + (derives.A), new Font("Courier New", 12), new SolidBrush(Color.Black), DrawPlane.Width / 2, DrawPlane.Height * 0.05F);
            e.Graphics.DrawString("0", new Font("Courier New", 12), new SolidBrush(Color.Black), DrawPlane.Width / 2, DrawPlane.Height * 0.91F);
            e.Graphics.DrawString("Поточний колір: ", new Font("Courier New", 10), new SolidBrush(Color.Black), DrawPlane.Width - 140, 5);
            e.Graphics.DrawString("X", new Font("Courier New", 12), new SolidBrush(Color.Black), DrawPlane.Width * 0.95F, DrawPlane.Height * 0.9F);
            e.Graphics.DrawString("Y", new Font("Courier New", 12), new SolidBrush(Color.Black), DrawPlane.Width / 2, 0);
            e.Graphics.FillRectangle(new SolidBrush(colorDialog.Color), DrawPlane.Width - 20, 9, 20, 10);
            for (int i = 0; i < points.Count; i++)
            {
                e.Graphics.FillEllipse(points[i].PointBrush, TransformXtoPlane(points[i].Coordinates[0]) - 1.5F, TransformYtoPlane(points[i].Coordinates[1]) - 1.5F, 3, 3);
            }
            for (int i = 0; i < reservedPoints.Count; i++)
            {
                e.Graphics.FillEllipse(reservedPoints[i].PointBrush, TransformXtoPlane(reservedPoints[i].Coordinates[0]) - 1.5F, TransformYtoPlane(reservedPoints[i].Coordinates[1]) - 1.5F, 3, 3);
            }
        }

        private void DrawPlane_MouseDown(object sender, MouseEventArgs e)
        {
            isAddingActive = true;
            if (e.Button == MouseButtons.Right)
            {
                double xpos = TransformXtoLocal(e.X);
                double ypos = TransformYtoLocal(e.Y);
                for (int i = 0; i < points.Count; i++)
                {
                    if (Math.Abs(points[i].Coordinates[0] - xpos) < derives.A / 20 && Math.Abs(points[i].Coordinates[1] - ypos) < derives.A / 20)
                        points.RemoveAt(i);
                }
            }
            else
                AddNewPoint(points, e.X, e.Y);
        }

        private void DrawPlane_MouseUp(object sender, MouseEventArgs e)
        {
            isAddingActive = false;
        }
        private void AdvectionForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }
        double TransformXtoLocal(double X)
        {
            return (X - DrawPlane.Width / 2) * (float)derives.A / (DrawPlane.Width * 0.4F);
        }

        double TransformYtoLocal(double Y)
        {
            return (DrawPlane.Height * 0.9F - Y) * (float)derives.A / (DrawPlane.Height * 0.8F);
        }

        float TransformXtoPlane(double X)
        {
            return (float)X * 0.4F * DrawPlane.Width / (float)(derives.A) + DrawPlane.Width / 2;
        }

        float TransformYtoPlane(double Y)
        {
            return DrawPlane.Height * 0.9F - ((float)Y) * DrawPlane.Height * 0.8F / (float)derives.A;
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
        }
        private void ClearAll_Click(object sender, EventArgs e)
        {
            points.Clear();
            reservedPoints.Clear();
            DrawPlane.Refresh();
        }
        private void SaveState_Click(object sender, EventArgs e)
        {

            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                double.TryParse(TimeStepTextBox.Text, out drawState.Dt);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(drawState.GetType());
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject(ms, drawState);
                string result = Encoding.Default.GetString(ms.ToArray());
                File.WriteAllText(dialog.FileName, result);
            }
        }

        private void LoadState_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(drawState.GetType());
                MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText(dialog.FileName)));
                drawState = serializer.ReadObject(ms) as DrawState;
                ms.Close();
                points = drawState.Points;
                CircularSpeedTextBox.Text = drawState.DeriveData.V.ToString();
                StraightSpeedTextBox.Text = drawState.DeriveData.U.ToString();
                RadiusTextBox.Text = drawState.DeriveData.A.ToString();
                PeriodTextBox.Text = drawState.DeriveData.Period.ToString();
                TimeStepTextBox.Text = drawState.Dt.ToString();
                DrawPlane.Refresh();

            }
        }

        async private void BuildPoincareButton_Click(object sender, EventArgs e)
        {
            int eNumber = 2;
            reservedPoints.Clear();
            DrawPlane.Refresh();
            double t = 0.0, dt = 0.01, tend = 0.01, period = 0;
            double.TryParse(CircularSpeedTextBox.Text, out derives.V);
            double.TryParse(StraightSpeedTextBox.Text, out derives.U);
            double.TryParse(RadiusTextBox.Text, out derives.A);
            double.TryParse(PeriodTextBox.Text, out derives.Period);
            double.TryParse(TimeStepTextBox.Text, out dt);
            double.TryParse(WorkingTimeTextBox.Text, out period);
            tend = dt;
            drawState.Dt = dt;
            List<CustomPoint> spareList = new List<CustomPoint>() ;
            for (int i = 0; i < points.Count; i++)
            {
                spareList.Add(new CustomPoint(new double[] { points[i].Coordinates[0], points[i].Coordinates[1] }, points[i].BrushSolor));
            }
            PoincareBuildBar.Minimum = 0;
            PoincareBuildBar.Maximum = Convert.ToInt32(period);
            ProgressLabel.Text = "Відбувається побудова перетину Пуанкаре. Будь ласка, зачекайте...";
            ProgressBarCall caller = (double time) => { PoincareBuildBar.Value = Convert.ToInt32(time); };
            ClearAllButton.Enabled = false;
            await Task.Run(() =>
            {
                for (int i = 1; t < period; i++)
                {
                    for (int j = 0; j < spareList.Count; j++)
                    {
                        RungeKutClass.Runge_Kut(eNumber, t, tend, dt, spareList[j], derives);
                        if (derives.Period - t % derives.Period < dt && derives.Period - t % derives.Period > 0)
                            reservedPoints.Add(new CustomPoint(new double[] { spareList[j].Coordinates[0], spareList[j].Coordinates[1] }, spareList[j].BrushSolor));
                    }
                    if (derives.Period - t % derives.Period < dt)
                        this.Invoke(caller, t);
                    t = tend;
                    tend = dt + dt * i;
                }
                
            });
            ClearAllButton.Enabled = true;
            ProgressLabel.Text = "";
            PoincareBuildBar.Value = 0;
            DrawPlane.Refresh();
        }

        private void NewPointButton_Click(object sender, EventArgs e)
        {
            double x, y;
            if (!double.TryParse(XValueTextBox.Text, out x) || !double.TryParse(YValueTextBox.Text, out y))
                return;
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
                points.Add(new CustomPoint(new double[] { x, y }, colorDialog.Color));
            Refresh();
        }

        private void ClearPoincareButton_Click(object sender, EventArgs e)
        {
            reservedPoints.Clear();
            Refresh();
        }
    }
}