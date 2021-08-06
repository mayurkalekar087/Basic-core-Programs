using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class SwapNumber
    {
        public static void SwapNumber1()
        {
            int a;
            Console.WriteLine("Enter 1st number");
            a = int.Parse(Console.ReadLine());
            int b;
            Console.WriteLine("Enter 2nd number");
            b = int.Parse(Console.ReadLine());
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swaping " + a);
            Console.WriteLine("After swaping" + b);


        }
    }
}
