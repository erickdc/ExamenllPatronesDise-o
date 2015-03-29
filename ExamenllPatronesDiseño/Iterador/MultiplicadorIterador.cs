using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public class MultiplicadorIterador:IIterador
    {
        private List<Comando> _multiplicaciones;
        private int _posicion;

        public MultiplicadorIterador(List<Comando> multiplicaciones)
        {
            _multiplicaciones = multiplicaciones;
            _posicion = 0;
        }

        public void IrAlInicio()
        {
            _posicion = 0;
        }

        public Comando Siguiente()
        {
            return _multiplicaciones.ElementAt(_posicion++);
        }

        public bool ATerminado()
        {
            return _posicion >= _multiplicaciones.Count;
        }

        public Comando ItemActual()
        {
            return _multiplicaciones.ElementAt(_posicion);
        }
    }
}
