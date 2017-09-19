using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Diploma
{
    public partial class LiapunovForm : Form
    {
        bool isAddingActive;
        bool isActive, isPaused;
        public delegate void FormCall();
        Derives derives;
        CustomPoint liapunovPoint;
        ColorDialog colorDialog;
        Random r;
        CoordinateTransformer coordTransformer;

        GraphPane pane;
        PointPairList liapunovValueList;
        public LiapunovForm()
        {
            r = new Random();
            liapunovPoint = new CustomPoint();
            derives = new Derives();
            colorDialog = new ColorDialog();
            InitializeComponent();
            coordTransformer = new CoordinateTransformer(DrawPlane, derives);
            double.TryParse(CircularSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.V);
            double.TryParse(StraightSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.U);
            double.TryParse(RadiusTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.A);
            double.TryParse(PeriodTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.Period);

            pane = zedGraph.GraphPane;
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.DashOn = 5;
            pane.XAxis.MajorGrid.DashOff = 3;
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOn = 5;
            pane.YAxis.MajorGrid.DashOff = 3;
            pane.YAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.DashOn = 1;
            pane.YAxis.MinorGrid.DashOff = 1;
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.DashOn = 1;
            pane.XAxis.MinorGrid.DashOff = 1;
            pane.Title.Text = "Найбільший показник Ляпунова";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Значення показника";
            //pane.YAxis.Type = AxisType.Log;

            liapunovValueList = new PointPairList();
            LineItem liapunovLine = pane.AddCurve("Найбільший показник Ляпунова", liapunovValueList, Color.Red, SymbolType.None);

            liapunovLine.Line.DashOn = 2.0F;
            liapunovLine.Line.DashOff = 3.0F;
            liapunovLine.Line.Width = 3.0F;
        }

        async private void Start_Click(object sender, EventArgs e)
        {
            liapunovValueList.Clear();
            StartModelingButton.Enabled = false;
            isActive = true;
            DrawPlane.Refresh();
            RungeKutClass rungeKut = new RungeKutClass(4, 0.01, 0.01, 0.01);
            FormCall caller = DrawPlane.Refresh;
            FormCall zedGraphCaller = () => { zedGraph.AxisChange(); zedGraph.Refresh(); };
            double.TryParse(CircularSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.V);
            double.TryParse(StraightSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.U);
            double.TryParse(RadiusTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.A);
            double.TryParse(PeriodTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.Period);
            double.TryParse(TimeStepTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out rungeKut.TimeStep);
            await Task.Run(() =>
            {
                for (int i = 1; isActive; i++)
                {
                    while (isPaused)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    rungeKut.Runge_Kut_Liapunov(liapunovPoint, derives);
                    if (rungeKut.CurrentTime % 1 < 0.00001)
                    {
                        liapunovValueList.Add(rungeKut.CurrentTime, Math.Log(Math.Sqrt(Math.Pow(liapunovPoint.Coordinates[2], 2) + Math.Pow(liapunovPoint.Coordinates[3], 2))) / rungeKut.CurrentTime);
                    }
                    this.Invoke(caller);
                    this.Invoke(zedGraphCaller);
                    rungeKut.RecalculateTime(i);
                    System.Threading.Thread.Sleep(1);
                }
            });
            DrawPlane.Refresh();
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            StartModelingButton.Enabled = true;
            isActive = false;

        }

        void AddNewPoint(CustomPoint point, double X, double Y)
        {
            double x = coordTransformer.TransformXtoLocal(X);
            double y = coordTransformer.TransformYtoLocal(Y);
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
            {
                point.Coordinates = new double[] { x, y, 1.0 / Math.Sqrt(2), 1.0 / Math.Sqrt(2) };
                point.BrushSolor = colorDialog.Color;
            }
        }



        private void DrawPlane_Paint(object sender, PaintEventArgs e)
        {
            Pen axisPen = new Pen(Color.Black, 2.5F);
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
            if (liapunovPoint != null)
                e.Graphics.FillEllipse(liapunovPoint.PointBrush, coordTransformer.TransformXtoPlane(liapunovPoint.Coordinates[0]) - 1.5F, coordTransformer.TransformYtoPlane(liapunovPoint.Coordinates[1]) - 1.5F, 3, 3);
        }
        private void DrawPlane_MouseDown(object sender, MouseEventArgs e)
        {
            isAddingActive = true;
            if (e.Button == MouseButtons.Right)
            {
                double xpos = coordTransformer.TransformXtoLocal(e.X);
                double ypos = coordTransformer.TransformYtoLocal(e.Y);
                if (Math.Abs(liapunovPoint.Coordinates[0] - xpos) < derives.A / 20 && Math.Abs(liapunovPoint.Coordinates[1] - ypos) < derives.A / 20)
                    liapunovPoint = null;
            }
            else
                AddNewPoint(liapunovPoint, e.X, e.Y);
            Refresh();
        }
        private void DrawPlane_MouseMove(object sender, MouseEventArgs e)
        {
            if (isAddingActive)
            {
                if (e.Button == MouseButtons.Right)
                {
                    double xpos = coordTransformer.TransformXtoLocal(e.X);
                    double ypos = coordTransformer.TransformYtoLocal(e.Y);
                    if (liapunovPoint != null)
                        if (Math.Abs(liapunovPoint.Coordinates[0] - xpos) < derives.A / 20 && Math.Abs(liapunovPoint.Coordinates[1] - ypos) < derives.A / 20)
                            liapunovPoint = null;
                }
                else
                {
                    AddNewPoint(liapunovPoint, e.X, e.Y);
                }
                DrawPlane.Refresh();
            }

        }
        private void DrawPlane_MouseUp(object sender, MouseEventArgs e)
        {
            isAddingActive = false;
        }

        private void Radius_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(RadiusTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.A);
            Refresh();
        }

        private void StraightSpeed_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(StraightSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.U);
        }

        private void CircularSpeed_TextChanged(object sender, EventArgs e)
        {
            double.TryParse(CircularSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.V);
        }
        private void AdvectionForm_SizeChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused;
            if (isPaused)
                PauseModelingButton.Text = "Продовжити";
            else
                PauseModelingButton.Text = "Пауза";
        }

        private void ChangeColor_Click(object sender, EventArgs e)
        {
            colorDialog.ShowDialog();
            Refresh();
        }

        private void NewPointButton_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;
            if (double.TryParse(XValueTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out x) && double.TryParse(YValueTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out y))
            {
                x = coordTransformer.TransformXtoPlane(x);
                y = coordTransformer.TransformYtoPlane(y);
                AddNewPoint(liapunovPoint, x, y);
            }
            DrawPlane.Refresh();
        }
    }
}
