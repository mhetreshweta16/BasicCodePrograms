using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class LeapYear
    {

        public void leapYear()
        {


            Console.WriteLine("enter the Year to check leap year or not:");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("the year {0} is leap year", year);

            }
            else
            {
                Console.WriteLine("the year {0} is not leap year", year);
            }
            Console.ReadLine();
        }

    }
}
