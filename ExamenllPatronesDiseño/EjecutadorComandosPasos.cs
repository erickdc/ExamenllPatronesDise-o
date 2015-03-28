using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ExamenllPatronesDiseño
{
    [Binding]
    public class EjecutadorComandosSteps
    {
        private CreadorOperaciones _creadorOperaciones;
        private IOperacion _operacion;
        private int _resultado,_operando1,_operando2;

        [Given(@"Coloque (.*) y (.*) para ""(.*)"" en la calculadora")]
        public void GivenColoqueYParaEnLaCalculadora(int p0, int p1, string p2)
        {
            _creadorOperaciones = new CreadorOperaciones();
            _operacion = _creadorOperaciones.ObtenerOperacion((TipoOperacion)Enum.Parse(typeof(TipoOperacion), p2, true));
            _operando1 = p0;
            _operando2 = p1;
        }

        [When(@"Cuando presione sumar")]
        public void WhenCuandoPresioneSumar()
        {
            _resultado = _operacion.Operar(_operando1, _operando2);
        }

        [When(@"Cuando presione restar")]
        public void WhenCuandoPresioneRestar()
        {
            _resultado = _operacion.Operar(_operando1, _operando2);
        }

        [When(@"presione multiplicar")]
        public void WhenPresioneMultiplicar()
        {
            _resultado = _operacion.Operar(_operando1, _operando2);
        }

        [Then(@"el resultado de la suma es (.*)")]
        public void ThenElResultadoDeLaSumaEs(int p0)
        {
            Assert.AreEqual(p0,_resultado);
        }

        [Then(@"El resultado de la resta es (.*)")]
        public void ThenElResultadoDeLaRestaEs(int p0)
        {
            Assert.AreEqual(p0, _resultado);
        }

        [Then(@"El resultado de la multiplicacion es (.*)")]
        public void ThenElResultadoDeLaMultiplicacionEs(int p0)
        {
            Assert.AreEqual(p0, _resultado);
        }
    }
}
