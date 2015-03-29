using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public interface IIterador
    {
        void IrAlInicio();
        Comando Siguiente();
        bool ATerminado();
        Comando ItemActual();
    }
}
