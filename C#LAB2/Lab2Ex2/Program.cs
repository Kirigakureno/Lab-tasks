using System;

namespace Lab2Ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write two numbers and check if an integer is in the range -10 to 10");
            Console.WriteLine("Enter number one: ");
            var a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two: ");
            var b = Convert.ToInt32(Console.ReadLine());

            if (a > -10 && a < 10 && b > -10 && b < 10)
            {
                Console.WriteLine("Two integers are between 10 and -10");
            }
            else if (a > -10 && a < 10)
            {
                Console.WriteLine("1st integer is between 10 and -10");
            }
            else if (b > -10 && b < 10)
            {
                Console.WriteLine("2nd integer is between 10 and -10");
            }
            else
            {
                Console.WriteLine("Both integer not between 10 and -10");
            }
        }
    }
    }

