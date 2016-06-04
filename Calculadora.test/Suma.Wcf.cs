using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.test
{

    [TestClass]
    public class SumaTest
    {
        public Suma()
        {
            //Paso 1. defina el esenario de la prueba
            var elPrimerOperando = 4;
            var elSegundoOperando = 5;
            var elResultadoEsperado = -1;

            //Paso 2. Invoque el metodo que desea utilizar
            var laSuma = new Wcf
            var elResultadoReal = laSuma.Suma(elPrimerOperando, elSegundoOperando);

            //PAso 3. comparacion del resultado del obtenido con el esperado
            Assert.AreEqual(elResultadoEsperado, elResultadoReal);
        }

    }
}
