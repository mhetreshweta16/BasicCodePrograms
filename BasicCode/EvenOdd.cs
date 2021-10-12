using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class EvenOdd
    {
        public void evenOdd()
        {

            Console.WriteLine("enter the number to check even or odd number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 < 0) // checking the number is less than 0 or not 
            {
                Console.WriteLine("enter valid number");

            }
            else if (num1 % 2 == 0)// checking the number is even or not
            {
                Console.WriteLine("the number {0} is EVEN ", num1);
            }
            else
            {
                Console.WriteLine("the number {0} is ODD ", num1);
            }
            Console.ReadLine();

        }

    }
}
