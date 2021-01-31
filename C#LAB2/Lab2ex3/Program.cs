using System;

namespace Lab2ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers and check two given numbers where one is less than 100 and other is greater than 200");
            Console.WriteLine("Enter number 1: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a < 100 && b < 200)
            {
                Console.WriteLine("Both number are less than 100 and 200");
            }
            else if (a >100 && b < 200)
            {
                Console.WriteLine("First number greater 100 and second less 200");
            }
            else if (a > 100 && b > 200)
            {
                Console.WriteLine("Both number greater 100 and 200");
            }
            else if (a < 100 && b > 200)
            {
                Console.WriteLine("First number leass 100 and second  grater 200");
            }
        }
    }
    }

