using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    // Использовать класс Triad (тройка нечетных чисел). Определить производный класс 
    // Time с полями: час, минута и секунда.Определить полный набор методов
    // сравнения моментов времени
    public class Time
    {
        private int hour;
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Second { get; set; }

        public Time(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        
    }

    class Second : Time
    {
        public Second(int hour, int minute, int second):
            base(hour, minute, second)
        { 

        }
    }


    
    public class Triad
    {
       

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

        public int[] getTime(int[] fTime, int[] sTime)
        {

            int timeHm, timeMm, timeSm; 
            int[] fullTime = new int[3];

            Time Ftime = new Time(fTime[0], fTime[1], fTime[2]);

            Time Stime = new Time(sTime[0], sTime[1], sTime[2]);

            timeHm = Ftime.Hour - Stime.Hour;
            timeMm = Ftime.Minute - Stime.Minute;
            timeSm = Ftime.Second - Stime.Second;

            if (timeHm < 0)
            {
                timeHm = timeHm * -1;
            }
            if (timeMm < 0)
            {
                timeMm = timeMm * -1;
            }
            if (timeSm < 0)
            {
                timeSm = timeSm * -1;
            }

            fullTime[0] = timeHm;
            fullTime[1] = timeMm;
            fullTime[2] = timeSm;

            return fullTime;
        }

    }
}
