using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace AtencionAlCliente_Ej
{
    class PuestoAtencion
    {
        private Puesto puesto;
        private static int numeroActual;
        public enum Puesto
        {
            Caja1,
            Caja2,
        }

         static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }
        public int NumeroActual
        {
            get
            {
                return PuestoAtencion.numeroActual+1;
            }
        }

        public static bool Atender(Cliente cli)
        {
            Thread.Sleep(1000);
            return true;
        }
    }
}
