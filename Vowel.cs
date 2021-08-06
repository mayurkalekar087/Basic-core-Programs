using System;
using System.Collections.Generic;
using System.Text;

namespace BasicCorePrograms
{
    class Vowel_9
    {
        public static void Vowel()
        {
            char letter;
            Console.WriteLine("Enter Letter: ");
            letter = char.Parse(Console.ReadLine());
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                Console.WriteLine("Entered letter is Vowel " + letter);
            }
            else
            {
                Console.WriteLine("Entered letter is Consonant " + letter);
            }
        }
    }
}



