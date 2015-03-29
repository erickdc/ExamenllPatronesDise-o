namespace ExamenllPatronesDiseño
{
    public class Comando
    {
        public TipoOperacion Tipo;
        public int Operando1;
        public int Operando2;

        public Comando(TipoOperacion tipoOpera, int operando1, int operando2)
        {
            Tipo = tipoOpera;
            Operando1 = operando1;
            Operando2 = operando2;
        }

        public string DevolverComoString()
        {
            return Tipo.ToString() + " " + Operando1.ToString() + " " + Operando2.ToString();
        }
    }
}