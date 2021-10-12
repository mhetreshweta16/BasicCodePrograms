using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCode
{
    class HarmonicSeries
    {

        public void harmonicSeries()
        {

            double i, sum = 0.0;
            Console.WriteLine("enter the number to calulate nth harmonic series:");
            double n = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n===HARMONIC SERIES===");
            Console.WriteLine("1/1+1/2+1/3+1/4+1/5+------1\n");
            //calculating harmonic series n
            for (i = 1; i <= n; i++)
            {
                sum = sum + 1 / i;
            }
            Console.WriteLine("the sum of Harmonic series number is:{0}", sum);
            Console.ReadLine();
        }
    }
}

    
