﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDemo.MathService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MathService.IArithmeticService")]
    public interface IArithmeticService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IArithmeticService/Add", ReplyAction="http://tempuri.org/IArithmeticService/AddResponse")]
        int Add(int number1, int number2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IArithmeticServiceChannel : WcfDemo.MathService.IArithmeticService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ArithmeticServiceClient : System.ServiceModel.ClientBase<WcfDemo.MathService.IArithmeticService>, WcfDemo.MathService.IArithmeticService {
        
        public ArithmeticServiceClient() {
        }
        
        public ArithmeticServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ArithmeticServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArithmeticServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ArithmeticServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int number1, int number2) {
            return base.Channel.Add(number1, number2);
        }
    }
}
