﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CyT.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProcedimientoListarPropiedades2ResultSet0", Namespace="http://alquileres.org/")]
    [System.SerializableAttribute()]
    public partial class ProcedimientoListarPropiedades2ResultSet0 : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreUsuarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ApellidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombrePropiedadField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreBarrioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        private System.Nullable<int> BañosField;
        
        private System.Nullable<int> HabitacionesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string GarageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public string NombreUsuario {
            get {
                return this.NombreUsuarioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreUsuarioField, value) != true)) {
                    this.NombreUsuarioField = value;
                    this.RaisePropertyChanged("NombreUsuario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string Apellido {
            get {
                return this.ApellidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ApellidoField, value) != true)) {
                    this.ApellidoField = value;
                    this.RaisePropertyChanged("Apellido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string NombrePropiedad {
            get {
                return this.NombrePropiedadField;
            }
            set {
                if ((object.ReferenceEquals(this.NombrePropiedadField, value) != true)) {
                    this.NombrePropiedadField = value;
                    this.RaisePropertyChanged("NombrePropiedad");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string NombreBarrio {
            get {
                return this.NombreBarrioField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreBarrioField, value) != true)) {
                    this.NombreBarrioField = value;
                    this.RaisePropertyChanged("NombreBarrio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.Nullable<int> Baños {
            get {
                return this.BañosField;
            }
            set {
                if ((this.BañosField.Equals(value) != true)) {
                    this.BañosField = value;
                    this.RaisePropertyChanged("Baños");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=6)]
        public System.Nullable<int> Habitaciones {
            get {
                return this.HabitacionesField;
            }
            set {
                if ((this.HabitacionesField.Equals(value) != true)) {
                    this.HabitacionesField = value;
                    this.RaisePropertyChanged("Habitaciones");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string Garage {
            get {
                return this.GarageField;
            }
            set {
                if ((object.ReferenceEquals(this.GarageField, value) != true)) {
                    this.GarageField = value;
                    this.RaisePropertyChanged("Garage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://alquileres.org/", ConfigurationName="ServiceReference1.MostrarAlquileresSoap")]
    public interface MostrarAlquileresSoap {
        
        // CODEGEN: Generating message contract since element name TodasLasPropiedadesResult from namespace http://alquileres.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://alquileres.org/TodasLasPropiedades", ReplyAction="*")]
        CyT.ServiceReference1.TodasLasPropiedadesResponse TodasLasPropiedades(CyT.ServiceReference1.TodasLasPropiedadesRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alquileres.org/TodasLasPropiedades", ReplyAction="*")]
        System.Threading.Tasks.Task<CyT.ServiceReference1.TodasLasPropiedadesResponse> TodasLasPropiedadesAsync(CyT.ServiceReference1.TodasLasPropiedadesRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TodasLasPropiedadesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TodasLasPropiedades", Namespace="http://alquileres.org/", Order=0)]
        public CyT.ServiceReference1.TodasLasPropiedadesRequestBody Body;
        
        public TodasLasPropiedadesRequest() {
        }
        
        public TodasLasPropiedadesRequest(CyT.ServiceReference1.TodasLasPropiedadesRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class TodasLasPropiedadesRequestBody {
        
        public TodasLasPropiedadesRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class TodasLasPropiedadesResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="TodasLasPropiedadesResponse", Namespace="http://alquileres.org/", Order=0)]
        public CyT.ServiceReference1.TodasLasPropiedadesResponseBody Body;
        
        public TodasLasPropiedadesResponse() {
        }
        
        public TodasLasPropiedadesResponse(CyT.ServiceReference1.TodasLasPropiedadesResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://alquileres.org/")]
    public partial class TodasLasPropiedadesResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public CyT.ServiceReference1.ProcedimientoListarPropiedades2ResultSet0[] TodasLasPropiedadesResult;
        
        public TodasLasPropiedadesResponseBody() {
        }
        
        public TodasLasPropiedadesResponseBody(CyT.ServiceReference1.ProcedimientoListarPropiedades2ResultSet0[] TodasLasPropiedadesResult) {
            this.TodasLasPropiedadesResult = TodasLasPropiedadesResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MostrarAlquileresSoapChannel : CyT.ServiceReference1.MostrarAlquileresSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MostrarAlquileresSoapClient : System.ServiceModel.ClientBase<CyT.ServiceReference1.MostrarAlquileresSoap>, CyT.ServiceReference1.MostrarAlquileresSoap {
        
        public MostrarAlquileresSoapClient() {
        }
        
        public MostrarAlquileresSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MostrarAlquileresSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MostrarAlquileresSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MostrarAlquileresSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        CyT.ServiceReference1.TodasLasPropiedadesResponse CyT.ServiceReference1.MostrarAlquileresSoap.TodasLasPropiedades(CyT.ServiceReference1.TodasLasPropiedadesRequest request) {
            return base.Channel.TodasLasPropiedades(request);
        }
        
        public CyT.ServiceReference1.ProcedimientoListarPropiedades2ResultSet0[] TodasLasPropiedades() {
            CyT.ServiceReference1.TodasLasPropiedadesRequest inValue = new CyT.ServiceReference1.TodasLasPropiedadesRequest();
            inValue.Body = new CyT.ServiceReference1.TodasLasPropiedadesRequestBody();
            CyT.ServiceReference1.TodasLasPropiedadesResponse retVal = ((CyT.ServiceReference1.MostrarAlquileresSoap)(this)).TodasLasPropiedades(inValue);
            return retVal.Body.TodasLasPropiedadesResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<CyT.ServiceReference1.TodasLasPropiedadesResponse> CyT.ServiceReference1.MostrarAlquileresSoap.TodasLasPropiedadesAsync(CyT.ServiceReference1.TodasLasPropiedadesRequest request) {
            return base.Channel.TodasLasPropiedadesAsync(request);
        }
        
        public System.Threading.Tasks.Task<CyT.ServiceReference1.TodasLasPropiedadesResponse> TodasLasPropiedadesAsync() {
            CyT.ServiceReference1.TodasLasPropiedadesRequest inValue = new CyT.ServiceReference1.TodasLasPropiedadesRequest();
            inValue.Body = new CyT.ServiceReference1.TodasLasPropiedadesRequestBody();
            return ((CyT.ServiceReference1.MostrarAlquileresSoap)(this)).TodasLasPropiedadesAsync(inValue);
        }
    }
}
