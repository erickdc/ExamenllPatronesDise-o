using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño
{
    class CreadorOperaciones
    {
        public IOperacion GetPeople(TipoOperacion tipo)
        {
            IOperacion operacion = null;
            switch (tipo)
            {
                case TipoOperacion.Suma:
                    operacion = new Sumador();
                    break;
                case TipoOperacion.Resta:
                    operacion = new Restador();
                    break;
                case TipoOperacion.Multiplicacion:
                    operacion = new Multiplicador();
                    break;
               
            }
            return operacion;
        }
    }
}
