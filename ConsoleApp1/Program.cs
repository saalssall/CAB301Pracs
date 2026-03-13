using System;
using static System.Math;  
using System.Collections.Generic; 
class Program
{
    static void Main(string[] args)
    {
        int [] numbers = {1, 2, 3, 4, 5};
        int result = MinimumDistance(numbers);
        Console.WriteLine("Minimum distance is {0}", result);

        Console.Write("\nHit any key to continue...");
        Console.ReadKey();
    }

    static int MinimumDistance(int[] values)
    {
        int dmin = 100000;
        for (int i = 0; i < values.Length - 1; i++)
        {
            for (int i = 0; i< values.Length; i++)
            {
                    if (i!=j && (Math.Abs(values[i]) - values[j]<dmin))
                    dmin = Math.Abs(values[i] - values[j]);
            }
        }
        return dmin;
    }
}

