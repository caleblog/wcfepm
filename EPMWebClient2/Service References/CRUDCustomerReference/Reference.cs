﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EPMWebClient2.CRUDCustomerReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Customer", Namespace="http://schemas.datacontract.org/2004/07/WCFEMPLibrary")]
    [System.SerializableAttribute()]
    public partial class Customer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDClientField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int LastReadingField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool ReadField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IDClient {
            get {
                return this.IDClientField;
            }
            set {
                if ((this.IDClientField.Equals(value) != true)) {
                    this.IDClientField = value;
                    this.RaisePropertyChanged("IDClient");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LastReading {
            get {
                return this.LastReadingField;
            }
            set {
                if ((this.LastReadingField.Equals(value) != true)) {
                    this.LastReadingField = value;
                    this.RaisePropertyChanged("LastReading");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Phone {
            get {
                return this.PhoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneField, value) != true)) {
                    this.PhoneField = value;
                    this.RaisePropertyChanged("Phone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Read {
            get {
                return this.ReadField;
            }
            set {
                if ((this.ReadField.Equals(value) != true)) {
                    this.ReadField = value;
                    this.RaisePropertyChanged("Read");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CRUDCustomerReference.ICRUDCustomerService")]
    public interface ICRUDCustomerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDCustomerService/getCustomer", ReplyAction="http://tempuri.org/ICRUDCustomerService/getCustomerResponse")]
        EPMWebClient2.CRUDCustomerReference.Customer getCustomer(int IDClient);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICRUDCustomerService/UpdateLastReading", ReplyAction="http://tempuri.org/ICRUDCustomerService/UpdateLastReadingResponse")]
        void UpdateLastReading(int IDClient, int newReading);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICRUDCustomerServiceChannel : EPMWebClient2.CRUDCustomerReference.ICRUDCustomerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CRUDCustomerServiceClient : System.ServiceModel.ClientBase<EPMWebClient2.CRUDCustomerReference.ICRUDCustomerService>, EPMWebClient2.CRUDCustomerReference.ICRUDCustomerService {
        
        public CRUDCustomerServiceClient() {
        }
        
        public CRUDCustomerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CRUDCustomerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDCustomerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CRUDCustomerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public EPMWebClient2.CRUDCustomerReference.Customer getCustomer(int IDClient) {
            return base.Channel.getCustomer(IDClient);
        }
        
        public void UpdateLastReading(int IDClient, int newReading) {
            base.Channel.UpdateLastReading(IDClient, newReading);
        }
    }
}
