using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class powerOf2
    {
        public static void PowerOf2()
        {
            int number;
            int power = 1;
            Console.WriteLine("Enter a power of value: ");
            number = int.Parse(Console.ReadLine());
            if (number < 31)
            {
                for (int i = 1; i <= number; i++)
                    power = power * 2;
                {
                    Console.WriteLine(power);
                }
            }
            else
            {
                Console.WriteLine("Number must be less than 31");
            }
        }
    }
}

