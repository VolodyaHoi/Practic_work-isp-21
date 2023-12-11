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

namespace WpfApp1
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

        private void menu_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void menu_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №3. Мансуров В. ИСП-31. Вариант №9");
        }

        private void menu_SetFilter(object sender, RoutedEventArgs e)
        {

        }

        private void btn_AddBookCallback(object sender, RoutedEventArgs e)
        {
            Class1 o = new Class1("test", "test", "test", 1);

            dg_AllBooks.Items.Add(o) ;
        }
    }
}
