using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatronDiseño
{
    public interface ISujeto
    {
        void RegistrarObservador(IObservador observador);
        void EliminarObservador(IObservador observador);
        void EjecutarAccion(decimal primerOperando, decimal segundoOperando, string tipoClase);
        void Notificar();
    }
}
