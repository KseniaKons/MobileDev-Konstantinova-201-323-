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

namespace WpfResources
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        Random rnd = new Random();   
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButChangt_Background_Plai(object sender, RoutedEventArgs e)
        {
            this.Resources["Background_Plai"] = new SolidColorBrush(
                Color.FromRgb((byte)rnd.Next(256), (byte)rnd.Next(256), (byte)rnd.Next(256)));

        }

        private void ButChangtContentPlai(object sender, RoutedEventArgs e)
        {
            this.Resources["Content_Plai"] = $"plai {rnd.Next(100, 1000)}";
        }
    }
}
