using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class QuotientRemainder
    {
        public void findQuotientRemainder()
        {
            Console.WriteLine(" Program to Compute Quotient and Remainder ");
            Console.WriteLine(" enter dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" enter divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);


            Console.ReadLine();

        }


    }
}
