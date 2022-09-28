using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_2_3
{
    class Conversor
    {
        public static int ConvertirDecimalABinario(int numeroEntero)
        {
            int binario = 0;

            const int divisor = 2;
            int  digito = 0;

            for(int i = numeroEntero % divisor, j = 0;numeroEntero > 0; numeroEntero/= divisor, i = numeroEntero % divisor, j++)
            {
                digito = i % divisor;
                binario += digito * (int)Math.Pow(10, j);
            }          
            return binario;
        }

        public static int ConverirBinarioADecimal(int numeroEntero)
        {
            int num = 0;
            int digito = 0;
            const int divisor = 10;

            for(int i = numeroEntero, j = 0; i > 0;i /= divisor, j++)
            {
                digito = (int)i % divisor;

                if (digito != 1 && digito != 0)
                {
                    return -1;
                }
                num += digito * (int)Math.Pow(2, j);
            }
            return num;
        }
    }
}
