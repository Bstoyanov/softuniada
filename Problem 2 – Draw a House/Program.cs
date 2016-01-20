using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2___Draw_a_House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = (n*2) - 1;
            int dotsIndex = n - 1;
            int asteriskIndex = 1;
            string sideDots = new string('.',dotsIndex);
            Console.WriteLine("{0}*{0}",sideDots);
            dotsIndex--;
            int middleIndex = 1;
            string middleSpace;
            while (dotsIndex > 0)
            {
                sideDots = new string('.',dotsIndex);
                middleSpace = new string(' ',middleIndex);
                Console.WriteLine("{0}*{1}*{0}",sideDots,middleSpace);
                middleIndex += 2;
                dotsIndex--;
            }
            for (int i = 0; i < width; i++)
            {
                if (i % 2 ==0)
                {
                    Console.Write('*');
                }
                else
                {
                    Console.Write(' ');
                }
            }
            Console.WriteLine();
            Console.WriteLine("+{0}+",new string('-',width-2));
            for (int i = 0; i < n-2; i++)
            {   
                 
                Console.WriteLine("|{0}|",new string(' ',width-2));
            }
            Console.WriteLine("+{0}+", new string('-', width - 2));

        }
    }
}
