using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eventos
{
    class Program
    {
        static void Main(string[] args)
        {

            Persona personita = new Persona();

            //Form1 form = new Form1();

            //form.ShowDialog();

            //Asocio el evento, a través de un delegado, a su manejador.
            
            personita.EdadInvalida += Informe.OtroNumeroNegativo;
            personita.EdadInvalida += new Action(Informe.NumeroNegativo);
            personita.EdadMenor += Informe.MenorDeEdad;
            
          
            //Desasociar el manejador al evento.
            personita.EdadInvalida -= new Action(Informe.NumeroNegativo);


            //personita.EdadInvalida2 += Informe.NumeroIncorrecto;
            
            personita.Edad = -2;

            Console.ReadKey();
        }
    }
}
