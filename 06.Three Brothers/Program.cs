using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Three_Brothers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSacks = int.Parse(Console.ReadLine());
            for (int i = 0; i < numberOfSacks; i++)
            {
                List<int> sack = Console.ReadLine().Split().Select(int.Parse).ToList();
                if (sack.Sum() % 3 ==0 )
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}
