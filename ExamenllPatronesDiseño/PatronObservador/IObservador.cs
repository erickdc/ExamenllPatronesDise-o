using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño
{
    public interface IObservador
    {
        decimal ActualizarResultado(decimal primerOperando, decimal segundoOperando, string tipoClase);
    }
}
