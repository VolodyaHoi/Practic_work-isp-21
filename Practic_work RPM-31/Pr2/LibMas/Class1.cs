using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LibMas
{
    public class libmas
    {
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

        public static void masSave(String file, int[] array)
        {
            StreamWriter writer = new StreamWriter(file);
            writer.WriteLine(array.Length);
            for (int i = 0; i < array.Length; i++)
            {
                writer.WriteLine(array[i]);
            }
            writer.Close();
        }
    }
}
