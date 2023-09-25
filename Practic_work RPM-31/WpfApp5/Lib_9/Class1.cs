using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_9
{
    public class Class1
    {
        public static void production(int[] array, out int prod)
        {
            int product = 1, value;
            Random rnd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                value = rnd.Next(1, 10);
                product = product * value;
            }
            prod = product;
        }
    }
}
