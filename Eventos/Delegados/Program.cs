using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegados
{
    //Creo el delegado
    public delegate void MiDelegado(string c);
    class Program
    {
        static void Main(string[] args)
        {
            MiClase clase = new MiClase();

            //Asociar el delegado a la dirección de memoria del método.
            MiDelegado miDelegado = new MiDelegado(MiClase.CortarCadena);
            MiDelegado otroDelegado = MiClase.ReemplazarCadena;

            //(Estático)Combine: Combina ambos delegados.
            miDelegado=(MiDelegado)Delegate.Combine(miDelegado,otroDelegado);

            //Tambien asigno asi usando +
            miDelegado += clase.ContarCaracteres;
            miDelegado += clase.ConvertirMayuscula;

            Console.WriteLine("Method: Obtengo el último método de su lista.");
            Console.WriteLine(miDelegado.Method);
            Console.WriteLine("----------------");
            Console.WriteLine("Target: Donde se encuentra la instancia de ese método (No válido para estáticos)");
            Console.WriteLine(miDelegado.Target);

            Console.WriteLine("----------------");
            Console.WriteLine("getInvocationList: Devuelve lista de invocaciones.");
            Console.WriteLine("Lista de métodos:");
            foreach (MiDelegado item in miDelegado.GetInvocationList())
            {
                Console.WriteLine(item.Method);
            }
           
            Console.WriteLine("----------------");
            Console.WriteLine("Invoke: Invoca a los métodos que están asociados al delegado.");
            //(forma implícita):
            miDelegado("Facu");
            //(forma explícita):
            

            //Accedo a otro delegado como atributo.
            if(clase.esIgual.Invoke(2, 2))
            {
                Console.WriteLine("Son iguales");
            }

            Console.ReadKey();

        }

    }

}
