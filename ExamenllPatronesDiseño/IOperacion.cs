using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño
{
    public enum TipoOperacion
    {
        Suma,
        Resta,
        Multiplicacion
    }
    interface IOperacion
    {
        int Operar(int operando1, int operando2);
    }
}
