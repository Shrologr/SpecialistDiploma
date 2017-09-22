﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDiploma
{
    /// <summary>
    /// Interaction logic for PersonalUIElement.xaml
    /// </summary>
    public partial class PersonalUIElement : UserControl
    {
        public List<CustomPoint> Points { get; set; }
        public CoordinateTransformer CoordTransformer { get; set; }
        public PersonalUIElement()
        {
            InitializeComponent();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            Pen axisPen = new Pen(new SolidColorBrush(Colors.Black), 2.5);
            drawingContext.DrawLine(axisPen, new Point(ActualWidth / 2, ActualHeight * 0.9F), new Point(ActualWidth / 2, 0));
            drawingContext.DrawLine(axisPen, new Point(0, ActualHeight * 0.9F), new Point(ActualWidth, ActualHeight * 0.9F));
            double x0 = ActualWidth / 2 + ActualWidth * 0.4 * Math.Cos(0);
            double y0 = ActualHeight * 0.9 - ActualHeight * 0.8 * Math.Sin(0);
            for (double t = Math.PI / 64; t <= Math.PI; t += Math.PI / 64)
            {
                double x1 = ActualWidth / 2 + ActualWidth * 0.4 * Math.Cos(t);
                double y1 = ActualHeight * 0.9 - ActualHeight * 0.8 * Math.Sin(t);
                drawingContext.DrawLine(axisPen, new Point(x0, y0), new Point(x1, y1));
                x0 = x1;
                y0 = y1;
            }
            for (int i = 0; i < Points.Count; i++)
            {
                drawingContext.DrawEllipse(Points[i].PointBrush, new Pen(Points[i].PointBrush, 2.0), new Point(CoordTransformer.TransformXtoPlane(Points[i].Coordinates[0]), CoordTransformer.TransformYtoPlane(Points[i].Coordinates[1])), 1.5, 1.5);
            }
        }
    }
}
