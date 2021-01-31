using System;

namespace Lab3ex5
{
    class Program
    {
        static void Main(string[] args)
        {
            int y, k;
            Console.Write("Write a C# program to find all prime factors of a number");
            Console.WriteLine("Write your number: ");
            y = int.Parse(Console.ReadLine());
            for (k = 1; k <= y; k++)
            {
                if (y % k == 0)
                {
                    Console.WriteLine(k + " is a factorial of " + y);
                }
            }
        }
    }
}
