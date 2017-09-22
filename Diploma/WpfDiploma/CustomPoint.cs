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
    [Serializable]
    public class CustomPoint
    {
        public double[] Coordinates;
        [NonSerialized]
        Brush pointBrush;
        Color brushColor;
        public Brush PointBrush 
        {
            get 
            {
                if (pointBrush == null)
                    pointBrush = new SolidColorBrush(brushColor);
                    return pointBrush;
            }
        }
        public Color BrushColor 
        {
            set 
            {
                brushColor = value;
                pointBrush = new SolidColorBrush(brushColor);
            }
            get 
            {
                return brushColor;
            }
        }
        public CustomPoint(double[] coordinates)
        {
            Coordinates = (double[])coordinates.Clone();
            pointBrush = new SolidColorBrush(Colors.Black);
        }
        public CustomPoint(double[] coordinates, Color brushColor)
        {
            BrushColor = brushColor;
            Coordinates = (double[])coordinates.Clone();
        }
        public CustomPoint() : this(new double[2]) { }

    }
}
