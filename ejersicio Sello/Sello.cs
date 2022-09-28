using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejersicio_Sello
{
    class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.Imprimir());
        }

        private static string ArmarFormatoMensaje()
        {
            string cuadro = "";
            string formato;
            int len = Sello.mensaje.Length;
            for(int i = 0; i<=(len+1);i++)
            {
                cuadro = cuadro + "*";
            }
            formato = cuadro+"\n"+"*"+Sello.mensaje+"*"+"\n"+cuadro+"\n";
            return  formato;
        }
    }
}
