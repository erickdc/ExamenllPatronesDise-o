using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public class RestadorIterador:IIterador
    {
        private List<Comando> _restas;
        private int _posicion;
        public RestadorIterador(List<Comando> restas)
        {
            _restas = restas;
            _posicion = 0;
        }

        public void IrAlInicio()
        {
            _posicion = 0;
        }

        public Comando Siguiente()
        {
            return _restas.ElementAt(_posicion++);
        }

        public bool ATerminado()
        {
            return _posicion >= _restas.Count;
        }

        public Comando ItemActual()
        {
            return _restas.ElementAt(_posicion);
        }
    }
}
