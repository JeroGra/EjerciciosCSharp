using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_I01_Excepciones
{
    public class MiClase
    {
        public MiClase(DivideByZeroException exc1)
        {
            UnaExceptino e = new UnaExceptino(exc1.InnerException);
        }
        public MiClase()
        {
            try
            {

            }
            catch(DivideByZeroException)
            {
                new MiClase(new DivideByZeroException());
            }
        }
        public static void Metodo1()
        {
            throw new DivideByZeroException();
        }
    }
}
