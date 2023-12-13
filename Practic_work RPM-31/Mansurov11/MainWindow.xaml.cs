using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace Mansurov11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №10. Мансуров В. ИСП-31. Вариант №9");
        }

        private void btn_Start(object sender, RoutedEventArgs e)
        {
            string string1 = tb_string1.Text;
            string string2 = tb_string2.Text;

            // регулярные выражения
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            lb_str.Items.Clear();
        }
    }
    
}
