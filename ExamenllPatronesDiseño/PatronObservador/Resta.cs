﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño
{
    class Resta:IObservador
    {
        public decimal ActualizarResultado(decimal primerOperando, decimal segundoOperando, string tipoClase)
        {
            decimal resultadoResta = 0;

            if (tipoClase == "Resta")
            {
                resultadoResta = primerOperando - segundoOperando;
            }
            return resultadoResta;
        }
    }
}
