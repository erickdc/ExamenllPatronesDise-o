using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenllPatronesDiseño.Component;
using ExamenllPatronesDiseño.Iterador;

namespace ExamenllPatronesDiseño
{
    class Restador : Log, IOperacion, ICalculadora
    {
        public List<string> Restas { get; set; }

        public int Operar(int operando1, int operando2)
        {
           return operando1-operando2;
        }

        public IIterador CrearIterador()
        {
            return new RestadorIterador(Restas);
        }

        public override void WriteLog()
        {
            throw new NotImplementedException();
        }
    }
}
