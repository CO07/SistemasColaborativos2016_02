using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace Calculadora1.Wcf
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICalculadora
    {

        [OperationContract]
        double Multiplicacion(double operandoUno, double operandoDos);

        [OperationContract]
        double Suma(double operandoUno, double operandoDos);

        [OperationContract]
        double Resta(double operandoUno, double operandoDos);

        [OperationContract]
        double Division(double operandoUno, double operandoDos);
      

        // TODO: Add your service operations here
    }
}
