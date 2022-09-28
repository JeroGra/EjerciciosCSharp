using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
    class MyClass
    {
        // public // (metodo) acceso publico "puede utilizarce hasta fuera de la clase y proyecto" si se omite el public en la sentencia hace que el metodo sea privado en c#
        // lo ideal es siempre poner el modificador de visibilidad para que el codigo sea funcional en otros lenguajes

        // static// como se utilizara ese elemento, los miembros estaticos marcan como poder acceder a dicho elemento "el main es estatico" (modificador de comportamiento)

        // retorno al igual que en c un tipo de dato

        //atributo = 
        public static string cadena;
       
       


        public static void Nada(void random)
        {
            //cuerpo donde va el codigo
            MyClass.cadena = "pepe";
            cadena = "pepe";
            //dentro del scope de la clase se puede hacer esto
        }

        
        

    }
}
