using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño
{
    public class Suma : IObservador
    {
        public decimal ActualizarResultado(decimal primerOperando, decimal segundoOperando, string tipoClase)
        {
            decimal resultadoSuma = 0;

            if (tipoClase == "Suma")
            {
                resultadoSuma = primerOperando + segundoOperando;
            }
            return resultadoSuma;
        }
    }
}
