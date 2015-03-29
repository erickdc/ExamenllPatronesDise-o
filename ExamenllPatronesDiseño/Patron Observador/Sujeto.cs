using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenllPatronesDiseño.Patron_Observador
{
    class Sujeto:ISujeto
    {
        public List<IObservador> Observadores { get; set; }
        public decimal Promedio { get; set; }
        public decimal PrimerOperando { get; set; }
        public decimal SegundoOperando { get; set; }
        public string TipoClase { get; set; }

        public Sujeto()
        {
            Observadores = new List<IObservador>();
        }
        public void RegistrarObservador(IObservador observador)
        {
            Observadores.Add(observador);
        }

        public void EliminarObservador(IObservador observador)
        {
            Observadores.Remove(observador);
        }

        public void EjecutarAccion(decimal primerOperando, decimal segundoOperando, string tipoClase)
        {
            PrimerOperando = primerOperando;
            SegundoOperando = segundoOperando;
            TipoClase = TipoClase;
            Notificar();
        }

        public void Notificar()
        {
            decimal resultaoNotificacionesObservadores = 0;
            foreach (var observadore in Observadores)
            {
                resultaoNotificacionesObservadores += observadore.ActualizarResultado(PrimerOperando, SegundoOperando, TipoClase);
            }
            Promedio = resultaoNotificacionesObservadores / 3;
        }
    }
}
