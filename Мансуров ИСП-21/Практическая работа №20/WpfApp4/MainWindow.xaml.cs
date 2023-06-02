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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /*  Вычислить сумму целых случайных чисел, распределенных в диапазоне от 2 до 10, пока 
    эта сумма не превышает некоторого числа K.Вывести на экран сгенерированные числа, 
значение суммы, и количество сгенерированных чисел */
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void startAlg(object sender, RoutedEventArgs e)
        {
            numbers.Items.Clear();
            int sum = 0, numRand = 0, K, count = 0, n;
            bool f1 = Int32.TryParse(getKValue.Text, out n);
            if (f1 == true)
            {
                K = Convert.ToInt32(getKValue.Text);
                Random rnd = new Random();
                while (sum < K)
                {
                    numRand = rnd.Next(2, 10);
                    numbers.Items.Add(numRand);
                    sum += numRand;
                    count++;
                }
                numbers.Items.Remove(numbers.Items[count - 1]);
                result.Text = $"Сумма: {sum - numRand}. Количество сгененрированных чисел: {count - 1}";
            }
        }
    }
}
