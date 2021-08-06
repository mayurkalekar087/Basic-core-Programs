using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class largestNumber
    {
        public static void largestNumber10()
        {
            int number1;
            Console.WriteLine("Enter 1st number");
            number1 = int.Parse(Console.ReadLine());
            int number2;
            Console.WriteLine("Enter 2nd number");
            number2 = int.Parse(Console.ReadLine());
            int number3;
            Console.WriteLine("Enter 3rd number");
            number3 = int.Parse(Console.ReadLine());
            if (number1 > number2 && number1 > number3)
            {
                Console.WriteLine("num 1 is greater than num 2 & num 3");
            }
            else if (number2 > number1 && number2 > number3)
            {
                Console.WriteLine("num 2 is greater than num 1 & num 3");
            }
            else
            {
                Console.WriteLine("num 3 is greater than num 2 & num 1");
            }
        }
    }
}
