using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zero_Subset
{
    class ZeroSubset
    {
        static void Main()
        {
            /*
             *We are given 5 integer numbers. Write a program that finds all subsets of these numbers whose sum is 0 .
             *Assume that repeating the same subset several times is not a problem
            */

            Console.WriteLine("Please write in whole numbers separated by one single white space.");
            Console.WriteLine("If you write less or some nonsense you'll also receive some nonsense too :)");

            string[] inputResult = Console.ReadLine().Split(' ');

            //step 1: add all of these in an array

            int[] inputNumbers = new int[5];

            for (int i = 0; i < Math.Min(5, inputResult.Length); i++)
            {
                int.TryParse(inputResult[i], out inputNumbers[i]);
            }


            //step 2: calculate all combinations of 0,1,2,3,4 with 2, 3 and 4 number chosen
            // https://www.mathsisfun.com/combinatorics/combinations-permutations-calculator.html
            // define them in array as below

            int[][] jaggedIndices = new int[][]
        {
            new int[]{0,1}, new int[]{0,2}, new int[]{0,3}, new int[]{0,4},
            new int[]{1,2}, new int[]{1,3}, new int[]{1,4},
            new int[]{2,3}, new int[]{2,4}, new int[]{3,4},
            new int[]{0,1,2}, new int[]{0,1,3}, new int[]{0,1,4},
            new int[]{0,2,3}, new int[]{0,2,4}, new int[]{0,3,4},
            new int[]{1,2,3}, new int[]{1,2,4}, new int[]{1,3,4},
            new int[]{2,3,4},
            new int[]{0,1,2,3}, new int[]{0,1,2,4}, new int[]{0,1,3,4},
            new int[]{0,2,3,4}, new int[]{1,2,3,4},
            new int[]{0,1,2,3,4}
        };


            bool flagAtLeastOne = false;
            for (int i = 0; i < jaggedIndices.Length; i++)
            {
                int tempsum = 0;
                string tempstring = "";
                for (int j = 0; j < jaggedIndices[i].Length; j++)
                {

                    tempsum += inputNumbers[jaggedIndices[i][j]];
                    tempstring += inputNumbers[jaggedIndices[i][j]].ToString() + (j == jaggedIndices[i].Length - 1 ? " = 0" : " + ");

                    //                Console.WriteLine(tempsum);

                }
                if (tempsum == 0)
                {
                    Console.WriteLine(tempstring);
                    flagAtLeastOne = true;
                }
            }

            if (!flagAtLeastOne)
            {
                Console.WriteLine("no zero subset");
            }

            //end of program - can be tested with F5 as well (if your antivirus is stopping you)
            Console.WriteLine(Environment.NewLine + "Please press any key to continue.");
            Console.ReadKey();
        }


    }
}

