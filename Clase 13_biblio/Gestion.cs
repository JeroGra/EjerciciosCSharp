using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_13_biblio
{
    public static class Gestion
    {
        public static double MostrarImpuestonacional(IAFIP bienPunible)
        {
            return bienPunible.CalcularImpuesto();
        }
    }
}
