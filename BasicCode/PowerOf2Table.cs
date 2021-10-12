using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class PowerOf2Table
    {
        public void powerOfTwoTable()
        {
            Console.WriteLine("enter the number to calculate power table of 2:");
            int n = Convert.ToInt32(Console.ReadLine());

            double powerNumber = Math.Pow(2, n);
            Console.WriteLine(powerNumber);
            int p = 1;
            for (int i = 0; i <= powerNumber; i++)
            {
                if (i == 0)
                {
                    p = 1;
                }
                else
                {
                    p = p * 2;
                }
                Console.WriteLine(i + " = " + p);
            }
            Console.ReadLine();

        }

    }
}
