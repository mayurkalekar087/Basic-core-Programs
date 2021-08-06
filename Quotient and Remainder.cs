
using System;

namespace BasicCorePrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            SwapNumber.SwapNumber1();
            OddEven.OddEven2();
            Vowel_9.Vowel();
            largestNumber.largestNumber10();
            leapYear.leapYear2();
            powerOf2.PowerOf2();
            harmonicnum.harmpnicnum1();
            factors.primeFactor();
            int dividend;
            Console.WriteLine("Enter dividend:");
            dividend = int.Parse(Console.ReadLine());
            int divisor;
            Console.WriteLine("Enter divisor:");
            divisor = int.Parse(Console.ReadLine());
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Quotient= " + quotient);
            Console.WriteLine("Remainder= " + remainder);

        }
    }
}