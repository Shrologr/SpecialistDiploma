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
using Xceed.Wpf.Toolkit;

namespace WpfDiploma
{
    /// <summary>
    /// Interaction logic for AdvectionWindow.xaml
    /// </summary>
    public partial class AdvectionWindow : Window
    {
        bool isAddingActive;
        bool isActive, isPaused;
        bool isReadable;
        public delegate void PictureBoxCall();
        Derives derives;
        List<CustomPoint> points;
        DrawState advectionState;
        Random pointRandom;
        CoordinateTransformer coordTransformer;
        public AdvectionWindow()
        {
            isReadable = false;
            pointRandom = new Random();
            points = new List<CustomPoint>();
            derives = new Derives();
            advectionState = new DrawState(derives, 0, 0, points);
            InitializeComponent();
            coordTransformer = new CoordinateTransformer(uiElement, derives);
            uiElement.CoordTransformer = coordTransformer;
            uiElement.Points = points;
            derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
            uiElement.MouseDown += uiElement_MouseDown;
            uiElement.MouseUp += uiElement_MouseUp;
            uiElement.MouseMove += uiElement_MouseMove;
            isReadable = true;
            isActive = false;
        }

        private void AdvectionDataChanged(object sender, TextChangedEventArgs e)
        {
            if (isReadable)
            {
                derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
                uiElement.InvalidateVisual();
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
            double timeStep;
            if (!derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text) || !double.TryParse(TimeStepTextBox.Text,NumberStyles.Float, CultureInfo.InvariantCulture, out timeStep)) 
            {
                return;
            }
            
            RungeKutClass rungeKut = new RungeKutClass(2, 0, 0.01, 0.01);
            rungeKut.TimeStep = timeStep;
            PictureBoxCall caller = uiElement.InvalidateVisual;
            await Task.Run(() =>
            {
                for (int i = 1; isActive; i++)
                {
                    while (isPaused)
                    {
                        System.Threading.Thread.Sleep(100);
                    }
                    for (int j = 0; j < points.Count; j++)
                        rungeKut.Runge_Kut(points[j], derives);
                    rungeKut.RecalculateTime(i);
                    Dispatcher.Invoke(caller);
                    System.Threading.Thread.Sleep(1);
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
    }
}