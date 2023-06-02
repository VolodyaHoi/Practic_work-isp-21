using Class1;
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
using Microsoft.Win32;
using System.IO;

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    // Ввести n целых чисел. Найти произведение чисел > 2. Результат вывести на экран

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        //Задание 1
        
        int[] mas;
        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int indexColumn = e.Column.DisplayIndex;
            int indexRow = e.Row.GetIndex();
            mas[indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
        }

        private void miFill_Click(object sender, RoutedEventArgs e)
        {
            bool randMaxIsNumber = Int32.TryParse(tbDiapazon.Text, out int n);
            bool CountIsNumber = Int32.TryParse(tbColumnCount.Text, out int d);
            if (randMaxIsNumber && CountIsNumber == true)
            {
                int randMax = Convert.ToInt32(tbDiapazon.Text);
                int Count = Convert.ToInt32(tbColumnCount.Text);
                mas = new int[Count];
                Random Rand = new Random();
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Rand.Next(randMax);
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }

        }

        private void miCalc_Click(object sender, RoutedEventArgs e)
        {
            int sum = 1;
            for (int i = 0; i < mas.Length;i++) 
                if (mas[i] > 2) { sum = sum * mas[i]; }
            tbRez.Text = Convert.ToString(sum);
        }

        private void miClear_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
        }

        private void miCreate_Click(object sender, RoutedEventArgs e)
        {
            bool CountIsNumber = Int32.TryParse(tbColumnCount.Text, out int d);
            if (CountIsNumber == true)
            {
                int Count = Convert.ToInt32(tbColumnCount.Text);
                mas = new int[Count];
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }
        }

        private void btn_Save(object sender, RoutedEventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = ".txt";
            save.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            save.FilterIndex = 2;
            save.Title = "Сохранить таблицу в txt";

            if (save.ShowDialog() == true)
            {
                StreamWriter file = new StreamWriter(save.FileName);

                file.WriteLine(mas.Length);

                for (int i = 0; i < mas.Length; i++)
                {
                    file.WriteLine(mas[i]);
                }
                file.Close();
            }
        }

        private void btn_Open(object sender, RoutedEventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.DefaultExt = ".txt";
            open.Filter = "Все файлы (*.*) | *.* | Текстовые файлы | *.txt";
            open.FilterIndex = 2;
            open.Title = "Открыть таблицу txt";

            if (open.ShowDialog() == true)
            {
                StreamReader file = new StreamReader(open.FileName);
                
                int len = Convert.ToInt32(file.ReadLine());

                mas = new Int32[len];
                for (int i = 0; i < mas.Length; i++)
                {
                    mas[i] = Convert.ToInt32(file.ReadLine());
                }
                file.Close();

            }

            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
    }
} 

