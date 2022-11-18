using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placa_de_Cronica
{
    public static class MiExtencion
    {
        public static string ObtenerPlacaCronicaTV(this DateTime fecha, Estaciones estacionElegida)
        {
            DateTime verano = new DateTime(2022,12,21);
            DateTime otoño = new DateTime(2023,03,21);
            DateTime invierno = new DateTime(2023,06, 21);
            DateTime primavera = new DateTime(2023,09, 21);

            switch(estacionElegida)
            {
                case Estaciones.Verano:
                break;
                case Estaciones.Otoño:
                    break;
                case Estaciones.Inviero:
                    break;
                case Estaciones.Primavera:
                    break;
            }
        }
    }
}
