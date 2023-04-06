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

namespace WpfApp2
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

        private void firstCheckBox(object sender, RoutedEventArgs e)
        {
            if (statusCB1.IsChecked == true) 
            { 
                statusCB1.IsEnabled = true;
                secondQ.IsEnabled = false;
                statusCB2.IsEnabled= false;
            }
            else 
            { 
                statusCB1.IsEnabled = false;
                secondQ.IsEnabled = true;
                statusCB2.IsEnabled= true;
            }
        }

        private void secondCheckBox(object sender, RoutedEventArgs e)
        {
            if (statusCB2.IsChecked == true) 
            { 
                statusCB2.IsEnabled = true; 
                firstQ.IsEnabled = false;
                statusCB1.IsEnabled = false;
            }
            else 
            { 
                statusCB2.IsEnabled = false; 
                firstQ.IsEnabled = true;
                statusCB1.IsEnabled = true;
            }
        }

        private void buttonClicked(object sender, RoutedEventArgs e)
        {

        }

        private void january(object sender, RoutedEventArgs e)
        {

        }

        private void february(object sender, RoutedEventArgs e)
        {

        }

        private void marth(object sender, RoutedEventArgs e)
        {

        }

        private void april(object sender, RoutedEventArgs e)
        {

        }

        private void may(object sender, RoutedEventArgs e)
        {

        }
    }
}
