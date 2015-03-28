using System;
using System.IO;
using ExamenllPatronesDiseño.Component;
using ExamenllPatronesDiseño.Decorator;

namespace ExamenllPatronesDiseño.ConcreteDecorator
{
    class SumadorLog : OperacionLog
    {
        public SumadorLog(Log logItem, int resultado) : base(logItem,resultado)
        {
            WriteToLog( "Suma " + Resultado);

        }

    }
}
