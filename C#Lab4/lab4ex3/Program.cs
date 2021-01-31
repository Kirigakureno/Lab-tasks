using System;
public class lab4ex3


{
    public static void Main(string[] args)
    {
        int z, i, r = 0, flag = 0;
        Console.Write("Write number: ");
        z = int.Parse(Console.ReadLine());
        r = z / 2;
        for (i = 2; i <= r; i++)
        {
            if (z % i == 0)
            {
                Console.Write("This number not prime.");
                flag = 1;
                break;
            }
        }
        if (flag == 0)
            Console.Write("This number is Prime.");
    }
}