using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenllPatronesDiseño.Iterador;

namespace ExamenllPatronesDiseño
{
    class Multiplicador : IOperacion, ICalculadora
    {
        public List<string> Multiplicaciones { get; set; }

        public int Operar(int operando1, int operando2)
        {
            return operando1*operando2;
        }

        public IIterador CrearIterador()
        {
            return new MultiplicadorIterador(Multiplicaciones);
        }
    }
}
