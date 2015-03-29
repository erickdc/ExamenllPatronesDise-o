using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ExamenllPatronesDiseño.Patron_Observador
{
    [Binding]
    public class ImplementacionDePatronesDeDisenoObservadorSteps
    {
        private ObservadorSuma _suma;
        private ObservadorResta _resta;
        private ObservadorMultiplicacion _multiplicacion;
        private Sujeto _sujeto;

       

        [Given(@"Tengo que agregar a la lista los siguientes Observadores")]
        public void GivenTengoQueAgregarALaListaLosSiguientesObservadores(Table table)
        {
            table.CreateSet<IObservador>();
            table.AddRow("Suma");
            table.AddRow("Resta");
            table.AddRow("multiplicacion");
        }


        [When(@"cuando ejecute la accion agregar")]
        public void WhenCuandoEjecuteLaAccionAgregar()
        {
            _sujeto.RegistrarObservador(_suma);
            _sujeto.RegistrarObservador(_resta);
            _sujeto.RegistrarObservador(_multiplicacion);
        }

        [Then(@"la lista tendra (.*) nuevos elemento")]
        public void ThenLaListaTendraNuevosElemento(int cant)
        {
            cant = 3;
            Assert.AreEqual(cant, _sujeto.Observadores.Count);
        }






    }
}
