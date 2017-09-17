using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diploma
{
    public class CoordinateTransformer
    {
        PictureBox drawPlane;
        Derives derives;
        public CoordinateTransformer()
        {
            
        }
        public CoordinateTransformer(PictureBox drawPlane, Derives derives)
        {
            this.drawPlane = drawPlane;
            this.derives = derives;
        }
        public double TransformXtoLocal(double X)
        {
            return (X - drawPlane.Width / 2) * (float)derives.A / (drawPlane.Width * 0.4F);
        }

        public double TransformYtoLocal(double Y)
        {
            return (drawPlane.Height * 0.9F - Y) * (float)derives.A / (drawPlane.Height * 0.8F);
        }

        public float TransformXtoPlane(double X)
        {
            return (float)X * 0.4F * drawPlane.Width / (float)(derives.A) + drawPlane.Width / 2;
        }

        public float TransformYtoPlane(double Y)
        {
            return drawPlane.Height * 0.9F - (float)Y * drawPlane.Height * 0.8F / (float)derives.A;
        }
    }
}
