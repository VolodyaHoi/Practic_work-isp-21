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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Class;

namespace WpfApp7
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int[] a_Arr = new int[3];
        public int[] b_Arr = new int[3];
        public int[] c_Arr = new int[3];
        public MainWindow()
        {
            InitializeComponent();
        }

        private void test(object sender, RoutedEventArgs e)
        {
            int val, val2;
            int[] a = { 2, 3, 1 };
            int[] b = { 1, 2, 3 };
            int[] c = { 3, 2, 5 };

            Triad triad = new Triad();

            val = triad.Equals2(a, b);
            val2 = triad.Equals2(a, b, c);

            MessageBox.Show($"Первое - {val}, Второе - {val2}");
        }

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №5. Мансуров В. ИСП-31. Вариант №9");
        }

        private void menu_EqualTwoNumA(object sender, RoutedEventArgs e)
        {
            Triad triad = new Triad();
            // a and b
            int val = triad.Equals2(a_Arr, b_Arr);
            if (val == 1)
            {
                MessageBox.Show("Первая и вторая тройка равны");
            } else { MessageBox.Show("Первая и вторая тройка не равны"); }
        }

        private void menu_EqualThreeNum(object sender, RoutedEventArgs e)
        {
            Triad triad = new Triad();
            // a and b and c
            int val = triad.Equals2(a_Arr, b_Arr, c_Arr);
            if (val == 1)
            {
                MessageBox.Show("Все тройки равны");
            }
            else { MessageBox.Show("Тройки не равны"); }
        }

        private void menu_EqualTwoNumB(object sender, RoutedEventArgs e)
        {
            Triad triad = new Triad();
            // a and c
            int val = triad.Equals2(a_Arr, c_Arr);
            if (val == 1)
            {
                MessageBox.Show("Первая и третья тройка равны");
            }
            else { MessageBox.Show("Первая и третья тройка не равны"); }
        }

        private void menu_EqualTwoNumC(object sender, RoutedEventArgs e)
        {
            Triad triad = new Triad();
            // b and c
            int val = triad.Equals2(b_Arr, c_Arr);
            if (val == 1)
            {
                MessageBox.Show("Вторая и третья тройка равны");
            }
            else { MessageBox.Show("Вторая и третья тройка не равны"); }
        }

        private void menu_Generate(object sender, RoutedEventArgs e)
        {
            A.Items.Clear();
            B.Items.Clear();    
            C.Items.Clear();
            Random rnd = new Random();
            for (int i = 0; i < 3; i++)
            {
                int value = rnd.Next(1, 5);
                A.Items.Add(value);
                a_Arr[i] = value;   
            }
            for (int i = 0; i < 3; i++)
            {
                int value = rnd.Next(1, 5);
                B.Items.Add(value);
                b_Arr[i] = value;
            }
            for (int i = 0; i < 3; i++)
            {
                int value = rnd.Next(1, 5);
                C.Items.Add(value);
                c_Arr[i] = value;
            }
        }
    }

}
