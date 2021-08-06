using System;

namespace BasicCorePrograms
{
    class factors
    {
        public static void primeFactor()
        {
            int a, b;
            Console.WriteLine("Enter a Number");
            a = int.Parse(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + "is a prime factor of" + a);
                }
            }
        }
    }
}
