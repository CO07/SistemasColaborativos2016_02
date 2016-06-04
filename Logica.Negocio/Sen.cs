using System;

namespace Logica.Negocio
{
    public class Sen 
    {
        public double Operar(double operandoUno, double operandoDos)
        {
            double elResultado;
            elResultado = Math.Sin(operandoUno);
            return (elResultado);
        }
    }
}