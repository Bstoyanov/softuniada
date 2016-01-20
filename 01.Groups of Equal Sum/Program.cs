using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        bool areEqual = false;
        List<int> numbers = new List<int>();
        for (int i = 0; i < 4; i++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }
        if ((numbers[0] + numbers[1]) == numbers[2] + numbers[3])
        {
            Console.WriteLine("Yes");
            Console.WriteLine(numbers[0] + numbers[1]);
            areEqual = true;
            return;

        }
        if ((numbers[0] + numbers[2]) == numbers[1] + numbers[3])
        {
            if (!areEqual)
            {
                Console.WriteLine("Yes");
            }
            Console.WriteLine(numbers[0] + numbers[2]);
            areEqual = true;
            return;

        }
        if ((numbers[0] + numbers[3]) == numbers[1] + numbers[2])
        {

            if (!areEqual)
            {
                Console.WriteLine("Yes");
            }
            Console.WriteLine(numbers[0] + numbers[3]);
            areEqual = true;
            return;
        }

        if (numbers[0] + numbers[1] + numbers[2] == numbers[3])
        {
            {

                if (!areEqual)
                {
                    Console.WriteLine("Yes");
                }
                Console.WriteLine(numbers[3]);
                areEqual = true;
                return;
            }
        }

        if (numbers[1] + numbers[2] + numbers[3] == numbers[0])
        {
            {

                if (!areEqual)
                {
                    Console.WriteLine("Yes");
                }
                Console.WriteLine(numbers[0]);
                areEqual = true;
                return;
            }
        }
        if ((numbers[0] + numbers[2] + numbers[3]) == numbers[1])
        {
            {

                if (!areEqual)
                {
                    Console.WriteLine("Yes");
                }
                Console.WriteLine(numbers[1]);
                areEqual = true;
                return;
            }
        }
        if (numbers[0] + numbers[1] + numbers[3] == numbers[2])
        {
            {

                if (!areEqual)
                {
                    Console.WriteLine("Yes");
                }
                Console.WriteLine(numbers[2]);
                areEqual = true;
                return;
            }
        }

        Console.WriteLine("No");



    }
}
