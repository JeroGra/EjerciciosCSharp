using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    public delegate bool OtroDelegado(int num1, int num2);
    public class MiClase
    {
        public OtroDelegado esIgual = (parametro,parametro2) => parametro == parametro2;

        public void ContarCaracteres(string cadena)=> Console.WriteLine("Contador de caracteres: " + cadena.Length);
       
        public void ConvertirMayuscula(string cadena)=> Console.WriteLine("Cadena en mayúscula: " + cadena.ToUpper());

        public static void ReemplazarCadena(string cadena) => Console.WriteLine("Cadena cambiada: " + cadena.Replace('c', 'k'));
        

        public static void CortarCadena(string cadena) => Console.WriteLine("Cadena cortada: " + cadena.Substring(0, 4));


        
    }
}
