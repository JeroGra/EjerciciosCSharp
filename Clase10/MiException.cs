using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase10
{
    public class MiException : Exception 
    {
        private string mensaje;
       // private static StringBuilder sb;

       /* static MiException()
        {
            MiException.sb = new StringBuilder();
        }*/
  
        public MiException(string mensaje)
        {
            //MiException.sb.AppendLine(mensaje);
            this.mensaje = mensaje;
        }

        public MiException(string mensaje,MiException e):this(mensaje)
        {
            this.mensaje += e.mensaje;
        }

 
        /*
        public static void PrimerMetodo()
        {
            try
            {
                SegundoMetodo();
            }
            catch(MiException e)
            {
                sb.AppendLine("Metodo 1");
            }
        }

        public static void SegundoMetodo()
        {
            try
            {
                TercerMetodo();
            }
            catch(MiException e)
            {

                throw new MiException("Metodo 2");
            }
        }

        public static void TercerMetodo()
        {
                throw new MiException("Metodo 3");
        }
        */
        public string Mensaje()
        {
            //return MiException.sb.ToString();
            return this.mensaje;
        }

    }
}
