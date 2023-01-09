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

namespace wpfEventRoute
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

        private void ButtonClear(object sender, RoutedEventArgs e)
        {
           lbLogs.Items.Clear();
        }

        private void All_MouseDown(object sender, MouseButtonEventArgs e)
        {
            lbLogs.Items.Add($"All_MouseDown \n sender = {sender} \n e.Source = {e.Source}");
        }

        private void All_MouseEnter(object sender, MouseEventArgs e)
        {
            lbLogs.Items.Add($"{nameof(All_MouseEnter)} \n sender = {sender} \n e.Source = {e.Source}");
        }
    }
}
