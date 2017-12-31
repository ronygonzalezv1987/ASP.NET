﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorWebApplication.CalculatorService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.CollectionDataContractAttribute(Name="ArrayOfString", Namespace="http://www.ronyprueba.com/", ItemName="string")]
    [System.SerializableAttribute()]
    public class ArrayOfString : System.Collections.Generic.List<string> {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.ronyprueba.com/", ConfigurationName="CalculatorService.CalculatorWebServicesSoap")]
    public interface CalculatorWebServicesSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ronyprueba.com/Add", ReplyAction="*")]
        int Add(int firstNumber, int secondNumber);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ronyprueba.com/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber);
        
        // CODEGEN: Generating message contract since element name GetCalculationsResult from namespace http://www.ronyprueba.com/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ronyprueba.com/GetCalculations", ReplyAction="*")]
        CalculatorWebApplication.CalculatorService.GetCalculationsResponse GetCalculations(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://www.ronyprueba.com/GetCalculations", ReplyAction="*")]
        System.Threading.Tasks.Task<CalculatorWebApplication.CalculatorService.GetCalculationsResponse> GetCalculationsAsync(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculations", Namespace="http://www.ronyprueba.com/", Order=0)]
        public CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody Body;
        
        public GetCalculationsRequest() {
        }
        
        public GetCalculationsRequest(CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCalculationsRequestBody {
        
        public GetCalculationsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCalculationsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCalculationsResponse", Namespace="http://www.ronyprueba.com/", Order=0)]
        public CalculatorWebApplication.CalculatorService.GetCalculationsResponseBody Body;
        
        public GetCalculationsResponse() {
        }
        
        public GetCalculationsResponse(CalculatorWebApplication.CalculatorService.GetCalculationsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.ronyprueba.com/")]
    public partial class GetCalculationsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CalculatorWebApplication.CalculatorService.ArrayOfString GetCalculationsResult;
        
        public GetCalculationsResponseBody() {
        }
        
        public GetCalculationsResponseBody(CalculatorWebApplication.CalculatorService.ArrayOfString GetCalculationsResult) {
            this.GetCalculationsResult = GetCalculationsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface CalculatorWebServicesSoapChannel : CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorWebServicesSoapClient : System.ServiceModel.ClientBase<CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap>, CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap {
        
        public CalculatorWebServicesSoapClient() {
        }
        
        public CalculatorWebServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorWebServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorWebServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int firstNumber, int secondNumber) {
            return base.Channel.Add(firstNumber, secondNumber);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int firstNumber, int secondNumber) {
            return base.Channel.AddAsync(firstNumber, secondNumber);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CalculatorWebApplication.CalculatorService.GetCalculationsResponse CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap.GetCalculations(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculations(request);
        }
        
        public CalculatorWebApplication.CalculatorService.ArrayOfString GetCalculations() {
            CalculatorWebApplication.CalculatorService.GetCalculationsRequest inValue = new CalculatorWebApplication.CalculatorService.GetCalculationsRequest();
            inValue.Body = new CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody();
            CalculatorWebApplication.CalculatorService.GetCalculationsResponse retVal = ((CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap)(this)).GetCalculations(inValue);
            return retVal.Body.GetCalculationsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CalculatorWebApplication.CalculatorService.GetCalculationsResponse> CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap.GetCalculationsAsync(CalculatorWebApplication.CalculatorService.GetCalculationsRequest request) {
            return base.Channel.GetCalculationsAsync(request);
        }
        
        public System.Threading.Tasks.Task<CalculatorWebApplication.CalculatorService.GetCalculationsResponse> GetCalculationsAsync() {
            CalculatorWebApplication.CalculatorService.GetCalculationsRequest inValue = new CalculatorWebApplication.CalculatorService.GetCalculationsRequest();
            inValue.Body = new CalculatorWebApplication.CalculatorService.GetCalculationsRequestBody();
            return ((CalculatorWebApplication.CalculatorService.CalculatorWebServicesSoap)(this)).GetCalculationsAsync(inValue);
        }
    }
}
