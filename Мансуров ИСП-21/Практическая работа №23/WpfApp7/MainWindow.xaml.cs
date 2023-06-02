using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp7
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

        private void btn_Paint_Click(object sender, RoutedEventArgs e)
        {
            Fpart1.Visibility = Visibility.Visible;
            Fpart2.Visibility = Visibility.Visible;
            Fpart3.Visibility = Visibility.Visible;
            O.Visibility = Visibility.Visible;
            Npart1.Visibility = Visibility.Visible;
            Npart2.Visibility = Visibility.Visible;
            Npart3.Visibility = Visibility.Visible;
        }

        private void btn_Fill_Click(object sender, RoutedEventArgs e)
        {
            Fpart1.Stroke = Brushes.Green;
            Fpart2.Stroke = Brushes.Green;
            Fpart3.Stroke = Brushes.Yellow;
            O.Stroke = Brushes.Blue;
            Npart1.Stroke = Brushes.Red;
            Npart2.Stroke = Brushes.Violet;
            Npart3.Stroke = Brushes.Red;
        }

        private void btn_Clear_Click(object sender, RoutedEventArgs e)
        {
            // Убрать слово
            Fpart1.Visibility = Visibility.Hidden;
            Fpart2.Visibility = Visibility.Hidden;
            Fpart3.Visibility = Visibility.Hidden;
            O.Visibility = Visibility.Hidden;
            Npart1.Visibility = Visibility.Hidden;
            Npart2.Visibility = Visibility.Hidden;
            Npart3.Visibility = Visibility.Hidden;

            // Убрать цвет
            Fpart1.Stroke = Brushes.Black;
            Fpart2.Stroke = Brushes.Black;
            Fpart3.Stroke = Brushes.Black;
            O.Stroke = Brushes.Black;
            Npart1.Stroke = Brushes.Black;
            Npart2.Stroke = Brushes.Black;
            Npart3.Stroke = Brushes.Black;
        }
    }
}
