using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class SwapNumbers
    {
        public void swapNUmbers()
        {

            Console.WriteLine(" SWAP NUMBERS PROGRAM ");
            Console.WriteLine("enter the 1st number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the 2nd number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int temp;

            Console.WriteLine(" Before swap number is:{0} {1} ", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine(" After swap number is:{0} {1} ", num1, num2);
            Console.ReadLine();

        }


    }
}
