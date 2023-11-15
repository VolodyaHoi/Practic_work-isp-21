using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Triad
    {
        // Создать класс Triad (тройка нечетных чисел). Создать необходимые методы и 
        // свойства.Определить метод сравнения двух триад на равенство.Создать
        // перегруженный метод сравнения трех триад на равенство.

        public int Equals2(int[] fTriad, int[] sTriad)
        {
            int id = 0;
            int equalNum = 0;

            for(int i = 0; i < fTriad.Length; i++)
            {
                for(int j = 0 ; j < sTriad.Length ; j++)
                {
                    if (fTriad[i] == sTriad[j])
                    {
                        equalNum++;
                        break;

                    }
                }
                
            }
            if (equalNum == 3)
            {
                id = 1;
            } else { id = 0; }

            return id;

        }

        public int Equals2(int[] fTriad, int[] sTriad, int[] tTriad)
        {
            int id = 0;
            int equalNum = 0;

            for (int i = 0; i < fTriad.Length; i++) 
            {
                for (int j = 0; j < sTriad.Length; j++)
                {
                    if (fTriad[i] == sTriad[j])
                    {
                        equalNum++;
                        break;

                    }
                }

            } 

            for (int i = 0; i < fTriad.Length; i++)
            {
                for (int j = 0; j < tTriad.Length; j++)
                {
                    if (fTriad[i] == tTriad[j])
                    {
                        equalNum++;
                        break;

                    }
                }

            } 

            if (equalNum == 6)
            {
                id = 1;
            }
            else { id = 0; }

            return id;
        }

    }
}
