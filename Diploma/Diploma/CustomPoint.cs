using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Diploma
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
                    pointBrush = new SolidBrush(brushColor);
                    return pointBrush;
            }
        }
        public Color BrushSolor 
        {
            set 
            {
                brushColor = value;
                pointBrush = new SolidBrush(brushColor);
            }
            get 
            {
                return brushColor;
            }
        }
        public CustomPoint(double[] coordinates)
        {
            Coordinates = (double[])coordinates.Clone();
            pointBrush = new SolidBrush(Color.Black);
        }
        public CustomPoint(double[] coordinates, Color brushColor)
        {
            BrushSolor = brushColor;
            Coordinates = (double[])coordinates.Clone();
        }
        public CustomPoint() : this(new double[2]) { }

    }
}
