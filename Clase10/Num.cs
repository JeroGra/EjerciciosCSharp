using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class Num
    {
        public static bool TryParse(string cadena,out int numero)
        {
            bool equals = true;
            try
            {
                numero = int.Parse(cadena);
            }
            catch(Exception e)
            {
                numero = 0;
                equals = false;
            }
            return equals; 
        }
    }
}
