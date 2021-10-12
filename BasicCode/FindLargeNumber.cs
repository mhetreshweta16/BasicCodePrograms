using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class FindLargeNumber
    {
        public void findLargeNumber()
        {

            Console.WriteLine("Find Largest of Three Numbers");
            Console.WriteLine("enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 3rd number");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine("the largest number is {0}", num1);
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine("the largest number is {0}", num2);
            }
            else
            {
                Console.WriteLine("the largest number is {0}", num3);
            }

            Console.ReadLine();

        }
    }
}
