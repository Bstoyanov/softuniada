using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Sum_Time_Intervals
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> firstDate = Console.ReadLine().Replace("::", ":").Split(':').ToList();
            List<string> secondDate = Console.ReadLine().Replace("::", ":").Split(':').ToList();
            int numberOfDays = 0;
            bool days = false;
            if (firstDate.Count == 3)
            {
                numberOfDays += int.Parse(firstDate[0]);
                days = true;
                List<string> templist = new List<string>() { firstDate[1], firstDate[2] };
                firstDate.Clear();
                firstDate.AddRange(templist);
            }
            if (secondDate.Count == 3)
            {
                days = true;
                numberOfDays += int.Parse(secondDate[0]);
                List<string> templist = new List<string>() { secondDate[1], secondDate[2] };
                secondDate.Clear();
                secondDate.AddRange(templist);
            }
            int minutes = int.Parse(firstDate[1]) + int.Parse(secondDate[1]);
            int hours = (int.Parse(firstDate[0])) +(int.Parse(secondDate[0]));
            if (minutes >= 60)
            {
                hours += (minutes / 60);
                minutes %= 60;
            }
            string minutesTostr = "" + minutes;
            if (minutes < 10)
            {
                minutesTostr = "0" + minutes;
            }
            if (hours >= 24)
            {
                numberOfDays += (hours/24);
                days = true;
                hours %= 24;
            }
            if (days)
            {
                Console.WriteLine("{0}::{1}:{2}", numberOfDays, hours, minutesTostr);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hours, minutesTostr);

            }

        }
    }
}
