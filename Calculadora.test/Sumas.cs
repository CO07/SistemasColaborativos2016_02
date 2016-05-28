using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logica.Negocio;

namespace Calculadora.test
{
    [TestClass]
    public class Sumas
    {
        [TestMethod]
        public void SumarUnoMasDos()
        {
            //Paso 1. defina el esenario de la prueba
            var elPrimerOperando = 1;
            var elSegundoOperando = 2;
            var elResultadoEsperado = 3;

            //Paso 2. Invoque el metodo que desea utilizar
            var laSuma = new Suma();
            var elResultadoReal = laSuma.Operar(elPrimerOperando, elSegundoOperando);

            //PAso 3. comparacion del resultado del obtenido con el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);
        }
    }
}
//pruebas unitarias para resta multiplicacion y division