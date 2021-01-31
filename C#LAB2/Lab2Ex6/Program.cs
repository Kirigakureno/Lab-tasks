using System;

namespace Lab2Ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writedown the radius and calculate surface and volume");
            Console.WriteLine("Writedown radius: ");
            var x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine($"Surface is {4 * Math.PI * x * x} , Volume is { (4 / 3) * Math.PI * (x * x * x)}");
        }
    }
}
