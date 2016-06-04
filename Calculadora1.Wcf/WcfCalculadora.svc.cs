using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculadora1.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class WcfCalculadora : ICalculadora
    {
        public double Division(double operandoUno, double operandoDos)
        {
            var laInvocacion = new Logica.Negocio.RealizarOperacion();
            var resultado = 0.0;

            resultado = laInvocacion.Calcular(operandoUno, operandoDos, "/");
            return resultado;
        }

        public double Multiplicacion(double operandoUno, double operandoDos)
        {
            var laInvocacion = new Logica.Negocio.RealizarOperacion();
            var resultado = 0.0;

            resultado = laInvocacion.Calcular(operandoUno, operandoDos, "*");
            return resultado;
        }

        public double Resta(double operandoUno, double operandoDos)
        {
            var laInvocacion = new Logica.Negocio.RealizarOperacion();
            var resultado = 0.0;

            resultado = laInvocacion.Calcular(operandoUno, operandoDos, "-");
            return resultado;
        }

        public double Suma(double operandoUno, double operandoDos)
        {
            var laInvocacion = new Logica.Negocio.RealizarOperacion();
            var resultado = 0.0;

            resultado = laInvocacion.Calcular(operandoUno, operandoDos, "+");
            return resultado;
        }
    }
}
