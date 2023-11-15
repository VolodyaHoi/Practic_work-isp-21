using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Triad
    {
        // Использовать класс Triad (тройка нечетных чисел). Разработать операции проверки
        // полного равенства/неравенства чисел в триадах(a1, b1, c1) == (a2, b2, c2).
        // Разработать операции определения, что вся тройка чисел нечетна true/false

        public int Equals2(int[] fTriad, int[] sTriad)
        {
            int id = 0;
            int equalNum = 0;

            for (int i = 0; i < fTriad.Length; i++)
            {
                if (fTriad[i] == sTriad[i])
                {
                    equalNum++;
                }
            }

            if (equalNum == 3)
            {
                id = 1;

            }
            else { id = 0; }

            return id;

        }

        public int Equals2(int[] fTriad, int[] sTriad, int[] tTriad)
        {
            int id = 0;
            int equalNum = 0;

            for (int i = 0; i < fTriad.Length; i++)
            {
                if (fTriad[i] == sTriad[i] && fTriad[i] == tTriad[i] && sTriad[i] == tTriad[i])
                {
                    equalNum++;
                }
            }

            if (equalNum == 3)
            {
                id = 1;

            }
            else { id = 0; }


            return id;
        }

        public bool twoNotTwo(int[] Triad) 
        {
            bool two;
            int count = 0;
            for(int i = 0;  i < Triad.Length; i++)
            {
                if (Triad[i] % 2 == 0)
                {
                    count++;
                }
            }

            if (count == 3)
            {
                two = true;
            } else {  two  = false; }

            return two;
        }

    }
}
