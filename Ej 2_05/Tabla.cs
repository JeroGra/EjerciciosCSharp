using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_05
{
    class Tabla
    {
       public static StringBuilder respuesta = new StringBuilder();
        public static void TablaNum(int entero)
        {
            int result;
             respuesta.AppendLine("La tabla del "+entero+" es: ");
            for(int i = 1; i<10;i++)
            {
                result = i * entero;
                respuesta.AppendLine(entero+" x "+i+" = "+result);
            }
        }
    }
}
