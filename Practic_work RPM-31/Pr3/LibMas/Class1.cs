using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;

namespace LibMas
{
    static class VisualArray
    {
        //Метод для двухмерного массива
        public static DataTable ToDataTable<T>(this T[,] matrix)
        {
            var res = new DataTable();
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                res.Columns.Add("col" + (i + 1), typeof(T));
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                var row = res.NewRow();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    row[j] = matrix[i, j];
                }

                res.Rows.Add(row);
            }

            return res;
        }


    }
    public class libmas
    {
        /// <summary>
        /// Генерация массива
        /// </summary>
        /// <param name="size"></param>
        /// <param name="array2"></param>
        public static void masGenerate(int size, out int[] array2)
        {
            int[] array = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(1, 20);
            }
            array2 = array;
        }

        /// <summary>
        /// Открытие массива из текстового файла
        /// </summary>
        /// <param name="file"></param>
        /// <param name="array2"></param>
        public static void masOpen(String file, out int[] array2)
        {
            String line;
            int value;
            StreamReader reader = new StreamReader(file);
            line = reader.ReadLine();
            int[] array = new int[Convert.ToInt32(line)];
            for (int i = 0; i < Convert.ToInt32(line); i++)
            {
                value = Convert.ToInt32(reader.ReadLine());
                array[i] = value;
            }
            array2 = array;

        }

        /// <summary>
        /// Сохранение массива в текстовый файл
        /// </summary>
        /// <param name="file"></param>
        /// <param name="array"></param>
        public static void masSave(String file, int[,] array)
        {
            int j = 0;
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i, j]);
            }
            writer.Close();
        }
    }
}
