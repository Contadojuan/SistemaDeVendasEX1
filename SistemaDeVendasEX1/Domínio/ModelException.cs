﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendasEX1.Domínio
{
    class ModelException : Exception
    {
        public ModelException (string msg) : base(msg)
        {

        }
    }
}
