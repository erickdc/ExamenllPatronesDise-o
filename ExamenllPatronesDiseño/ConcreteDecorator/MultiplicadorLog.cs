using System.IO;
using ExamenllPatronesDiseño.Component;
using ExamenllPatronesDiseño.Decorator;

namespace ExamenllPatronesDiseño.ConcreteDecorator
{
    class MultiplicadorLog : OperacionLog
    {
        public MultiplicadorLog(Log logItem, int resultado) : base(logItem, resultado)
        {
            WriteToLog("Multiplicacion " + Resultado);
        }


    }
}
