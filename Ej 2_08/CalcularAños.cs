using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_2_08
{

    class CalcularAños
    {
        public static DateTime actualidad = DateTime.Now;

        public static void CalcularDias(DateTime fecha)
        {
            double dias;
            TimeSpan days = actualidad - fecha;
            dias = days.TotalDays;
            Console.WriteLine("Dias vividos {0:N2}", dias);
        }
    }
}
