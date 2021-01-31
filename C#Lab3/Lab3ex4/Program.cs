using System;

namespace Lab3ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, sum = 0, n;
            Console.Write("Write number: ");
            number = int.Parse(Console.ReadLine());
            n = number;
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == n)
            {
                Console.WriteLine(" Number is perfect");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(" Number is not perfect");
                Console.ReadLine();
            }
        }
    }
}
