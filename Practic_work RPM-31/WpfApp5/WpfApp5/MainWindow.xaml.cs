using System;
using System.Collections.Generic;
using System.IO;
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

namespace WpfApp5
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int[] massive;
        public MainWindow()
        {
            InitializeComponent();
        }

        // управление массивом

        private void btn_Generate(object sender, RoutedEventArgs e)
        {
            int n;
            bool isNum = int.TryParse(tb_Mas.Text, out n);
            if (isNum)
            {
                lb_Mas.Items.Clear();
                LibMas.Class1.masGenerate(out int[] array2, n);
                massive = array2;
                for (int i = 0; i < array2.Length; i++)
                {
                    lb_Mas.Items.Add(array2[i]);
                }


            } else { MessageBox.Show("Введенное значение не является числом!");  }
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            lb_Mas.Items.Clear();
        }


        // решение задачи
        private void btn_Start(object sender, RoutedEventArgs e)
        {
            if(massive != null)
            {
                Lib_9.Class1.production(massive, out int prod);
                tb_QuestProd.Text = $"Произведение: {prod}";
            }
            else { MessageBox.Show("Массив не создан"); }

        }
       

        // прочее

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void tb_MasClear(object sender, MouseButtonEventArgs e)
        {
            tb_Mas.Text = "";
        }

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Мансуров В.\nГруппа: ИСП-31\nВариант №9");
        }
    }
}



