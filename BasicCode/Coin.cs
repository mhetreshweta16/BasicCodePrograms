using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class Coin
    {
        public const int HEAD = 1;
        public const int TAILS = 0;

        public void flipCoin()
        {
            int h = 0, t = 0;
            int per = 0, per1 = 0;
            Console.WriteLine("Hello World!");

            Console.WriteLine("enter the no of time to flip the coin ");
            int n = Convert.ToInt32(Console.ReadLine());
            int s = n;
            Random r = new Random();

            for (int i = 0; i <= n; i++)
            {
                int ranValue = r.Next(0, 2);
                Console.WriteLine("random value:{0}", ranValue);
                if (TAILS == ranValue)
                {
                    t++;  // counting tails 
                    per = (t / s) * 100; //calulating percentage of tails

                }
                else if (HEAD == ranValue)
                {
                    h++;// caounting heads
                    per1 = (h / s) * 100; // calulating percentage of heads
                }
            }
            Console.WriteLine("the no of thime head is: {0} and percentage is :{1} ", h, Convert.ToDouble(per)); // displaying the heads and %
            Console.WriteLine("the no of thime tail is : {0} and percentage is :{1}", t, Convert.ToDouble(per1)); // // displaying the tails and %


            Console.ReadLine();
        }




    }
}
