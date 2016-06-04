using System;

namespace Logica.Negocio
{
    public class Log
    {
        public double Operar(double operandoUno, double operandoDos)
        {
            double elResultado;
            elResultado = Math.Log(operandoUno, operandoDos);
            return (elResultado);
        }
    }
}