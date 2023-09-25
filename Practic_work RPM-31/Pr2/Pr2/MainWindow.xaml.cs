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
            int[] array;
            bool isNum = int.TryParse(tb_Mas.Text, out n);
            if (isNum)
            {
                lb_Mas.Items.Clear();

                LibMas.libmas.masGenerate(n, out array);
                for (int i = 0; i < array.Length; i++)
                {
                    lb_Mas.Items.Add(array[i]);
                }
            } else { MessageBox.Show("Кол-во элементов не является числовым значением!"); }

        }

        private void btn_Open(object sender, RoutedEventArgs e)
        {
            lb_Mas.Items.Clear();
            String filename = "C:/Users/исп-31/Desktop/massive.txt";
            LibMas.libmas.masOpen(filename, out int[] array);
            for (int i = 0; i < array.Length; i++)
            {
                lb_Mas.Items.Add(array[i]);
            }
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            String filename = "C:/Users/исп-31/Desktop/massive.txt";
            int[] array = new int[lb_Mas.Items.Count];
            int stat;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(lb_Mas.Items[i]);
            }
            LibMas.libmas.masSave(filename, array);
        }

        private void btn_Clear(object sender, RoutedEventArgs e)
        {
            lb_Mas.Items.Clear();
        }

        private void btn_Prod(object sender, RoutedEventArgs e)
        {
            int prod;
            
            if (lb_Quest != null)
            {
                int[] array = new int[lb_Quest.Items.Count];
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] = Convert.ToInt32(lb_Quest.Items[i]);
                }
                Lib_9.lib9.production(array, out prod);
                tb_QuestProd.Text = $"Произведение: {prod}";
            } else { MessageBox.Show("Вы не добавили ни одного элемента!"); }
            
        }

        private void btn_AllClear(object sender, RoutedEventArgs e)
        {
            lb_Mas.Items.Clear();
            lb_Quest.Items.Clear();
        }

        private void btn_Exit(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn_Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №2. Мансуров В. ИСП-31. Вариант №9");
        }

        private void click_Clear(object sender, MouseButtonEventArgs e)
        {
            tb_Mas.Text = "";
        }

        private void click_Clear2(object sender, MouseButtonEventArgs e)
        {
            tb_QuestAdd.Text = "";
        }

        private void click_Clear3(object sender, MouseButtonEventArgs e)
        {
            tb_QuestProd.Text = "";
        }

        private void btn_Add(object sender, RoutedEventArgs e)
        {
            int n;
            bool isNum = int.TryParse(tb_QuestAdd.Text, out n);
            if (isNum)
            {
                if(n != 0)
                {
                    lb_Quest.Items.Add(n);
                } else { MessageBox.Show("Число не должно быть равно 0!"); }
            } else { MessageBox.Show("Число некорректно!"); }
        }
    }
}
