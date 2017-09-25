using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Drawing;
using ZedGraph;

namespace WpfDiploma
{
    /// <summary>
    /// Interaction logic for StatisticsWindow.xaml
    /// </summary>
    public partial class StatisticsWindow : Window
    {
        bool isAddingActive;
        bool isActive, isPaused;
        bool isReadable;
        bool isFullScreen;
        public delegate void PictureBoxCall();
        Derives derives;
        List<CustomPoint> points;
        DrawState advectionState;
        Random pointRandom;
        CoordinateTransformer coordTransformer;

        GraphPane pane;

        PointPairList densityDistributionMeanValueList;
        PointPairList densityDistributionRootMeanSquareValueList;
        PointPairList mixtureEntropyValueList;
        PointPairList maxMixtureEntropyValueList;
        PointPairList segregationIntensityValueList;

        GridStatistics gridStatistics;
        public StatisticsWindow()
        {
            isReadable = false;
            pointRandom = new Random();
            points = new List<CustomPoint>();
            derives = new Derives();
            advectionState = new DrawState(derives, 0, 0, points);
            InitializeComponent();

            pane = GraphControl.GraphPane;
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

            coordTransformer = new CoordinateTransformer(uiElement, derives);
            uiElement.CoordTransformer = coordTransformer;
            uiElement.Points = points;
            uiElement.GridStats = gridStatistics;
            derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
            uiElement.MouseDown += uiElement_MouseDown;
            uiElement.MouseUp += uiElement_MouseUp;
            uiElement.MouseMove += uiElement_MouseMove;
            isReadable = true;
            isActive = false;

            LineItem densityDistributionMeanValueListLine = pane.AddCurve("Середнє значення густини розподілу", densityDistributionMeanValueList, System.Drawing.Color.Red, SymbolType.None);
            LineItem densityDistributionRootMeanSquareValueLine = pane.AddCurve("Середньо двадратичне значення густини розподілу", densityDistributionRootMeanSquareValueList, System.Drawing.Color.Blue, SymbolType.None);
            LineItem maxMixtureEntropyValueLine = pane.AddCurve("Максимальна ентропія розмішування", maxMixtureEntropyValueList, System.Drawing.Color.Green, SymbolType.None);
            LineItem mixtureEntropyValueLine = pane.AddCurve("Ентропія розмішування", mixtureEntropyValueList, System.Drawing.Color.Violet, SymbolType.None);
            LineItem segregationIntensityValueLine = pane.AddCurve("Інтенсивність сегрегації", segregationIntensityValueList, System.Drawing.Color.Orange, SymbolType.None);

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
            BuildGrid();
        }

        private void AdvectionDataChanged(object sender, TextChangedEventArgs e)
        {
            if (isReadable)
            {
                if (derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text))
                {
                    uiElement.InvalidateVisual();
                    BuildGrid();
                }
            }
        }

        private void AddNewPointCheck(MouseEventArgs e)
        {
            if (e.RightButton == MouseButtonState.Pressed)
            {
                double xpos = coordTransformer.TransformXtoLocal(e.GetPosition(uiElement).X);
                double ypos = coordTransformer.TransformYtoLocal(e.GetPosition(uiElement).Y);
                for (int i = 0; i < points.Count; i++)
                {
                    if (Math.Abs(points[i].Coordinates[0] - xpos) < derives.A / 20 && Math.Abs(points[i].Coordinates[1] - ypos) < derives.A / 20)
                        points.RemoveAt(i);
                }
            }
            if (e.LeftButton == MouseButtonState.Pressed)
                for (int i = 0; i < PointNumberSlider.Value; i++)
                {
                    AddNewPoint(points, e.GetPosition(uiElement).X + pointRandom.Next(Convert.ToInt32(PointSizeSlider.Value) * 2) - Convert.ToInt32(PointSizeSlider.Value), e.GetPosition(uiElement).Y + pointRandom.Next(Convert.ToInt32(PointSizeSlider.Value) * 2) - Convert.ToInt32(PointSizeSlider.Value));
                }
            uiElement.InvalidateVisual();
        }

        private void uiElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isAddingActive = true;
            AddNewPointCheck(e);

        }

        private void uiElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (isAddingActive)
            {
                AddNewPointCheck(e);
            }
        }

        private void uiElement_MouseUp(object sender, MouseButtonEventArgs e)
        {
            isAddingActive = false;
        }

        void AddNewPoint(List<CustomPoint> pointList, double X, double Y)
        {
            double x = coordTransformer.TransformXtoLocal(X);
            double y = coordTransformer.TransformYtoLocal(Y);
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
                pointList.Add(new CustomPoint(new double[] { x, y }, PointColorPicker.SelectedColor.Value));
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            uiElement.InvalidateVisual();
        }

        private async void StartModeling()
        {
            isActive = true;
            uiElement.InvalidateVisual();
            densityDistributionMeanValueList.Clear();
            densityDistributionRootMeanSquareValueList.Clear();
            mixtureEntropyValueList.Clear();
            maxMixtureEntropyValueList.Clear();
            segregationIntensityValueList.Clear();
            double timeStep, calculationTime;
            if (!derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text)
                || !double.TryParse(TimeStepTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out timeStep)
                || !double.TryParse(CalculationTimeTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out calculationTime))
            {
                return;
            }
            RungeKutClass rungeKut = new RungeKutClass(2, 0, 0.01, 0.01);
            rungeKut.TimeStep = timeStep;
            PictureBoxCall caller = uiElement.InvalidateVisual;
            PictureBoxCall graphCaller = RedrawGraph;
            await Task.Run(() =>
            {
                for (int i = 1; isActive && rungeKut.CurrentTime <= calculationTime; i++)
                {
                    while (isPaused)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    for (int j = 0; j < points.Count; j++)
                    {
                        rungeKut.Runge_Kut(points[j], derives);
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
                    rungeKut.RecalculateTime(i);
                    if (rungeKut.CurrentTime % 1 < 0.0001)
                    {
                        var data = gridStatistics.CalculateValues();

                        densityDistributionMeanValueList.Add(rungeKut.CurrentTime, data.MeanSum);
                        densityDistributionRootMeanSquareValueList.Add(rungeKut.CurrentTime, data.RootMeanSquareSum);
                        mixtureEntropyValueList.Add(rungeKut.CurrentTime, data.Entropy);
                        maxMixtureEntropyValueList.Add(rungeKut.CurrentTime, data.MaxEntropy);
                        segregationIntensityValueList.Add(rungeKut.CurrentTime, data.Intensity);
                    }
                    Dispatcher.Invoke(caller);
                    Dispatcher.Invoke(graphCaller);
                    System.Threading.Thread.Sleep(1);
                    gridStatistics.ClearGrid();
                }
            });
            points.Clear();
            uiElement.InvalidateVisual();
        }

        private void StartPauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isActive)
            {
                StartModeling();
                if (isActive)
                    ImageLoader.LoadAndSetImage(StartPauseImage, "file:///D://pause.ico");
            }
            else
            {
                isPaused = !isPaused;
                ImageLoader.LoadAndSetImage(StartPauseImage, "file:///D://start.ico", "file:///D://pause.ico", isPaused);
            }
        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            isPaused = false;
            isActive = false;
            ImageLoader.LoadAndSetImage(StartPauseImage, "file:///D://start.ico");
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Simulation data (*.simuldata)|*.simuldata";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
                double.TryParse(TimeStepTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out advectionState.Dt);
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(advectionState.GetType());
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject(ms, advectionState);
                string result = Encoding.Default.GetString(ms.ToArray());
                File.WriteAllText(saveFileDialog.FileName, result);
            }
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simulation data (*.simuldata)|*.simuldata";
            bool? isOpened = dialog.ShowDialog();
            if (isOpened != null && isOpened == true)
            {
                try
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(advectionState.GetType());
                    MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText(dialog.FileName)));
                    advectionState = serializer.ReadObject(ms) as DrawState;
                    ms.Close();
                    StraightSpeedTextBox.Text = advectionState.DeriveData.V.ToString(CultureInfo.InvariantCulture);
                    CircularSpeedTextBox.Text = advectionState.DeriveData.U.ToString(CultureInfo.InvariantCulture);
                    CircleRadiusTextBox.Text = advectionState.DeriveData.A.ToString(CultureInfo.InvariantCulture);
                    RotationPeriodTextBox.Text = advectionState.DeriveData.Period.ToString(CultureInfo.InvariantCulture);
                    TimeStepTextBox.Text = advectionState.Dt.ToString(CultureInfo.InvariantCulture);
                    points = uiElement.Points = advectionState.Points;
                    uiElement.InvalidateVisual();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Неправильний формат даних", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SavePictureButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Simulation image (*.png)|*.png";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
                ImageSaver.SaveUsingEncoder(uiElement, saveFileDialog.FileName, new PngBitmapEncoder());
            }
        }

        private void LoadPictureButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simulation image (*.png)|*.png";
            bool? isOpened = dialog.ShowDialog();
            if (isOpened != null && isOpened == true)
            {
                try
                {
                    ImageWindow imageWindow = new ImageWindow();
                    System.Windows.Controls.Image someImage = imageWindow.GetImage();
                    ImageLoader.LoadAndSetImage(someImage, "file:///" + dialog.FileName);
                    imageWindow.Height = uiElement.ActualHeight;
                    imageWindow.Width = uiElement.ActualWidth;
                    imageWindow.Show();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Неправильний формат файла", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void RedrawGraph()
        {
            GraphControl.AxisChange();
            GraphControl.Invalidate();
        }

        private void BuildGrid()
        {
            if (isReadable)
            {
                if (!double.TryParse(CellWidthTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out gridStatistics.cellWidth))
                {
                    return;
                }
                gridStatistics.ConstructGrid(derives);
            }
        }

        private void CellWidthTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isReadable)
            {
                BuildGrid();
                uiElement.InvalidateVisual();
            }
        }

        private void GraphControl_MouseDoubleClick(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (!isFullScreen)
            {
                isFullScreen = !isFullScreen;
                Grid.SetRow(GraphHost, 0);
                Grid.SetColumn(GraphHost, 0);
                Grid.SetRowSpan(GraphHost, 5);
                Grid.SetColumnSpan(GraphHost, 2);
            }
            else
            {
                isFullScreen = !isFullScreen;
                Grid.SetRow(GraphHost, 1);
                Grid.SetRowSpan(GraphHost, 1);
                Grid.SetColumnSpan(GraphHost, 1);
                Grid.SetColumn(GraphHost, 1);
            }
        }

        private void SaveGraphDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Simulation graphs (*.simulgraphs)|*.simulgraphs";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
                PointPairList[] data = new PointPairList[] {densityDistributionMeanValueList,
            densityDistributionRootMeanSquareValueList,
            mixtureEntropyValueList,
            maxMixtureEntropyValueList,
            segregationIntensityValueList};
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(data.GetType());
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject(ms, data);
                string result = Encoding.Default.GetString(ms.ToArray());
                File.WriteAllText(saveFileDialog.FileName, result);
            }
        }

        private void LoadGraphDataButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simulation graphs (*.simulgraphs)|*.simulgraphs";
            bool? isOpened = dialog.ShowDialog();
            if (isOpened != null && isOpened == true)
            {
                try
                {
                    PointPairList[] data = new PointPairList[] { };
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(data.GetType());
                    MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText(dialog.FileName)));
                    data = serializer.ReadObject(ms) as PointPairList[];
                    ms.Close();
                    densityDistributionMeanValueList.Clear();
                    densityDistributionRootMeanSquareValueList.Clear();
                    mixtureEntropyValueList.Clear();
                    maxMixtureEntropyValueList.Clear();
                    segregationIntensityValueList.Clear();

                    densityDistributionMeanValueList.AddRange(data[0]);
                    densityDistributionRootMeanSquareValueList.AddRange(data[1]);
                    mixtureEntropyValueList.AddRange(data[2]);
                    maxMixtureEntropyValueList.AddRange(data[3]);
                    segregationIntensityValueList.AddRange(data[4]);

                    RedrawGraph();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Неправильний формат даних", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}