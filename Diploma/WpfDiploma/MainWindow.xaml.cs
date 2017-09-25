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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void AdvectionCallButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new AdvectionWindow().ShowDialog();
            Show();
        }

        private void PoincareWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new PoincareWindow().ShowDialog();
            Show();
        }

        private void TrajectoryWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new TrajectoryWindow().ShowDialog();
            Show();
        }

        private void StatisticsWindowButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new StatisticsWindow().ShowDialog();
            Show();
        }
    }
}
