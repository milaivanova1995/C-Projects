﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Online_Photo_Effects.MagicServicesReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MagicServicesReference.MagicServicesSoap")]
    public interface MagicServicesSoap {
        
        // CODEGEN: Generating message contract since element name fileName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Magic1", ReplyAction="*")]
        Online_Photo_Effects.MagicServicesReference.Magic1Response Magic1(Online_Photo_Effects.MagicServicesReference.Magic1Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Magic1", ReplyAction="*")]
        System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic1Response> Magic1Async(Online_Photo_Effects.MagicServicesReference.Magic1Request request);
        
        // CODEGEN: Generating message contract since element name fileName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Magic2", ReplyAction="*")]
        Online_Photo_Effects.MagicServicesReference.Magic2Response Magic2(Online_Photo_Effects.MagicServicesReference.Magic2Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Magic2", ReplyAction="*")]
        System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic2Response> Magic2Async(Online_Photo_Effects.MagicServicesReference.Magic2Request request);
        
        // CODEGEN: Generating message contract since element name fileName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Magic3", ReplyAction="*")]
        Online_Photo_Effects.MagicServicesReference.Magic3Response Magic3(Online_Photo_Effects.MagicServicesReference.Magic3Request request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Magic3", ReplyAction="*")]
        System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic3Response> Magic3Async(Online_Photo_Effects.MagicServicesReference.Magic3Request request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Magic1Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Magic1", Namespace="http://tempuri.org/", Order=0)]
        public Online_Photo_Effects.MagicServicesReference.Magic1RequestBody Body;
        
        public Magic1Request() {
        }
        
        public Magic1Request(Online_Photo_Effects.MagicServicesReference.Magic1RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Magic1RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int w;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int h;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string fileName;
        
        public Magic1RequestBody() {
        }
        
        public Magic1RequestBody(int w, int h, string fileName) {
            this.w = w;
            this.h = h;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Magic1Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Magic1Response", Namespace="http://tempuri.org/", Order=0)]
        public Online_Photo_Effects.MagicServicesReference.Magic1ResponseBody Body;
        
        public Magic1Response() {
        }
        
        public Magic1Response(Online_Photo_Effects.MagicServicesReference.Magic1ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Magic1ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Magic1Result;
        
        public Magic1ResponseBody() {
        }
        
        public Magic1ResponseBody(string Magic1Result) {
            this.Magic1Result = Magic1Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Magic2Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Magic2", Namespace="http://tempuri.org/", Order=0)]
        public Online_Photo_Effects.MagicServicesReference.Magic2RequestBody Body;
        
        public Magic2Request() {
        }
        
        public Magic2Request(Online_Photo_Effects.MagicServicesReference.Magic2RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Magic2RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int w;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int h;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string fileName;
        
        public Magic2RequestBody() {
        }
        
        public Magic2RequestBody(int w, int h, string fileName) {
            this.w = w;
            this.h = h;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Magic2Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Magic2Response", Namespace="http://tempuri.org/", Order=0)]
        public Online_Photo_Effects.MagicServicesReference.Magic2ResponseBody Body;
        
        public Magic2Response() {
        }
        
        public Magic2Response(Online_Photo_Effects.MagicServicesReference.Magic2ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Magic2ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Magic2Result;
        
        public Magic2ResponseBody() {
        }
        
        public Magic2ResponseBody(string Magic2Result) {
            this.Magic2Result = Magic2Result;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Magic3Request {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Magic3", Namespace="http://tempuri.org/", Order=0)]
        public Online_Photo_Effects.MagicServicesReference.Magic3RequestBody Body;
        
        public Magic3Request() {
        }
        
        public Magic3Request(Online_Photo_Effects.MagicServicesReference.Magic3RequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Magic3RequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int w;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int h;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string fileName;
        
        public Magic3RequestBody() {
        }
        
        public Magic3RequestBody(int w, int h, string fileName) {
            this.w = w;
            this.h = h;
            this.fileName = fileName;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Magic3Response {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Magic3Response", Namespace="http://tempuri.org/", Order=0)]
        public Online_Photo_Effects.MagicServicesReference.Magic3ResponseBody Body;
        
        public Magic3Response() {
        }
        
        public Magic3Response(Online_Photo_Effects.MagicServicesReference.Magic3ResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Magic3ResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Magic3Result;
        
        public Magic3ResponseBody() {
        }
        
        public Magic3ResponseBody(string Magic3Result) {
            this.Magic3Result = Magic3Result;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MagicServicesSoapChannel : Online_Photo_Effects.MagicServicesReference.MagicServicesSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MagicServicesSoapClient : System.ServiceModel.ClientBase<Online_Photo_Effects.MagicServicesReference.MagicServicesSoap>, Online_Photo_Effects.MagicServicesReference.MagicServicesSoap {
        
        public MagicServicesSoapClient() {
        }
        
        public MagicServicesSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MagicServicesSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MagicServicesSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MagicServicesSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Online_Photo_Effects.MagicServicesReference.Magic1Response Online_Photo_Effects.MagicServicesReference.MagicServicesSoap.Magic1(Online_Photo_Effects.MagicServicesReference.Magic1Request request) {
            return base.Channel.Magic1(request);
        }
        
        public string Magic1(int w, int h, string fileName) {
            Online_Photo_Effects.MagicServicesReference.Magic1Request inValue = new Online_Photo_Effects.MagicServicesReference.Magic1Request();
            inValue.Body = new Online_Photo_Effects.MagicServicesReference.Magic1RequestBody();
            inValue.Body.w = w;
            inValue.Body.h = h;
            inValue.Body.fileName = fileName;
            Online_Photo_Effects.MagicServicesReference.Magic1Response retVal = ((Online_Photo_Effects.MagicServicesReference.MagicServicesSoap)(this)).Magic1(inValue);
            return retVal.Body.Magic1Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic1Response> Online_Photo_Effects.MagicServicesReference.MagicServicesSoap.Magic1Async(Online_Photo_Effects.MagicServicesReference.Magic1Request request) {
            return base.Channel.Magic1Async(request);
        }
        
        public System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic1Response> Magic1Async(int w, int h, string fileName) {
            Online_Photo_Effects.MagicServicesReference.Magic1Request inValue = new Online_Photo_Effects.MagicServicesReference.Magic1Request();
            inValue.Body = new Online_Photo_Effects.MagicServicesReference.Magic1RequestBody();
            inValue.Body.w = w;
            inValue.Body.h = h;
            inValue.Body.fileName = fileName;
            return ((Online_Photo_Effects.MagicServicesReference.MagicServicesSoap)(this)).Magic1Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Online_Photo_Effects.MagicServicesReference.Magic2Response Online_Photo_Effects.MagicServicesReference.MagicServicesSoap.Magic2(Online_Photo_Effects.MagicServicesReference.Magic2Request request) {
            return base.Channel.Magic2(request);
        }
        
        public string Magic2(int w, int h, string fileName) {
            Online_Photo_Effects.MagicServicesReference.Magic2Request inValue = new Online_Photo_Effects.MagicServicesReference.Magic2Request();
            inValue.Body = new Online_Photo_Effects.MagicServicesReference.Magic2RequestBody();
            inValue.Body.w = w;
            inValue.Body.h = h;
            inValue.Body.fileName = fileName;
            Online_Photo_Effects.MagicServicesReference.Magic2Response retVal = ((Online_Photo_Effects.MagicServicesReference.MagicServicesSoap)(this)).Magic2(inValue);
            return retVal.Body.Magic2Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic2Response> Online_Photo_Effects.MagicServicesReference.MagicServicesSoap.Magic2Async(Online_Photo_Effects.MagicServicesReference.Magic2Request request) {
            return base.Channel.Magic2Async(request);
        }
        
        public System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic2Response> Magic2Async(int w, int h, string fileName) {
            Online_Photo_Effects.MagicServicesReference.Magic2Request inValue = new Online_Photo_Effects.MagicServicesReference.Magic2Request();
            inValue.Body = new Online_Photo_Effects.MagicServicesReference.Magic2RequestBody();
            inValue.Body.w = w;
            inValue.Body.h = h;
            inValue.Body.fileName = fileName;
            return ((Online_Photo_Effects.MagicServicesReference.MagicServicesSoap)(this)).Magic2Async(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Online_Photo_Effects.MagicServicesReference.Magic3Response Online_Photo_Effects.MagicServicesReference.MagicServicesSoap.Magic3(Online_Photo_Effects.MagicServicesReference.Magic3Request request) {
            return base.Channel.Magic3(request);
        }
        
        public string Magic3(int w, int h, string fileName) {
            Online_Photo_Effects.MagicServicesReference.Magic3Request inValue = new Online_Photo_Effects.MagicServicesReference.Magic3Request();
            inValue.Body = new Online_Photo_Effects.MagicServicesReference.Magic3RequestBody();
            inValue.Body.w = w;
            inValue.Body.h = h;
            inValue.Body.fileName = fileName;
            Online_Photo_Effects.MagicServicesReference.Magic3Response retVal = ((Online_Photo_Effects.MagicServicesReference.MagicServicesSoap)(this)).Magic3(inValue);
            return retVal.Body.Magic3Result;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic3Response> Online_Photo_Effects.MagicServicesReference.MagicServicesSoap.Magic3Async(Online_Photo_Effects.MagicServicesReference.Magic3Request request) {
            return base.Channel.Magic3Async(request);
        }
        
        public System.Threading.Tasks.Task<Online_Photo_Effects.MagicServicesReference.Magic3Response> Magic3Async(int w, int h, string fileName) {
            Online_Photo_Effects.MagicServicesReference.Magic3Request inValue = new Online_Photo_Effects.MagicServicesReference.Magic3Request();
            inValue.Body = new Online_Photo_Effects.MagicServicesReference.Magic3RequestBody();
            inValue.Body.w = w;
            inValue.Body.h = h;
            inValue.Body.fileName = fileName;
            return ((Online_Photo_Effects.MagicServicesReference.MagicServicesSoap)(this)).Magic3Async(inValue);
        }
    }
}
