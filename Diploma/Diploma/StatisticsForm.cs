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
    public partial class StatisticsForm : Form
    {
        bool isAddingActive;
        bool isActive, isPaused;
        public delegate void FormCall();
        Derives derives;
        Pen axisPen = new Pen(Color.Black, 2.5F);
        List<CustomPoint> points;
        ColorDialog colorDialog;
        DrawState drawState;
        Random r;
        GraphPane pane;

        PointPairList densityDistributionMeanValueList;
        PointPairList densityDistributionRootMeanSquareValueList;
        PointPairList mixtureEntropyValueList;
        PointPairList maxMixtureEntropyValueList;
        PointPairList segregationIntensityValueList;

        GridStatistics gridStatistics;
        public StatisticsForm()
        {
            r = new Random();
            points = new List<CustomPoint>();
            derives = new Derives();
            colorDialog = new ColorDialog();
            drawState = new DrawState(derives, 0, 0, points);
            InitializeComponent();
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
            pane.Title.Text = "Статистика";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Значення";
            pane.YAxis.Type = AxisType.Log;

            gridStatistics = new GridStatistics();

            densityDistributionMeanValueList = new PointPairList();
            densityDistributionRootMeanSquareValueList = new PointPairList();
            mixtureEntropyValueList = new PointPairList();
            maxMixtureEntropyValueList = new PointPairList();
            segregationIntensityValueList = new PointPairList();

            LineItem densityDistributionMeanValueListLine = pane.AddCurve("Середнє значення густини розподілу", densityDistributionMeanValueList, Color.Red, SymbolType.None);
            LineItem densityDistributionRootMeanSquareValueLine = pane.AddCurve("Середньо двадратичне значення густини розподілу", densityDistributionRootMeanSquareValueList, Color.Blue, SymbolType.None);
            LineItem maxMixtureEntropyValueLine = pane.AddCurve("Максимальна ентропія розмішування", maxMixtureEntropyValueList, Color.Green, SymbolType.None);
            LineItem mixtureEntropyValueLine = pane.AddCurve("Ентропія розмішування", mixtureEntropyValueList, Color.Violet, SymbolType.None);
            LineItem segregationIntensityValueLine = pane.AddCurve("Інтенсивність сегрегації", segregationIntensityValueList, Color.Orange, SymbolType.None);

            densityDistributionMeanValueListLine.Line.DashOn = 2.0F;
            densityDistributionMeanValueListLine.Line.DashOff = 3.0F;
            densityDistributionMeanValueListLine.Line.Width = 3.0F;

            densityDistributionRootMeanSquareValueLine.Line.DashOn = 2.0F;
            densityDistributionRootMeanSquareValueLine.Line.DashOff = 3.0F;
            densityDistributionRootMeanSquareValueLine.Line.Width = 3.0F;

            maxMixtureEntropyValueLine.Line.DashOn = 2.0F;
            maxMixtureEntropyValueLine.Line.DashOff = 3.0F;
            maxMixtureEntropyValueLine.Line.Width = 3.0F;

            mixtureEntropyValueLine.Line.DashOn = 2.0F;
            mixtureEntropyValueLine.Line.DashOff = 3.0F;
            mixtureEntropyValueLine.Line.Width = 3.0F;

            segregationIntensityValueLine.Line.DashOn = 2.0F;
            segregationIntensityValueLine.Line.DashOff = 3.0F;
            segregationIntensityValueLine.Line.Width = 3.0F;

            double.TryParse(CircularSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.V);
            double.TryParse(StraightSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.U);
            double.TryParse(RadiusTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.A);
            double.TryParse(PeriodTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.Period);
            BuildGrid();
        }

        private void RedrawGraph()
        {
            zedGraph.AxisChange();
            zedGraph.Invalidate();
        }
        async private void Start_Click(object sender, EventArgs e)
        {
            densityDistributionMeanValueList.Clear();
            densityDistributionRootMeanSquareValueList.Clear();
            mixtureEntropyValueList.Clear();
            maxMixtureEntropyValueList.Clear();
            segregationIntensityValueList.Clear();
            StartModelingButton.Enabled = false;
            isActive = true;
            DrawPlane.Refresh();
            FormCall caller = DrawPlane.Refresh;
            FormCall graphCaller = RedrawGraph;
            RungeKutClass rungeKut = new RungeKutClass(2, 0, 0.01, 0.01);
            double calculationPeriod = 0;
            double.TryParse(CircularSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.V);
            double.TryParse(StraightSpeedTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.U);
            double.TryParse(RadiusTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.A);
            double.TryParse(PeriodTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out derives.Period);
            double.TryParse(CalculationPeriodTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out calculationPeriod);
            drawState.Dt =  rungeKut.TimeStep;
            await Task.Run(() =>
            {
                for (int i = 1; isActive; i++)
                {
                    while (isPaused)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    for (int j = 0; j < points.Count; j++)
                    {
                        rungeKut.Runge_Kut(points[j], derives, i);
                        int xindex = (int)((points[j].Coordinates[0] + derives.A) / gridStatistics.cellWidth);
                        int yindex = (int)((points[j].Coordinates[1]) / gridStatistics.cellWidth);
                        if (xindex < 0)
                            xindex = 0;
                        if (xindex >= gridStatistics.cells.Count)
                            xindex = gridStatistics.cells.Count - 1;
                        if (yindex < 0)
                            yindex = 0;
                        if (yindex >= gridStatistics.cells[xindex].Count)
                            yindex = gridStatistics.cells[xindex].Count - 1;
                        gridStatistics.cells[xindex][yindex] += 1.0F / gridStatistics.totalCellCount;
                    }
                    
                    if (rungeKut.CurrentTime % calculationPeriod < 0.001)
                    {
                        double rootMeanSquareSum = 0;
                        double meanSum = 0;
                        double maxEntropy = 0;
                        double entropy = 0;
                        double intensity = 0;

                        gridStatistics.CalculateValues(ref meanSum, ref rootMeanSquareSum, ref entropy, ref maxEntropy, ref intensity);

                        densityDistributionMeanValueList.Add(rungeKut.CurrentTime, meanSum);
                        densityDistributionRootMeanSquareValueList.Add(rungeKut.CurrentTime, rootMeanSquareSum);
                        mixtureEntropyValueList.Add(rungeKut.CurrentTime, entropy);
                        maxMixtureEntropyValueList.Add(rungeKut.CurrentTime, maxEntropy);
                        segregationIntensityValueList.Add(rungeKut.CurrentTime, intensity);
                    }
                    this.Invoke(caller);
                    this.Invoke(graphCaller);
                    System.Threading.Thread.Sleep(1);
                    gridStatistics.ClearGrid();
                }
            });
            points.Clear();
            DrawPlane.Refresh();
        }


        private void Stop_Click(object sender, EventArgs e)
        {
            StartModelingButton.Enabled = true;
            isActive = false;

        }

        void AddNewPoint(List<CustomPoint> pointList, double X, double Y)
        {
            double x = TransformXtoLocal(X);
            double y = TransformYtoLocal(Y);
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
                pointList.Add(new CustomPoint(new double[] { x, y }, colorDialog.Color));
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
            float currentCellWidth = (float)TransformXtoPlane(gridStatistics.cellWidth) - TransformXtoPlane(0);
            float currentCellHeight = (float)TransformYtoPlane(0) - TransformYtoPlane(gridStatistics.cellWidth);
            for (int i = 0; i < gridStatistics.cells.Count; i++)
            {
                for (int j = 0; j < gridStatistics.cells[i].Count; j++)
                {
                    e.Graphics.DrawRectangle(new Pen(Color.Black), TransformXtoPlane(-derives.A + i * gridStatistics.cellWidth), TransformYtoPlane((j + 1) * gridStatistics.cellWidth), currentCellWidth, currentCellHeight);
                }
            }
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
            return DrawPlane.Height * 0.9F - (float)Y * DrawPlane.Height * 0.8F / (float)derives.A;
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
                for (int i = 0; i < PointNumberUpDown.Value; i++)
                {
                    AddNewPoint(points, e.X + r.Next(Convert.ToInt32(SizeUpDown.Value) * 2) - Convert.ToInt32(SizeUpDown.Value), e.Y + r.Next(Convert.ToInt32(SizeUpDown.Value) * 2) - Convert.ToInt32(SizeUpDown.Value));
                }
            Refresh();
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
                {
                    for (int i = 0; i < PointNumberUpDown.Value / 2; i++)
                    {
                        AddNewPoint(points, e.X + r.Next(Convert.ToInt32(SizeUpDown.Value) * 2) - Convert.ToInt32(SizeUpDown.Value), e.Y + r.Next(Convert.ToInt32(SizeUpDown.Value) * 2) - Convert.ToInt32(SizeUpDown.Value));
                    }

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
        private void ClearAll_Click(object sender, EventArgs e)
        {
            points.Clear();
            DrawPlane.Refresh();
        }
        private void SaveState_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                drawState.Dt = 0.01;
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
                DrawPlane.Refresh();
            }
        }

        private void BuildGrid()
        {
            if (!double.TryParse(CellNumberTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out gridStatistics.cellWidth))
            {
                return;
            }
            gridStatistics.ConstructGrid(derives);
        }
        private void CellNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            BuildGrid();
            Refresh();
        }
    }
}
