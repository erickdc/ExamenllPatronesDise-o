using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Patron_Observador
{
    class ObservadorSuma:IObservador
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
