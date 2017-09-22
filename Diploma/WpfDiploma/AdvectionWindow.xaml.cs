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
            someElement.CoordTransformer = coordTransformer;
            someElement.Points = points;
            coordTransformer = new CoordinateTransformer(someElement, derives);
            derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
        }

        private void AdvectionDataChanged(object sender, TextChangedEventArgs e)
        {
            derives.SetData(StraightSpeedTextBox.Text, CircularSpeedTextBox.Text, CircleRadiusTextBox.Text, RotationPeriodTextBox.Text);
            someElement.InvalidateVisual();
        }
    }
}