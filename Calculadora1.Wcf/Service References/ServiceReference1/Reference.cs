﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculadora1.Wcf.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculadora")]
    public interface ICalculadora {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Multiplicacion", ReplyAction="http://tempuri.org/ICalculadora/MultiplicacionResponse")]
        double Multiplicacion(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Multiplicacion", ReplyAction="http://tempuri.org/ICalculadora/MultiplicacionResponse")]
        System.Threading.Tasks.Task<double> MultiplicacionAsync(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Suma", ReplyAction="http://tempuri.org/ICalculadora/SumaResponse")]
        double Suma(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Suma", ReplyAction="http://tempuri.org/ICalculadora/SumaResponse")]
        System.Threading.Tasks.Task<double> SumaAsync(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Resta", ReplyAction="http://tempuri.org/ICalculadora/RestaResponse")]
        double Resta(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Resta", ReplyAction="http://tempuri.org/ICalculadora/RestaResponse")]
        System.Threading.Tasks.Task<double> RestaAsync(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Division", ReplyAction="http://tempuri.org/ICalculadora/DivisionResponse")]
        double Division(double operandoUno, double operandoDos);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculadora/Division", ReplyAction="http://tempuri.org/ICalculadora/DivisionResponse")]
        System.Threading.Tasks.Task<double> DivisionAsync(double operandoUno, double operandoDos);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculadoraChannel : Calculadora1.Wcf.ServiceReference1.ICalculadora, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculadoraClient : System.ServiceModel.ClientBase<Calculadora1.Wcf.ServiceReference1.ICalculadora>, Calculadora1.Wcf.ServiceReference1.ICalculadora {
        
        public CalculadoraClient() {
        }
        
        public CalculadoraClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculadoraClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculadoraClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double Multiplicacion(double operandoUno, double operandoDos) {
            return base.Channel.Multiplicacion(operandoUno, operandoDos);
        }
        
        public System.Threading.Tasks.Task<double> MultiplicacionAsync(double operandoUno, double operandoDos) {
            return base.Channel.MultiplicacionAsync(operandoUno, operandoDos);
        }
        
        public double Suma(double operandoUno, double operandoDos) {
            return base.Channel.Suma(operandoUno, operandoDos);
        }
        
        public System.Threading.Tasks.Task<double> SumaAsync(double operandoUno, double operandoDos) {
            return base.Channel.SumaAsync(operandoUno, operandoDos);
        }
        
        public double Resta(double operandoUno, double operandoDos) {
            return base.Channel.Resta(operandoUno, operandoDos);
        }
        
        public System.Threading.Tasks.Task<double> RestaAsync(double operandoUno, double operandoDos) {
            return base.Channel.RestaAsync(operandoUno, operandoDos);
        }
        
        public double Division(double operandoUno, double operandoDos) {
            return base.Channel.Division(operandoUno, operandoDos);
        }
        
        public System.Threading.Tasks.Task<double> DivisionAsync(double operandoUno, double operandoDos) {
            return base.Channel.DivisionAsync(operandoUno, operandoDos);
        }
    }
}
