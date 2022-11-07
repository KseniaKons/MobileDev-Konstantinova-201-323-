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

namespace WpfTabs
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

        private void cmdAddPage_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            tc.Items.Add("new");
        }

        private void cmdDeletCurPage_Execute(object sender, ExecutedRoutedEventArgs e)
        {
            //tc.Items.Clear();   //все очистить
            tc.Items.RemoveAt(tc.SelectedIndex); //удаление по индексу
        }
    }

    public class MyCommands
    {
        public static RoutedCommand cmdAddPage { get; set; } = new("cmdAddPage", typeof(MainWindow));
        public static RoutedCommand cmdDeletCurPage { get; set; } = new("cmdDeletCurPage", typeof(MainWindow));
    }
}
