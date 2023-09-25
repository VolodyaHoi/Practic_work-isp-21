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
            string[] values = File.ReadAllText(file).Split(' ');
            int[] array = new int[values.Length - 1];

            for (int i = 0; i < values.Length - 1; i++)
            {
                array[i] = Convert.ToInt32(values[i]);
            }
            array2 = array;

        }

        public static void masSave(String file, int[] array)
        {
            StreamWriter writer = new StreamWriter(file);
            
            for(int i = 0; i < array.Length; ++i)
            {
                writer.Write(array[i]);
            }
            
        }
    }
}
