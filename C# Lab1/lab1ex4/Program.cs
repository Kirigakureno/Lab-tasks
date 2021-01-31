using System;

namespace lab1ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Double K, F, C;
            Console.WriteLine("Enter degrees K");
            K = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Degrees F and C");
            F = K - 273.15;
            C = (K * 1.8)  + 32;
            Console.WriteLine("{0}K = {1}F", K, F);
            Console.WriteLine("{0}K = {1}C", K, C);
        }
    }
}
