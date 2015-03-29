using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Patron_Observador
{
    class ObservadorResta:IObservador
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
