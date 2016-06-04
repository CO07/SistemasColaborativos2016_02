using System;

namespace Logica.Negocio
{
    public class Cos
    {
        public double Operar(double operandoUno)
        {
            double elResultado;
            elResultado = Math.Cos(operandoUno);
            return (elResultado);
        }
    }
}