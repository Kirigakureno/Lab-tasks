using System;

namespace Lab3ex3
{
    class Program
    {
        static void Main(string[] args)
         
        {
            Console.WriteLine("Write binary number");
            var z = Console.ReadLine();

            var hex = Convert.ToInt32(z, 2).ToString("X");

            Console.WriteLine($"Hex is {hex}");
        }
    }
}
