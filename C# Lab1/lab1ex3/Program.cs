using System;

namespace lab1ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Enter 1 number");

            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 2 number");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3 number");

            c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("({0} + {1})*{2} = {3}", a, b, c, (a + b) * c);


            Console.WriteLine("{0} * {1} = {2}", a, b, a*b);
        }
    }
}
