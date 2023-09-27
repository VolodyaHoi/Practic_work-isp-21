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
using LibMas;
using Lib_9;

namespace Pr2
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

        private void btn_Generate(object sender, RoutedEventArgs e)
        {
            int n;
            int[] matrix;
            bool isNum = int.TryParse(tb_M.Text, out n);
            bool isNum2 = int.TryParse(tb_N.Text, out n);
            if (isNum && isNum)
            {
                LibMas.libmas.masGenerate(n, out matrix);
                //вывод в дата грид
            } else { MessageBox.Show("Кол-во строк или столбцов не корректны!"); }

        }

        private void btn_Open(object sender, RoutedEventArgs e)
        {
            String filename = "matrix.txt";
            LibMas.libmas.masOpen(filename, out int[] matrix);
            //вывод в дата грид
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            String filename = "matrix.txt";
            int m = Convert.ToInt32(tb_M.Text);
            int n = Convert.ToInt32(tb_N.Text);
            int[,] matrix = new int[m, n];
            //создание матрицы из дата грид
            LibMas.libmas.masSave(filename, matrix);
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            //очистить дата грид
        }

        private void btn_Prod(object sender, RoutedEventArgs e)
        {
            // поиск суммы
            
        }

        private void btn_AllClear(object sender, RoutedEventArgs e)
        {
            // полная очистка
        }

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №3. Мансуров В. ИСП-31. Вариант №9");
        }

        private void click_Clear(object sender, MouseButtonEventArgs e)
        {
            tb_M.Text = "";
        }

        private void click_Clear2(object sender, MouseButtonEventArgs e)
        {
            tb_N.Text = "";
        }
    }

}
