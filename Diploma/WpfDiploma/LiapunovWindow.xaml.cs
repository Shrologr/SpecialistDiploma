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
using ZedGraph;

namespace WpfDiploma
{
    /// <summary>
    /// Interaction logic for LiapunovWindow.xaml
    /// </summary>
    public partial class LiapunovWindow : Window
    {
        bool isFullScreen = false;
        bool isAddingActive;
        bool isActive, isPaused;
        public delegate void WindowCall();
        public delegate void TableCall(double time, double x, double y);
        Derives derives;
        List<CustomPoint> points;
        List<PointState> pointStates;
        DrawState advectionState;
        Random pointRandom;
        CoordinateTransformer coordTransformer;

        GraphPane pane;
        PointPairList liapunovValueList;
        CurveItem mainCurve;
        List<int> columnIndexes;
        public LiapunovWindow()
        {
            pointRandom = new Random();
            points = new List<CustomPoint>();
            derives = new Derives();
            advectionState = new DrawState(derives, 0, 0, points);
            InitializeComponent();
            coordTransformer = new CoordinateTransformer(uiElement, derives);

            uiElement.CoordTransformer = coordTransformer;
            uiElement.Points = points;
            points.Add(new CustomPoint(new double[] { 0.4, 0.6, 1.0 / Math.Sqrt(2), 1.0 / Math.Sqrt(2) }, Colors.Black));
            pointStates = new List<PointState>();
            columnIndexes = new List<int>();
            uiElement.MouseDown += uiElement_MouseDown;
            uiElement.MouseUp += uiElement_MouseUp;
            uiElement.MouseMove += uiElement_MouseMove;
            isActive = false;

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
            pane.Title.Text = "Найбільший показник Ляпунова";
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Значення показника";

            liapunovValueList = new PointPairList();
            LineItem liapunovLine = pane.AddCurve("Найбільший показник Ляпунова", liapunovValueList, System.Drawing.Color.Red, SymbolType.None);
            mainCurve = pane.CurveList[0];
            liapunovLine.Line.DashOn = 2.0F;
            liapunovLine.Line.DashOff = 3.0F;
            liapunovLine.Line.Width = 3.0F;
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
                AddNewPoint(points, e.GetPosition(uiElement).X, e.GetPosition(uiElement).Y);
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
                pointList[0] = new CustomPoint(new double[] { x, y, 1.0 / Math.Sqrt(2), 1.0 / Math.Sqrt(2) }, Colors.Black);
        }

        private void NewPointButton_Click(object sender, RoutedEventArgs e)
        {
            double x, y;
            if (!double.TryParse(XCoordinateTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !double.TryParse(YCoordinateTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                return;
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
                points[0] = new CustomPoint(new double[] { x, y, 1.0 / Math.Sqrt(2), 1.0 / Math.Sqrt(2) }, Colors.Black);
            uiElement.InvalidateVisual();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            uiElement.InvalidateVisual();
        }

        public void RedrawGraph()
        {
            GraphControl.AxisChange();
            GraphControl.Invalidate();
        }

        private async void StartModeling()
        {
            double calculationTime;
            try
            {
                derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, RotationPeriodTextBox.Text);
                if (!double.TryParse(CalculationTimeTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out calculationTime))
                    throw new ApplicationException("Неправильний формат часу моделювання");
                if (calculationTime <= 0)
                    throw new ApplicationException("Значення часу моделювання має бути невід'ємним (більшим нула)");
            }
            catch (ApplicationException ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            liapunovValueList.Clear();
            pointStates.Clear();
            TableGrid.Items.Clear();
            isActive = true;
            uiElement.InvalidateVisual();
            pane.CurveList.Clear();
            pane.CurveList.Add(mainCurve);
            pane.XAxis.Title.Text = "Час";
            pane.YAxis.Title.Text = "Значення показника";
            RungeKutClass rungeKut = new RungeKutClass(4, 0.01, 0.01, 0.01);
            WindowCall caller = uiElement.InvalidateVisual;
            WindowCall graphCaller = RedrawGraph;
            TableCall tableCaller = (t, x, y) =>
            {
                PointState state = new PointState() { Coordinates = new double[] { t, x, y } };
                pointStates.Add(state);
                TableGrid.Items.Add(state);
            };


            await Task.Run(() =>
            {
                for (int i = 1; isActive && rungeKut.CurrentTime <= calculationTime; i++)
                {
                    while (isPaused)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    rungeKut.Runge_Kut_Liapunov(points[0], derives);
                    if (rungeKut.CurrentTime % 1 < 0.00001)
                    {
                        liapunovValueList.Add(rungeKut.CurrentTime, Math.Log(Math.Sqrt(Math.Pow(points[0].Coordinates[2], 2) + Math.Pow(points[0].Coordinates[3], 2))) / rungeKut.CurrentTime);
                    }
                    rungeKut.RecalculateTime(i);
                    Dispatcher.Invoke(caller);
                    Dispatcher.Invoke(graphCaller);
                    Dispatcher.Invoke(tableCaller, rungeKut.CurrentTime, points[0].Coordinates[0], points[0].Coordinates[1]);
                    System.Threading.Thread.Sleep(1);
                }
            });
            uiElement.InvalidateVisual();
        }

        private void StartPauseButton_Click(object sender, RoutedEventArgs e)
        {
            if (!isActive)
            {
                StartModeling();
                if (isActive)
                    StartPauseImage.Source = FindResource("PauseImageSource") as BitmapImage;
            }
            else
            {
                isPaused = !isPaused;
                StartPauseImage.Source = FindResource((isPaused) ? "StartImageSource" : "PauseImageSource") as BitmapImage;
            }
        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            isPaused = false;
            isActive = false;
            StartPauseImage.Source = FindResource("StartImageSource") as BitmapImage;
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Simulation image (*.png)|*.png";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
                ImageSaver.SaveUsingEncoder(uiElement, saveFileDialog.FileName, new PngBitmapEncoder());
            }
        }

        private void LoadDataButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Simulation image (*.png)|*.png";
            bool? isOpened = dialog.ShowDialog();
            if (isOpened != null && isOpened == true)
            {
                try
                {
                    ImageWindow imageWindow = new ImageWindow();
                    Image someImage = imageWindow.GetImage();
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

        private void SaveGraphDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Liapunov graph (*.liapunovgraph)|*.liapunovgraph";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(liapunovValueList.GetType());
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject(ms, liapunovValueList);
                string result = Encoding.Default.GetString(ms.ToArray());
                File.WriteAllText(saveFileDialog.FileName, result);
            }
        }

        private void LoadGraphDataButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Liapunov graph (*.liapunovgraph)|*.liapunovgraph";
            bool? isOpened = dialog.ShowDialog();
            if (isOpened != null && isOpened == true)
            {
                try
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(liapunovValueList.GetType());
                    MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText(dialog.FileName)));
                    var data = serializer.ReadObject(ms) as PointPairList;
                    ms.Close();
                    pane.CurveList.Clear();
                    pane.CurveList.Add(mainCurve);
                    pane.XAxis.Title.Text = "Час";
                    pane.YAxis.Title.Text = "Значення показника";
                    liapunovValueList.Clear();
                    liapunovValueList.AddRange(data);
                    RedrawGraph();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Неправильний формат даних", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void LoadTableDataButton_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Table (*.simultable)|*.simultable";
            bool? isOpened = dialog.ShowDialog();
            if (isOpened != null && isOpened == true)
            {
                try
                {
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(pointStates.GetType());
                    MemoryStream ms = new MemoryStream(Encoding.Unicode.GetBytes(File.ReadAllText(dialog.FileName)));
                    var data = serializer.ReadObject(ms) as List<PointState>;
                    ms.Close();
                    pointStates.Clear();
                    pointStates.AddRange(data);
                    TableGrid.Items.Clear();
                    foreach (var item in pointStates)
                    {
                        TableGrid.Items.Add(item);
                    }
                    RedrawGraph();
                }
                catch
                {
                    System.Windows.MessageBox.Show("Неправильний формат даних", "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void SaveTableDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Table (*.simultable)|*.simultable";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(pointStates.GetType());
                MemoryStream ms = new MemoryStream();
                serializer.WriteObject(ms, pointStates);
                string result = Encoding.Default.GetString(ms.ToArray());
                File.WriteAllText(saveFileDialog.FileName, result);
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
                Grid.SetColumnSpan(GraphHost, 3);
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

        private void TableGrid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (TableGrid.CurrentColumn != null)
            {
                switch (TableGrid.CurrentColumn.Header.ToString())
                {
                    case "Час": columnIndexes.Add(0); break;
                    case "Координата X": columnIndexes.Add(1); break;
                    case "Координата Y": columnIndexes.Add(2); break;
                }
            }
            if (columnIndexes.Count == 2)
            {
                pane.CurveList.Clear();
                pane.XAxis.Title.Text = TableGrid.Columns[columnIndexes[0]].Header.ToString();
                pane.YAxis.Title.Text = TableGrid.Columns[columnIndexes[1]].Header.ToString();
                PointPairList tempList = new PointPairList();
                for (int i = 0; i < pointStates.Count; i++)
                {
                    tempList.Add(pointStates[i].Coordinates[columnIndexes[0]], pointStates[i].Coordinates[columnIndexes[1]]);
                }
                LineItem someLine = pane.AddCurve(pane.YAxis.Title.Text + "(" + pane.XAxis.Title.Text + ")", tempList, System.Drawing.Color.Red, SymbolType.None);
                someLine.Line.DashOn = 2.0F;
                someLine.Line.DashOff = 3.0F;
                someLine.Line.Width = 3.0F;
                RedrawGraph();
                columnIndexes.Clear();
            }
        }

        private void XCoordinateTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            XCoordinateTextBox.Foreground = new SolidColorBrush(Colors.Black);
            XCoordinateTextBox.Text = "";
        }

        private void YCoordinateTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            YCoordinateTextBox.Foreground = new SolidColorBrush(Colors.Black);
            YCoordinateTextBox.Text = "";
        }

        private void XCoordinateTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(XCoordinateTextBox.Text))
            {
                XCoordinateTextBox.Foreground = new SolidColorBrush(Colors.Gray);
                XCoordinateTextBox.Text = "Координата X";
            }
        }

        private void YCoordinateTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(YCoordinateTextBox.Text))
            {
                YCoordinateTextBox.Foreground = new SolidColorBrush(Colors.Gray);
                YCoordinateTextBox.Text = "Координата Y";
            }
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
