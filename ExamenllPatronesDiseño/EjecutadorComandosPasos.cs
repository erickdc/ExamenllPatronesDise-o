using System;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace ExamenllPatronesDiseño
{
    [Binding]
    public class EjecutadorComandosPasosSteps
    {

        private CreadorOperaciones _creadorOperaciones;
        private IOperacion _operacion;
        private int _resultado, _operando1, _operando2;
        private int[] _resultadoListaOperaciones, _resultadoListaOperacionesArchivo;
        private Table _tablaOperaciones;

        [Given(@"(.*) y (.*) para la ""(.*)"" en la calculadora")]
        public void GivenYParaLaEnLaCalculadora(int p0, int p1, string p2)
        {
            _creadorOperaciones = new CreadorOperaciones();
            _operacion =
                _creadorOperaciones.ObtenerOperacion((TipoOperacion)Enum.Parse(typeof(TipoOperacion), p2, true));
            _operando1 = p0;
            _operando2 = p1;

        }

        [Given(@"la lista de operaciones aritmeticas")]
        public void GivenLaListaDeOperacionesAritmeticas(Table table)
        {

            _creadorOperaciones = new CreadorOperaciones();
            _tablaOperaciones = table;
        }

        [Given(@"la lista de operaciones aritmeticas guardadas en el archivo")]
        public void GivenLaListaDeOperacionesAritmeticasGuardadasEnElArchivo(Table table)
        {
            _creadorOperaciones = new CreadorOperaciones();
            var listaComandos =UtilidadPrueba.ConvertirDeTablaListaComandos(table);
            var archivoTexto = new ArchivoTexto();
            archivoTexto.LimpiarArchivo();
            archivoTexto.EscribirListaComandos(listaComandos);

        }

        [When(@"presione sumar")]
        public void WhenPresioneSumar()
        {
            _resultado = _operacion.Operar(_operando1, _operando2);
        }

        [When(@"presione restar")]
        public void WhenPresioneRestar()
        {
            _resultado = _operacion.Operar(_operando1, _operando2);
        }

        [When(@"presione multiplicar")]
        public void WhenPresioneMultiplicar()
        {
            _resultado = _operacion.Operar(_operando1, _operando2);
        }

        [When(@"Se ejecutan todas las operaciones")]
        public void WhenSeEjecutanTodasLasOperaciones()
        {
            _resultadoListaOperaciones = new int[_tablaOperaciones.RowCount];
            for (int i = 0; i < _tablaOperaciones.RowCount; i++)
            {
                var row = _tablaOperaciones.Rows[i];

                _operacion = _creadorOperaciones.ObtenerOperacion((TipoOperacion)Enum.Parse(typeof(TipoOperacion), row["Operacion"], true));
                _resultadoListaOperaciones[i] = _operacion.Operar(Convert.ToInt32(row["Operando1"]), Convert.ToInt32(row["Operando2"]));

            }
        }

        [When(@"Se ejecutan todas las operaciones que salen del archivo")]
        public void WhenSeEjecutanTodasLasOperacionesQueSalenDelArchivo()
        {
            var archivoTexto = new ArchivoTexto();
            var listaComandos =archivoTexto.DevolverListaComandos();

            _resultadoListaOperacionesArchivo = new int[listaComandos.Count];
            for (int i = 0; i < listaComandos.Count; i++)
            {
                _operacion = _creadorOperaciones.ObtenerOperacion(listaComandos[i].Tipo);
                _resultadoListaOperacionesArchivo[i] = _operacion.Operar(listaComandos[i].Operando1, listaComandos[i].Operando2);
            }
        }

        [Then(@"el resultado de la suma debe ser (.*)")]
        public void ThenElResultadoDeLaSumaDebeSer(int p0)
        {
            Assert.AreEqual(p0, _resultado);
        }

        [Then(@"el resultado de la resta debe ser (.*)")]
        public void ThenElResultadoDeLaRestaDebeSer(int p0)
        {
            Assert.AreEqual(p0, _resultado);
        }

        [Then(@"el resultado de la multiplicacion debe ser (.*)")]
        public void ThenElResultadoDeLaMultiplicacionDebeSer(int p0)
        {
            Assert.AreEqual(p0, _resultado);
        }

        [Then(@"este resultado debe aparecer")]
        public void ThenEsteResultadoDebeAparecer(Table table)
        {
            CollectionAssert.AreEqual(UtilidadPrueba.ConvertirDeTablaResultadoArregloEntero(table), _resultadoListaOperaciones);
        }

        [Then(@"este resultado debe ser el siguiente")]
        public void ThenEsteResultadoDebeSerElSiguiente(Table table)
        {
            CollectionAssert.AreEqual(UtilidadPrueba.ConvertirDeTablaResultadoArregloEntero(table), _resultadoListaOperacionesArchivo);
        }

        

    }
}
