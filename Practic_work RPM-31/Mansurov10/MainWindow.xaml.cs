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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<int> numbers;
        public MainWindow()
        {
            InitializeComponent();
            numbers = new List<int>();
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
            int k;
            int sum = 0;
            for (int i = 0; i < numbers.Count; i++)
            {
                sum = sum + numbers[i];
            }
            k = sum / numbers.Count;
            MessageBox.Show($"Результат: среднее арифметическое равно {k}");
        }

        private void btn_Add(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(tb_num.Text, out int num))
            {
                if (num > 0)
                {
                    MessageBox.Show("Число не соответствует условию");
                } else
                {
                    numbers.Add(num);
                    lb_num.Items.Add(num.ToString());
                }             
            }
            else
            {
                MessageBox.Show("Неправильная форма числа!");
            }
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            numbers.Clear();
            lb_num.Items.Clear();
        }
    }
}
