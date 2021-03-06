﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1426
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleClient.WebServicesSample {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://www.wrox.com/webservices", ConfigurationName="WebServicesSample.Service1Soap")]
    public interface Service1Soap {
        
        // CODEGEN: Generating message contract since element name message from namespace http://www.wrox.com/webservices is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://www.wrox.com/webservices/ReverseString", ReplyAction="*")]
        SimpleClient.WebServicesSample.ReverseStringResponse ReverseString(SimpleClient.WebServicesSample.ReverseStringRequest request);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://www.wrox.com/webservices/ReverseString", ReplyAction="*")]
        System.IAsyncResult BeginReverseString(SimpleClient.WebServicesSample.ReverseStringRequest request, System.AsyncCallback callback, object asyncState);
        
        SimpleClient.WebServicesSample.ReverseStringResponse EndReverseString(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseString", Namespace="http://www.wrox.com/webservices", Order=0)]
        public SimpleClient.WebServicesSample.ReverseStringRequestBody Body;
        
        public ReverseStringRequest() {
        }
        
        public ReverseStringRequest(SimpleClient.WebServicesSample.ReverseStringRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.wrox.com/webservices")]
    public partial class ReverseStringRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string message;
        
        public ReverseStringRequestBody() {
        }
        
        public ReverseStringRequestBody(string message) {
            this.message = message;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ReverseStringResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ReverseStringResponse", Namespace="http://www.wrox.com/webservices", Order=0)]
        public SimpleClient.WebServicesSample.ReverseStringResponseBody Body;
        
        public ReverseStringResponse() {
        }
        
        public ReverseStringResponse(SimpleClient.WebServicesSample.ReverseStringResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://www.wrox.com/webservices")]
    public partial class ReverseStringResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string ReverseStringResult;
        
        public ReverseStringResponseBody() {
        }
        
        public ReverseStringResponseBody(string ReverseStringResult) {
            this.ReverseStringResult = ReverseStringResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface Service1SoapChannel : SimpleClient.WebServicesSample.Service1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ReverseStringCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public ReverseStringCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class Service1SoapClient : System.ServiceModel.ClientBase<SimpleClient.WebServicesSample.Service1Soap>, SimpleClient.WebServicesSample.Service1Soap {
        
        private BeginOperationDelegate onBeginReverseStringDelegate;
        
        private EndOperationDelegate onEndReverseStringDelegate;
        
        private System.Threading.SendOrPostCallback onReverseStringCompletedDelegate;
        
        public Service1SoapClient() {
        }
        
        public Service1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public event System.EventHandler<ReverseStringCompletedEventArgs> ReverseStringCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SimpleClient.WebServicesSample.ReverseStringResponse SimpleClient.WebServicesSample.Service1Soap.ReverseString(SimpleClient.WebServicesSample.ReverseStringRequest request) {
            return base.Channel.ReverseString(request);
        }
        
        public string ReverseString(string message) {
            SimpleClient.WebServicesSample.ReverseStringRequest inValue = new SimpleClient.WebServicesSample.ReverseStringRequest();
            inValue.Body = new SimpleClient.WebServicesSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            SimpleClient.WebServicesSample.ReverseStringResponse retVal = ((SimpleClient.WebServicesSample.Service1Soap)(this)).ReverseString(inValue);
            return retVal.Body.ReverseStringResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SimpleClient.WebServicesSample.Service1Soap.BeginReverseString(SimpleClient.WebServicesSample.ReverseStringRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginReverseString(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public System.IAsyncResult BeginReverseString(string message, System.AsyncCallback callback, object asyncState) {
            SimpleClient.WebServicesSample.ReverseStringRequest inValue = new SimpleClient.WebServicesSample.ReverseStringRequest();
            inValue.Body = new SimpleClient.WebServicesSample.ReverseStringRequestBody();
            inValue.Body.message = message;
            return ((SimpleClient.WebServicesSample.Service1Soap)(this)).BeginReverseString(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SimpleClient.WebServicesSample.ReverseStringResponse SimpleClient.WebServicesSample.Service1Soap.EndReverseString(System.IAsyncResult result) {
            return base.Channel.EndReverseString(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public string EndReverseString(System.IAsyncResult result) {
            SimpleClient.WebServicesSample.ReverseStringResponse retVal = ((SimpleClient.WebServicesSample.Service1Soap)(this)).EndReverseString(result);
            return retVal.Body.ReverseStringResult;
        }
        
        private System.IAsyncResult OnBeginReverseString(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string message = ((string)(inValues[0]));
            return this.BeginReverseString(message, callback, asyncState);
        }
        
        private object[] OnEndReverseString(System.IAsyncResult result) {
            string retVal = this.EndReverseString(result);
            return new object[] {
                    retVal};
        }
        
        private void OnReverseStringCompleted(object state) {
            if ((this.ReverseStringCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.ReverseStringCompleted(this, new ReverseStringCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void ReverseStringAsync(string message) {
            this.ReverseStringAsync(message, null);
        }
        
        public void ReverseStringAsync(string message, object userState) {
            if ((this.onBeginReverseStringDelegate == null)) {
                this.onBeginReverseStringDelegate = new BeginOperationDelegate(this.OnBeginReverseString);
            }
            if ((this.onEndReverseStringDelegate == null)) {
                this.onEndReverseStringDelegate = new EndOperationDelegate(this.OnEndReverseString);
            }
            if ((this.onReverseStringCompletedDelegate == null)) {
                this.onReverseStringCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnReverseStringCompleted);
            }
            base.InvokeAsync(this.onBeginReverseStringDelegate, new object[] {
                        message}, this.onEndReverseStringDelegate, this.onReverseStringCompletedDelegate, userState);
        }
    }
}
