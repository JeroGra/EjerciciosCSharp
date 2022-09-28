using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_2_1
{
    class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool esCorrecto = true;
            if(valor < min || valor > max)
            {
                esCorrecto = false;
            }
            return esCorrecto;
        }
    }
}
