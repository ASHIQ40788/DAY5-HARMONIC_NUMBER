using System;
namespace HARMONIC_NUMBER
{
    class NTH_HARMONIC_NUMBER
    {

        // Function to return sum of harmonic series
        static float sum(int n)
        {
            double i, s = 0.0;
            
            //s=sum
            for (i = 1; i <= n; i++)
                s = s + 1 / i;

            return (float)s;
        }


        // Driven Program
        public static void Main()
        {
            int n = 100;
            Console.WriteLine("Sum is " + sum(n));
            Console.Read();
        }
    }
}