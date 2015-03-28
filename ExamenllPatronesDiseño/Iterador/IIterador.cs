using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public interface IIterador
    {
        void Primero();
        string Siguiente();
        bool ATerminado();
        string ItemActual();
    }
}
