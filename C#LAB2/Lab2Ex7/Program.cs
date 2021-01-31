using System;

namespace Lab2Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers as input and returns true or false when both numbers are even or odd");
            Console.WriteLine("Write 1st number: ");
            var a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Write 2nd  number: ");
            var b = Convert.ToDouble(Console.ReadLine());

            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }


        }
    }
}

