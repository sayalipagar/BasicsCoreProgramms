using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgramms
{
    public class SwapNo
    {
        public void NumberSwaping()
        {
            int a = 10;
            int b = 20;
            a = a * b;
            b = a / b;
            a = a / b;
           
            Console.Write("After swapping a= " + a + " b= " + b);

        }
    }
}

