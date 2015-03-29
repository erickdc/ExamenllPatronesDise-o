namespace ExamenllPatronesDiseño.Patron_Observador
{
    public interface ISujeto
    {
        void RegistrarObservador(IObservador observador);
        void EliminarObservador(IObservador observador);
        void EjecutarAccion(decimal primerOperando, decimal segundoOperando, string tipoClase);
        void Notificar();
    }
}
