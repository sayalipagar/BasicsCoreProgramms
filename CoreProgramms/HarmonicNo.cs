using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgramms
{
    public  class HarmonicN0
    {
        public  void HarmonicNumberSolution()
        {
            Console.WriteLine("plz enter nth harmonic num");
            int nthNumber = Convert.ToInt32(Console.ReadLine());
            Harmonic(nthNumber);
            //Console.WriteLine("sum of all harmonic list " + result);
        }
        public static void Harmonic(int lastNumber)
        {
            double sum = 0;
            for (int i = 1; i <= lastNumber; i++)
            {
                Console.Write("1/{0} + ", i);
                sum += 1 / (float)i;
            }
            Console.Write("\nsum of series upto {0} terms : {1} \n", lastNumber, sum);
        }
    }
}
