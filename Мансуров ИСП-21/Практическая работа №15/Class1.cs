using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public static int functionA(int fValue, int sValue)
        {
            if (fValue > sValue)
            {
                fValue *= 2;
                Console.WriteLine("Первое число увеличено в 2 раза!");
            }
            else { Console.WriteLine("Первое число меньше второго!"); }
            return fValue;
        }

        public static int functionB(int fValue, int sValue)
        {
            if (fValue > Math.Sqrt(sValue))
            {
                sValue *= 5;
                Console.WriteLine("Второе число увеличено в 5 раз!");
            }
            else { Console.WriteLine("Корень второго числа больше первого числа!"); }
            return fValue;
        }

        public static int functionC(int fValue, int sValue)
        {
            int summa = 0;
            if (fValue % 3 == 0 && sValue % 3 == 0)
            {
                summa = fValue + sValue;
                Console.WriteLine("Оба числа кратны трём,сумма подсчитана!");
            }
            else { Console.WriteLine("Оба,или одно из введенных чисел, не кратны 3!"); }
            return summa;
        }
    }
}

