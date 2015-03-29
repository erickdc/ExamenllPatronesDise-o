using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenllPatronesDiseño.Iterador;

namespace ExamenllPatronesDiseño
{
    class Restador : IOperacion, ICalculadora
    {
        public List<Comando> Restas { get; set; }
        public IIterador Iterador;


        public int Operar(int operando1, int operando2)
        {
           return operando1-operando2;
        }

        public void LlenarLista(List<Comando> comandos)
        {
            Restas = comandos;
        }

        public List<Comando> DevolverComandos()
        {
            return Restas;
        }


        public void CrearIterador()
        {
            Iterador= new RestadorIterador(Restas);
        }
    }
}
