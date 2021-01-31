using System;

namespace Lab1ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write  first number : ");
            int s = int.Parse(Console.ReadLine());
            Console.Write("Write second number: ");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine($"{s} + {t} = {s + t}");

            Console.WriteLine($"{s} - {t} = {s - t}");

            Console.WriteLine($"{s} x {t} = {s * t}");

            Console.WriteLine($"{s} / {t} = {s / t}");

            Console.WriteLine($"{s} mod {t} = {s % t}");

        }
    }
}