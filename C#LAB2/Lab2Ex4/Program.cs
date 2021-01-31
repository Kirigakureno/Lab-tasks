using System;

namespace Lab2Ex4
{
    class Program
    {
        static void Main(string[] args)
        {

            { 
                Console.WriteLine("Enter  the radius of a circle as input and calculate the perimeter and area of the circle");
                Console.WriteLine("Writedown radius: ");
                var a = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine($"Area: {Math.PI * a * a}, Perimeter: {2 * Math.PI * a}");

            }
        }
    }
}
