using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace WpfDiploma
{
    public static class ImageLoader
    {
        public static void LoadAndSetImage(Image image, string uri) 
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri(uri, UriKind.Absolute);
            bi3.EndInit();
            image.Source = bi3;
        }
        public static void LoadAndSetImage(Image image, string primatyUri, string alrernateUri, bool isPrimary)
        {
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri((isPrimary) ? primatyUri : alrernateUri, UriKind.Absolute);
            bi3.EndInit();
            image.Source = bi3;
        }
    }
}
