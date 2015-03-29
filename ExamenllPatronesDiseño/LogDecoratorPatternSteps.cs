using System;
using System.Collections.Generic;
using System.Linq;
using ExamenllPatronesDiseño.Component;
using ExamenllPatronesDiseño.ConcreteComponent;
using ExamenllPatronesDiseño.ConcreteDecorator;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ExamenllPatronesDiseño
{
    [Binding]
    public class LogDecoratorPatternSteps
    {
        Log log= new OperadorLog();
        int[] _resultados;
        private List<string> _logList=new List<string>();


        [Given(@"que se hayan ejecutado las siguientes operaciones con los siguientes resultados")]
        public void GivenQueSeHayanEjecutadoLasSiguientesOperacionesConLosSiguientesResultados(Table table)
        {
            _resultados = UtilidadPrueba.ConvertirDeTablaResultadoArregloEntero(table);
           
            log = new SumadorLog(log,_resultados[0]);
            log = new RestadorLog(log,_resultados[1]);
            log = new MultiplicadorLog(log, _resultados[2]);
        }

        [Then(@"el log debera contener")]
        public void ThenElLogDeberaContener(Table table)
        {
            _logList = UtilidadPrueba.ListaDeOperaciones(table);
            Assert.AreEqual(UtilidadPrueba.DevolverListaLogs().First(), _logList.First());

        }

    }
}
