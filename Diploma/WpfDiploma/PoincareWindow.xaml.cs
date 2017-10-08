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

namespace WpfDiploma
{
    /// <summary>
    /// Interaction logic for AdvectionWindow.xaml
    /// </summary>
    public partial class PoincareWindow : Window
    {
        bool isActive;
        bool isAddingActive;
        public delegate void WindowCall();
        public delegate void ProgressBarCall(double currentTime);
        public delegate void PoincareListCall(double x, double y, Color color);
        Derives derives;
        List<CustomPoint> points;
        List<CustomPoint> poicarePoints;
        DrawState advectionState;
        Random pointRandom;
        CoordinateTransformer coordTransformer;
        public PoincareWindow()
        {
            pointRandom = new Random();
            points = new List<CustomPoint>();
            poicarePoints = new List<CustomPoint>();
            derives = new Derives();
            advectionState = new DrawState(derives, 0, 0, points);
            InitializeComponent();
            coordTransformer = new CoordinateTransformer(uiElement, derives);

            uiElement.CoordTransformer = coordTransformer;
            uiElement.Points = points;
            uiElement.PuankarePoints = poicarePoints;

            uiElement.MouseDown += uiElement_MouseDown;
            uiElement.MouseUp += uiElement_MouseUp;
            uiElement.MouseMove += uiElement_MouseMove;
            StopButton.IsEnabled = false;
            isActive = false;
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
                pointList.Add(new CustomPoint(new double[] { x, y }, PointColorPicker.SelectedColor.Value));
        }

        private void NewPointButton_Click(object sender, RoutedEventArgs e)
        {
            double x, y;
            if (!double.TryParse(XCoordinateTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out x) || !double.TryParse(YCoordinateTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out y))
                return;
            if (Math.Sqrt(x * x + y * y) < derives.A && y > 0)
                points.Add(new CustomPoint(new double[] { x, y }, PointColorPicker.SelectedColor.Value));
            uiElement.InvalidateVisual();
        }
        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            uiElement.InvalidateVisual();
        }

        private async void StartModeling()
        {
            double calculationPeriod;
            try
            {
                derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, RotationPeriodTextBox.Text);
                if (!double.TryParse(CalculationTimeTextBox.Text, NumberStyles.Float, CultureInfo.InvariantCulture, out calculationPeriod))
                    throw new ApplicationException("Неправильний формат періоду моделювання");
                if (calculationPeriod <= 0)
                    throw new ApplicationException("Значення періоду моделювання має бути невід'ємним (більшим нула)");
            }
            catch (ApplicationException ex)
            {
                System.Windows.MessageBox.Show(ex.Message, "Помилка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            StopButton.IsEnabled = true;
            StartPauseButton.IsEnabled = false;
            isActive = true;
            uiElement.InvalidateVisual();
            poicarePoints.Clear();
            RungeKutClass rungeKut = new RungeKutClass(2, 0, 0.01, 0.01);
            WindowCall caller = uiElement.InvalidateVisual;
            PoincareListCall poincareCaller = (x, y, color) => { poicarePoints.Add(new CustomPoint(new double[] { x, y }, color)); };
            PoincareProgressBar.Minimum = 0;
            PoincareProgressBar.Maximum = calculationPeriod;
            ProgressBarCall progressBarCall = (double i) => { PoincareProgressBar.Value = i; };
            List<CustomPoint> spareList = new List<CustomPoint>();
            for (int i = 0; i < points.Count; i++)
            {
                spareList.Add(new CustomPoint(new double[] { points[i].Coordinates[0], points[i].Coordinates[1] }, points[i].BrushColor));
            }
            await Task.Run(() =>
            {
                for (int i = 1; rungeKut.CurrentTime < calculationPeriod && isActive; i++)
                {
                    for (int j = 0; j < points.Count; j++)
                    {
                        rungeKut.Runge_Kut(spareList[j], derives);
                        if (derives.Period - rungeKut.CurrentTime % derives.Period < rungeKut.TimeStep && derives.Period - rungeKut.CurrentTime % derives.Period > 0)
                            Dispatcher.Invoke(poincareCaller, spareList[j].Coordinates[0], spareList[j].Coordinates[1], spareList[j].BrushColor);
                    }
                    if (derives.Period - rungeKut.CurrentTime % derives.Period < rungeKut.TimeStep)
                        Dispatcher.Invoke(progressBarCall, rungeKut.CurrentTime);
                    rungeKut.RecalculateTime(i);
                    System.Threading.Thread.Sleep(1);
                }
            });
            PoincareProgressBar.Value = 0;
            StartPauseButton.IsEnabled = true;
            uiElement.InvalidateVisual();
            isActive = false;
        }

        private void StartPauseButton_Click(object sender, RoutedEventArgs e)
        {
            StartModeling();
        }
        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            if (isActive)
            {
                isActive = false;
                uiElement.InvalidateVisual();
            }
            else 
            {
                poicarePoints.Clear();
                uiElement.InvalidateVisual();
                StopButton.IsEnabled = false;
            }
        }

        private void SaveDataButton_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Simulation data (*.simuldata)|*.simuldata";
            bool? isSaved = saveFileDialog.ShowDialog();
            if (isSaved != null && isSaved == true)
            {
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
                    RotationPeriodTextBox.Text = advectionState.DeriveData.Period.ToString(CultureInfo.InvariantCulture);
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
