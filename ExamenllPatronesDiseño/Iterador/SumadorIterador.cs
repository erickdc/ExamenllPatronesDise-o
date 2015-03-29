using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Iterador
{
    public class SumadorIterador:IIterador
    {
        private List<Comando> _sumas;
        private int _posicion;

        public SumadorIterador(List<Comando> sumas)
        {
            _sumas = sumas;
            _posicion = 0;
        }

        public void IrAlInicio()
        {
            _posicion = 0;
        }

        public Comando Siguiente()
        {
            return _sumas.ElementAt(_posicion++);
        }

        public bool ATerminado()
        {
            return _posicion >= _sumas.Count;
        }

        public Comando ItemActual()
        {
            return _sumas.ElementAt(_posicion);
        }
    }
}
