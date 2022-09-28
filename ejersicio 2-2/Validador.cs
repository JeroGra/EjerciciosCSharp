using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_2_2
{
    class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool retorno = true;

            if(respuesta != "S")
            {
                retorno = false;
            }
            return retorno;
        }

    }
}
