using System;

namespace Logica.Negocio
{
    public class Potencia

    {
        public double Operar(double operandoUno, double operandoDos)
        {
            double elResultado;
            elResultado = Math.Pow(operandoUno, operandoDos); 
            return (elResultado);
        }
    }
}