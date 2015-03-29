using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public class RestadorIterador:IIterador
    {
        private List<string> _restas;
        private int _posicion;
        public RestadorIterador(List<string> restas)
        {
            _restas = restas;
            _posicion = 0;
        }

        public void Primero()
        {
            _posicion = 0;
        }

        public string Siguiente()
        {
            return _restas.ElementAt(_posicion++);
        }

        public bool ATerminado()
        {
            return _posicion >= _restas.Count;
        }

        public string ItemActual()
        {
            return _restas.ElementAt(_posicion);
        }
    }
}
