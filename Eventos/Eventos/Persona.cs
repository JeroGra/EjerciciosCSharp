using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eventos
{
    //Declaro un delegado Action.
    public delegate void Action(int e);

    //Declaro otro delegado.
    public delegate void OtroDelegado(Persona p,PersonaEventArgs e);

    public class Persona
    {
        #region Atributo
        protected int edad;
        #endregion

        #region Eventos
        //Declaro un evento.
        public event Action EdadInvalida;

        public event Action EdadMenor;

        //Declaro otro evento.
        public event OtroDelegado EdadInvalida2;
        #endregion

        #region Propiedades
        
        public int Edad 
        {
            get { return this.edad; }

            set 
            {
                if (value < 18)
                {
                    if (value < 0)
                    this.EdadInvalida.Invoke(value); //lanzo el evento EdadInvalida
                    else
                    this.EdadMenor(value);    //lanzo el evento EdadMenor

                }
                else
                {
                    this.edad = value;
                }

            }

        }
        /*
        public int Edad
        {
            get { return this.edad; }
            set
            {
                if (value < 0)
                {
                    PersonaEventArgs e = new PersonaEventArgs();

                    e.NumeroIngresado = value;

                    //lanzo el evento
                    this.EdadInvalida2.Invoke(this, e);
                }
                else
                {
                    this.edad = value;
                }

            }

        }*/
        
        
        



        #endregion

 








    }
}
