using System;
using System.IO;
using ExamenllPatronesDiseño.Component;
using ExamenllPatronesDiseño.Decorator;

namespace ExamenllPatronesDiseño.ConcreteDecorator
{
    class RestadorLog : OperacionLog
    {
        public RestadorLog(Log logItem, int resultado) : base(logItem, resultado)
        {
            WriteToLog("Resta " + Resultado);

        }


    }
}
