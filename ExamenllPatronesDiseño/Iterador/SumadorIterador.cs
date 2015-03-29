using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public class SumadorIterador:IIterador
    {
        private List<string> _sumas;
        private int _posicion;

        public SumadorIterador(List<string> sumas)
        {
            _sumas = sumas;
            _posicion = 0;
        }

        public void Primero()
        {
            _posicion = 0;
        }

        public string Siguiente()
        {
            return _sumas.ElementAt(_posicion++);
        }

        public bool ATerminado()
        {
            return _posicion >= _sumas.Count;
        }

        public string ItemActual()
        {
            return _sumas.ElementAt(_posicion);
        }
    }
}
