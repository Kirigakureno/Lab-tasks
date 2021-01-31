class GFG
{

    static void printSum(int[] z,
                    int[] x, int y)
    {
        int total = 0;


        for (int i = 0; i < y; i++)
        {
            total += x[i];
            total += (z[i] * 60);
        }


        Console.Write(total / 3600 + " : ");
        total %= 3600;


        Console.Write(total / 60 + ": ");
        total %= 60;


        Console.Write(total);
    }


    public static void Main()
    {
        int[] z = { 0, 2, 3, 2, 1 };
        int[] x = { 45, 31, 11, 27, 28 };
        int y = z.Length;

        printSum(z, x, y);
    }
}
