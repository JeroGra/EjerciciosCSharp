using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Hilos2022
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instancio una Task
            Task t = new Task(MiMetodo);

            //Task t2 = new Task(MiMetodo);

            //Task t3 = new Task(MiMetodo);



            t.Start();

          

            //Task.WaitAny(t, t2);
            //Task.WaitAll(t, t2);
            //t3.Start();


            #region Otros ejemplos
            
            //Instancio otro Task e inicializo.
             Task.Run(MiMetodo);

            

            
      //Expresión lambda
        Task t4 = Task.Run( ()=> {
          Thread.Sleep(2000);
          Console.WriteLine("Hilo anonimo - TASK:" + Task.CurrentId + " - Thread:" + Thread.CurrentThread.ManagedThreadId);

      } );
            
      //Con argumentos
      Task.Run(() => MetodoConArgumentos("cadena"));
            

            #endregion


            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(3000);

                Console.WriteLine("Hilo principal - Thread:" + Thread.CurrentThread.ManagedThreadId);
            }
          

            Console.ReadKey();
        }


        
        public static void MiMetodo()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Hilo secundario - TASK:" + Task.CurrentId + " - Thread:" + Thread.CurrentThread.ManagedThreadId);

            }
        }


        public static void MetodoConArgumentos(string cadena)
        {
            Thread.Sleep(5000);
            Console.WriteLine(cadena);
        }

    }

}
