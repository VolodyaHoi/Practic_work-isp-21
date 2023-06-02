using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
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


namespace WpfApp6
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

        int[,] mas;
        int[] maxValues;
        private void dataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            int indexColumn = e.Column.DisplayIndex;
            int indexRow = e.Row.GetIndex();
            mas[indexRow, indexColumn] = Convert.ToInt32(((TextBox)e.EditingElement).Text);
        }

        private void miFill_Click(object sender, RoutedEventArgs e)
        {
            bool randMaxIsNumber = Int32.TryParse(tbM.Text, out int n);
            bool CountIsNumber = Int32.TryParse(tbN.Text, out int d);
            if (randMaxIsNumber && CountIsNumber == true)
            {
                int randMax = Convert.ToInt32(tbM.Text);
                int Count = Convert.ToInt32(tbN.Text);
                mas = new int[randMax, Count];
                Random Rand = new Random();
                for (int i = 0; i < randMax; i++)
                {
                    for (int j = 0; j < Count; j++)
                    {
                        mas[i, j] = Rand.Next(20);
                    }
                }
                dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
            }

        }

        private void miCalc_Click(object sender, RoutedEventArgs e) // 0 2 6 1 5 
        {
            bool randMaxIsNumber = Int32.TryParse(tbM.Text, out int n);
            bool CountIsNumber = Int32.TryParse(tbN.Text, out int d);
            if (randMaxIsNumber && CountIsNumber == true)
            {
                int currentMax = -7;
                int Count = Convert.ToInt32(tbN.Text);
                maxValues = new int[Count + 1];
                int arrCount = 0;

                for (int i = 0; i < mas.GetLength(1); i++) // столбец
                {
                    for (int j = 0; j < mas.GetLength(0) - 1; j++) // строка
                    {
                        if (currentMax < mas[j, i])
                        {
                            currentMax = mas[j, i];
                        }

                    }
                    maxValues[arrCount] = currentMax;
                    arrCount++;
                    currentMax = -7;

                }


                int finallyCurrentMin = maxValues[0];
                for (int x = 0; x < maxValues.Length - 2; x++)
                {
                    if (finallyCurrentMin < maxValues[x + 1])
                    {
                        finallyCurrentMin = maxValues[x];
                    }
                    else { finallyCurrentMin = maxValues[x + 1]; }
                } 

                tbRez.Text = finallyCurrentMin.ToString();
                
            }
        }

        private void miClear_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
        }

        private void miCreate_Click(object sender, RoutedEventArgs e)
        {
            bool CountIsNumber = Int32.TryParse(tbN.Text, out int d);
            if (CountIsNumber == true)
            {
                int Count = Convert.ToInt32(tbN.Text);
                int randMax = Convert.ToInt32(tbM.Text);
                mas = new int[randMax, Count];
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

                file.WriteLine(mas.GetLength(0));
                file.WriteLine(mas.GetLength(1));

                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        file.WriteLine(mas[i, j]);
                    }
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

                int len0 = Convert.ToInt32(file.ReadLine());
                int len1 = Convert.ToInt32(file.ReadLine());

                mas = new Int32[len0, len1];


                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        mas[i,j] = Convert.ToInt32(file.ReadLine());
                    }
                }
                file.Close();

            }

            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }
    }
} 


