using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_A01
{
    class CalcularFactorial
    {
        public static int Factorial(int num)
        {
            int factorial = 1;

            for(int i = 1;i<num;i++)
            {
              if(i == 1)
                {
                    factorial = i * num;
                }
                else
                {
                    factorial = factorial * i;
                }

            }
            return factorial;
        }
    }
}
