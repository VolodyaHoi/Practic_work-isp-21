using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib_9
{
    public class lib9
    {
        public static void production(int[] array, out int product)
        {
            int prod = 1;
            for (int i = 0; i < array.Length; i++)
            {
                prod *= array[i];
            }
            product = prod;
        }
    }
}
