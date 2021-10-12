using System;

namespace BasicCode
{
    class Program
    {
        
        public  static void Main(string[] args)
        {
            string yes="y";
            string y;
           
            do
            {
                Console.WriteLine("======Basic Code Programs======");
                Console.WriteLine("1.FlipCoin\n2.LeapYear\n3.Powerof2\n4.HarmonicNumber\n5.PrimeFactors\n6.Quotient and Remainder\n7.SwapTwoNumbers\n8.EvenOdd\n9.VowelConsonant\n10.LargestNumber");
                Console.WriteLine("Enter Your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());


                switch (choice)
                {
                    case 1:
                        Coin c = new Coin();
                        c.flipCoin();
                        break;

                    case 2:
                        LeapYear l = new LeapYear();
                        l.leapYear();
                        break;

                    case 3:
                        PowerOf2Table p = new PowerOf2Table();
                        p.powerOfTwoTable();
                        break;

                    case 4:
                        HarmonicSeries h = new HarmonicSeries();
                        h.harmonicSeries();
                        break;

                    case 5:
                        PrimeFactors p1 = new PrimeFactors();
                        p1.primeFactors();
                        break;

                    case 6:
                        QuotientRemainder q = new QuotientRemainder();
                        q.findQuotientRemainder();
                        break;
                    case 7:
                        SwapNumbers s = new SwapNumbers();
                        s.swapNUmbers();
                        break;

                    case 8:
                        EvenOdd e = new EvenOdd();
                        e.evenOdd();
                        break;

                    case 9:
                        VowelConsonant v = new VowelConsonant();
                        v.checkVowelConsonant();
                        break;
                    case 10:
                        FindLargeNumber f = new FindLargeNumber();
                        f.findLargeNumber();
                        break;

                    default:
                        Console.WriteLine("enter valid choice");
                        break;
                   }
                Console.WriteLine("Do You Want Continue.... press y/n ");
                 y = Console.ReadLine();
            } while (yes==y);
            //Console.ReadLine();
        }

        

    }
}
