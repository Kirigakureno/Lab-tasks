using System;



class lab9ex2
{

    static float sumOfAP(float a,
                         float d,
                         float z)
    {
        float sum = (z / 2) *
                    (2 * a +
                    (z - 1) * d);
        return sum;
    }

   
    static public void Main()
    {
        float z = 15;
        float a = 2.5f, d = 1.5f;
        Console.WriteLine(sumOfAP(a, d, z));
    }
}