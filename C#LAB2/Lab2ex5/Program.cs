using System;

namespace Lab2ex5
{
    class Program
    {
        public static void Main()
        {
            float distance;
            float hour;

            float timeSec;
            
            float kph, mph;

            Console.Write("Write distance(meters): ");
            distance = Convert.ToSingle(Console.ReadLine());
            Console.Write("Write timeSec(hour): ");
            hour = Convert.ToSingle(Console.ReadLine());
            

            
            
            kph = (distance / 1000.0f) / (timeSec / 3600.0f);
            mph = kph / 1.609f;

            
            Console.WriteLine("Your speed in km/h is {0}", kph);
            Console.WriteLine("Your speed in miles/h is {0}", mph);
        }
    }
}