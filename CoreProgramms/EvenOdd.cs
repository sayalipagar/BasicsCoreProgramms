using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgramms
{
    public class EvenOdd
    {
        public void Findno()
        {
            int num1, rem1;
            Console.Write("Check whether a number is even or odd :\n");
            Console.Write("---------------------------------------");
            Console.Write("\n\n");
            Console.Write("Enter No : ");
            num1 = Convert.ToInt32(Console.ReadLine());
            rem1 = num1 % 2;
            if (rem1 == 0)
                Console.WriteLine("{0} is an Even No.\n", num1);
            else
                Console.WriteLine("{0} is an Odd No.\n", num1);
        }
    }

}

