using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño
{
    class Multiplicacion:IObservador
    {
        public decimal ActualizarResultado(decimal primerOperando, decimal segundoOperando, string tipoClase)
        {
            decimal resultadoMultiplicacion = 0;

            if (tipoClase == "Multiplicacion")
            {
                resultadoMultiplicacion = primerOperando * segundoOperando;
            }
            return resultadoMultiplicacion;
        }
    }
}
