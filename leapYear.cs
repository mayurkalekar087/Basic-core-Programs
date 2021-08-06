using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class leapYear
    {
        public static void leapYear2()
        {
            int year;
            Console.WriteLine("Enter a Year: ");
            year = int.Parse(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("Entered year is Leap year " + year);
            }
            else
            {
                Console.WriteLine("Entered year is Common year " + year);
            }
        }
    }
}
