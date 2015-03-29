using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace ExamenllPatronesDiseño
{
    [Binding]
    public class IteradorSteps
    {
        private List<Comando> _comandos=new List<Comando>();
        private Sumador _sumador=new Sumador();
        private Restador _restador=new Restador();
        private Multiplicador _multiplicador=new Multiplicador();
        private Comando _comando;
        public bool ATerminado = false;

        [Given(@"Una lista de operaciones:")]
        public void GivenUnaListaDeComando(Table table)
        {
            _comandos = UtilidadPrueba.ConvertirDeTablaListaComandos(table);
        }


        [When(@"se crea el iterador")]
        public void WhenSeCreaElIterador()
        {
            _sumador.CrearIterador();
            _restador.CrearIterador();
            _multiplicador.CrearIterador();
        }

        [When(@"Se llenan todas las listas de las operaciones")]
        public void WhenSeLlenanTodasLasListasDeLasOperaciones()
        {
            _sumador.LlenarLista(UtilidadPrueba.DevolverComandoPorTipo(_comandos, TipoOperacion.Suma));
            _restador.LlenarLista(UtilidadPrueba.DevolverComandoPorTipo(_comandos, TipoOperacion.Resta));
            _multiplicador.LlenarLista(UtilidadPrueba.DevolverComandoPorTipo(_comandos, TipoOperacion.Multiplicacion));
        }

        [When(@"Se obtiene la primera operacion de la suma")]
        public void WhenSeObtieneLaPrimeraOperacionDeLaSuma()
        {
            _comando = _sumador.Iterador.ItemActual();
        }

        [When(@"Se llama la siguiente operacion de la resta")]
        public void WhenSeLlamaLaSiguienteOperacionDeLaResta()
        {
            _comando = _restador.Iterador.Siguiente();
        }
 
 
        [Then(@"La cantidad de operaciones en la Suma deberian ser (.*) , en la Resta (.*) y en la Multiplicacion (.*)")]
        public void ThenLaCantidadDeOperacionesEnLaSumaDeberianSerEnLaRestaYEnLaMultiplicacion(int p0, int p1, int p2)
        {
            bool Correcto = _sumador.DevolverComandos().Count == p0 && 
                _restador.DevolverComandos().Count == p1 && 
                _multiplicador.DevolverComandos().Count == p2;

            Assert.AreEqual(Correcto, true);
        }


        [Then(@"La operacion deberia ser ""(.*)"" con (.*) y (.*)")]
        public void ThenLaOperacionDeberiaSerConY(string p0, int p1, int p2)
        {
            Assert.AreEqual(_comando.Operando1 == p1 && _comando.Operando2 == p2 && _comando.Tipo.ToString().Equals(p0), true);
        }

        [Then(@"Deberia de haber terminado")]
        public void ThenDeberiaDeHaberTerminado()
        {
            Assert.AreEqual(_restador.Iterador.ATerminado(),true);
        }

    }
}
