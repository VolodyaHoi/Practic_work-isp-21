using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibMas
{
    public class Class1
    {
        // функции для массива

        public static void masGenerate(out int[] array2, int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++)
            {
                Random rnd = new Random();
                array[i] = rnd.Next(1, 9);
            }
            array2 = array;

        }

    }
}





