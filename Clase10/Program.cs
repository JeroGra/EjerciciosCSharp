using System;

namespace Clase10
{
    class Program
    {
        static void Main(string[] args)
        {
           /* MiException m1 = new MiException("Mi exception");
            MiException.PrimerMetodo();
            Console.WriteLine(m1.Mensaje());*/


            try
            {
                Metodo1();
            }
            catch(MiException e)
            {
                Console.WriteLine(e.Mensaje()); 
            }

             static void Metodo1()
            {
                try
                {
                    Metodo2();
                }
                catch (MiException e)
                {
                    throw new MiException("Metodo 1\n", e);
                }
            }

             static void Metodo2()
            {
                try
                {
                    Metodo3();
                }
                catch (MiException e)
                {
                    throw new MiException("Metodo 2\n",e);
                }
            }

             static void Metodo3()
             {

                 throw new MiException("Metodo 3\n");
             }
        }
    }
}
