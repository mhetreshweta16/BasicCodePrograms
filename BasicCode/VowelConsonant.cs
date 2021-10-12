using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class VowelConsonant
    {

        public void checkVowelConsonant()
        {


            Console.WriteLine("enter the Alphabet to check Vowel or Consonant ");
            string num1 = Console.ReadLine();
            if (num1 == "A" || num1 == "E" || num1 == "I" || num1 == "O" || num1 == "U" || num1 == "a" || num1 == "e" || num1 == "i" || num1 == "o" || num1 == "u")
            {
                Console.WriteLine("{0} Alphabet is Vowel ", num1);
            }
            else
            {
                Console.WriteLine("{0} Alphabet is Consonant ", num1);
            }

            Console.ReadLine();

        }
    }
}
