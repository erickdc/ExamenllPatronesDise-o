using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public class MultiplicadorIterador:IIterador
    {
        private List<string> _multiplicaciones;
        private int _posicion;

        public MultiplicadorIterador(List<string> multiplicaciones)
        {
            _multiplicaciones = multiplicaciones;
            _posicion = 0;
        }

        public void Primero()
        {
            _posicion = 0;
        }

        public string Siguiente()
        {
            return _multiplicaciones.ElementAt(_posicion++);
        }

        public bool ATerminado()
        {
            return _posicion >= _multiplicaciones.Count;
        }

        public string ItemActual()
        {
            return _multiplicaciones.ElementAt(_posicion);
        }
    }
}
