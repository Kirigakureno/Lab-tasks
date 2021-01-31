using System;

namespace Lab2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Writedown 1st integer:");
            int x = Convert.ToInt32(Console.ReadLine());
            if (x > 0)
            {
                Console.WriteLine(x % 3 == 0 || x % 7 == 0);
            }
        }
    }
}
