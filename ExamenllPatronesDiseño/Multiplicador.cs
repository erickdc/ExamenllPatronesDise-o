using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño
{
    class Multiplicador: IOperacion
    {
        public int Operar(int operando1, int operando2)
        {
            return operando1*operando2;
        }
    }
}
