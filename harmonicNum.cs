using System;
using System.Collections.Generic;
using System.Text;


namespace BasicCorePrograms
{
    class harmonicnum
    {
        static double nthHarmonic(int N)
        {
            float harmonic = 1;
            for (int i = 2; i <= N; i++)
            {
                harmonic += (float)1 / i;
            }
            return harmonic;
        }
        public static void harmpnicnum1()
        {
            int N = 9;
            Console.WriteLine(nthHarmonic(N));
        }

    }
}