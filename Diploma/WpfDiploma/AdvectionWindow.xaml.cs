using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
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
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri("file:///D://pause.ico", UriKind.Absolute);
                bi3.EndInit();
                StartPauseImage.Source = bi3;
            }
            else 
            {
                isPaused = !isPaused;
                BitmapImage bi3 = new BitmapImage();
                bi3.BeginInit();
                bi3.UriSource = new Uri((isPaused) ? "file:///D://start.ico" : "file:///D://pause.ico", UriKind.Absolute);
                bi3.EndInit();
                StartPauseImage.Source = bi3;
            }
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            isPaused = false;
            isActive = false;
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("file:///D://start.ico", UriKind.Absolute);
            bi3.EndInit();
            StartPauseImage.Source = bi3;
        }
    }
}