﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_I01_Excepciones
{
    public class UnaExceptino : Exception
    {
        public UnaExceptino(Exception e) :base()
        {

        }
    }
}