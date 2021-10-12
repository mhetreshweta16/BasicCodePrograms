using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class PrimeFactors
    {
        public void primeFactors()
        {

            Console.WriteLine("Enter the number to find the prime factors of number:");
            int num = Convert.ToInt32(Console.ReadLine());


            //
            //dividing a number by smallest prime number to get the number completely divided 
            while (num % 2 == 0)
            {
                Console.WriteLine(2 + " ");
                num = num / 2;
            }
            //
            //now divide the quotient by the smallest prime number until the only number left are prime number

            for (int i = 3; i <= num / 2; i = i + 2)
            {
                while (num % i == 0)
                {

                    num = num / i;
                    Console.WriteLine(i);


                }

            }

            // checking the prime no is greter than 2 or not
            if (num > 2)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();

        }

    }
}
