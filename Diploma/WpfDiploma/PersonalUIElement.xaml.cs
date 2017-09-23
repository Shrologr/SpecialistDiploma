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
        public List<CustomPoint> TrajectoryPoints { get; set; }
        public List<CustomPoint> PuankarePoints { get; set; }
        public CoordinateTransformer CoordTransformer { get; set; }
        public PersonalUIElement()
        {
            InitializeComponent();
            Points = new List<CustomPoint>();
            TrajectoryPoints = new List<CustomPoint>();
            CoordTransformer = new CoordinateTransformer();
            PuankarePoints = new List<CustomPoint>();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            Pen axisPen = new Pen(new SolidColorBrush(Colors.Black), 2.5);
            drawingContext.DrawRectangle(new SolidColorBrush(Colors.White), new Pen(new SolidColorBrush(Colors.White), 2.5), new Rect(0, 0, ActualWidth, ActualHeight));
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
                drawingContext.DrawEllipse(Points[i].PointBrush, new Pen(Points[i].PointBrush, 2.0), new Point(CoordTransformer.TransformXtoPlane(Points[i].Coordinates[0]), CoordTransformer.TransformYtoPlane(Points[i].Coordinates[1])), 0.8, 0.8);
            }
            for (int i = 0; i < PuankarePoints.Count; i++)
            {
                drawingContext.DrawEllipse(PuankarePoints[i].PointBrush, new Pen(PuankarePoints[i].PointBrush, 2.0), new Point(CoordTransformer.TransformXtoPlane(PuankarePoints[i].Coordinates[0]), CoordTransformer.TransformYtoPlane(PuankarePoints[i].Coordinates[1])), 0.8, 0.8);
            }
            for (int j = 0; j < TrajectoryPoints.Count - Points.Count; j++)
            {
                drawingContext.DrawLine(new Pen(TrajectoryPoints[j].PointBrush, 1.5), new Point(CoordTransformer.TransformXtoPlane(TrajectoryPoints[j].Coordinates[0]), CoordTransformer.TransformYtoPlane(TrajectoryPoints[j].Coordinates[1])), new Point(CoordTransformer.TransformXtoPlane(TrajectoryPoints[j + Points.Count].Coordinates[0]), CoordTransformer.TransformYtoPlane(TrajectoryPoints[j + Points.Count].Coordinates[1])));
            }
            base.OnRender(drawingContext);
        }
    }
}
