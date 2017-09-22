using System;
using System.Collections.Generic;
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
        public delegate void PictureBoxCall();
        Derives derives;
        List<CustomPoint> points;
        DrawState advectionState;
        Random pointRandom;
        CoordinateTransformer coordTransformer;
        public AdvectionWindow()
        {
            pointRandom = new Random();
            points = new List<CustomPoint>();
            derives = new Derives();
            advectionState = new DrawState(derives, 0, 0, points);
            InitializeComponent();
            uiElement.CoordTransformer = coordTransformer;
            uiElement.Points = points;
            coordTransformer = new CoordinateTransformer(uiElement, derives);
            derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
        }

        private void AdvectionDataChanged(object sender, TextChangedEventArgs e)
        {
            derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
            uiElement.InvalidateVisual();
        }

        private void uiElement_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isAddingActive = true;
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
            else
                if (e.LeftButton == MouseButtonState.Pressed)
                    for (int i = 0; i < PointNumberSlider.Value; i++)
                    {
                        AddNewPoint(points, e.GetPosition(uiElement).X + pointRandom.Next(Convert.ToInt32(PointSizeSlider.Value) * 2) - Convert.ToInt32(PointSizeSlider.Value), e.GetPosition(uiElement).Y + pointRandom.Next(Convert.ToInt32(PointSizeSlider.Value) * 2) - Convert.ToInt32(PointSizeSlider.Value));
                    }
            uiElement.InvalidateVisual();
        }

        private void uiElement_MouseMove(object sender, MouseEventArgs e)
        {
            if (isAddingActive)
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
                else
                    if (e.LeftButton == MouseButtonState.Pressed)
                        for (int i = 0; i < PointNumberSlider.Value; i++)
                        {
                            AddNewPoint(points, e.GetPosition(uiElement).X + pointRandom.Next(Convert.ToInt32(PointSizeSlider.Value) * 2) - Convert.ToInt32(PointSizeSlider.Value), e.GetPosition(uiElement).Y + pointRandom.Next(Convert.ToInt32(PointSizeSlider.Value) * 2) - Convert.ToInt32(PointSizeSlider.Value));
                        }
                uiElement.InvalidateVisual();
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
            
        }
    }
}