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
    public class CoordinateTransformer
    {
        PersonalUIElement drawPlane;
        Derives derives;
        public CoordinateTransformer()
        {
            
        }
        public CoordinateTransformer(PersonalUIElement drawPlane, Derives derives)
        {
            this.drawPlane = drawPlane;
            this.derives = derives;
        }
        public double TransformXtoLocal(double X)
        {
            return (X - drawPlane.ActualWidth / 2) * (float)derives.A / (drawPlane.ActualWidth * 0.4F);
        }

        public double TransformYtoLocal(double Y)
        {
            return (drawPlane.ActualHeight * 0.9F - Y) * (float)derives.A / (drawPlane.ActualHeight * 0.8F);
        }

        public float TransformXtoPlane(double X)
        {
            return (float)X * 0.4F * (float)drawPlane.ActualWidth / (float)(derives.A) + (float)drawPlane.ActualWidth / 2;
        }

        public float TransformYtoPlane(double Y)
        {
            return (float)drawPlane.ActualHeight * 0.9F - (float)Y * (float)drawPlane.ActualHeight * 0.8F / (float)derives.A;
        }
    }
}
