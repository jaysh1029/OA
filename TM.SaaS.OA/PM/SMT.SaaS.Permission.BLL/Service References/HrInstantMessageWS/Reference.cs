﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.239
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace SMT.SaaS.Permission.BLL.HrInstantMessageWS {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompanyModel", Namespace="http://schemas.datacontract.org/2004/07/SMT.HRM.BLL")]
    [System.SerializableAttribute()]
    public partial class CompanyModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ParentIDField;
        
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
        public string CompanyID {
            get {
                return this.CompanyIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyIDField, value) != true)) {
                    this.CompanyIDField = value;
                    this.RaisePropertyChanged("CompanyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompanyName {
            get {
                return this.CompanyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyNameField, value) != true)) {
                    this.CompanyNameField = value;
                    this.RaisePropertyChanged("CompanyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ParentID {
            get {
                return this.ParentIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentIDField, value) != true)) {
                    this.ParentIDField = value;
                    this.RaisePropertyChanged("ParentID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DepartmentModel", Namespace="http://schemas.datacontract.org/2004/07/SMT.HRM.BLL")]
    [System.SerializableAttribute()]
    public partial class DepartmentModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CompanyIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeptIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ParentIDField;
        
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
        public string CompanyID {
            get {
                return this.CompanyIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CompanyIDField, value) != true)) {
                    this.CompanyIDField = value;
                    this.RaisePropertyChanged("CompanyID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartName {
            get {
                return this.DepartNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartNameField, value) != true)) {
                    this.DepartNameField = value;
                    this.RaisePropertyChanged("DepartName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeptID {
            get {
                return this.DeptIDField;
            }
            set {
                if ((object.ReferenceEquals(this.DeptIDField, value) != true)) {
                    this.DeptIDField = value;
                    this.RaisePropertyChanged("DeptID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ParentID {
            get {
                return this.ParentIDField;
            }
            set {
                if ((object.ReferenceEquals(this.ParentIDField, value) != true)) {
                    this.ParentIDField = value;
                    this.RaisePropertyChanged("ParentID");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="EmployeeModel", Namespace="http://schemas.datacontract.org/2004/07/SMT.HRM.BLL")]
    [System.SerializableAttribute()]
    public partial class EmployeeModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DepartMentNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DeptIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmployeeNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MobileField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ProvinceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string RemarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string SexField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelField;
        
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
        public string AddCode {
            get {
                return this.AddCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.AddCodeField, value) != true)) {
                    this.AddCodeField = value;
                    this.RaisePropertyChanged("AddCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Age {
            get {
                return this.AgeField;
            }
            set {
                if ((object.ReferenceEquals(this.AgeField, value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DepartMentName {
            get {
                return this.DepartMentNameField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartMentNameField, value) != true)) {
                    this.DepartMentNameField = value;
                    this.RaisePropertyChanged("DepartMentName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DeptID {
            get {
                return this.DeptIDField;
            }
            set {
                if ((object.ReferenceEquals(this.DeptIDField, value) != true)) {
                    this.DeptIDField = value;
                    this.RaisePropertyChanged("DeptID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
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
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeId {
            get {
                return this.EmployeeIdField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeIdField, value) != true)) {
                    this.EmployeeIdField = value;
                    this.RaisePropertyChanged("EmployeeId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmployeeName {
            get {
                return this.EmployeeNameField;
            }
            set {
                if ((object.ReferenceEquals(this.EmployeeNameField, value) != true)) {
                    this.EmployeeNameField = value;
                    this.RaisePropertyChanged("EmployeeName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Mobile {
            get {
                return this.MobileField;
            }
            set {
                if ((object.ReferenceEquals(this.MobileField, value) != true)) {
                    this.MobileField = value;
                    this.RaisePropertyChanged("Mobile");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Nation {
            get {
                return this.NationField;
            }
            set {
                if ((object.ReferenceEquals(this.NationField, value) != true)) {
                    this.NationField = value;
                    this.RaisePropertyChanged("Nation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostName {
            get {
                return this.PostNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PostNameField, value) != true)) {
                    this.PostNameField = value;
                    this.RaisePropertyChanged("PostName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Province {
            get {
                return this.ProvinceField;
            }
            set {
                if ((object.ReferenceEquals(this.ProvinceField, value) != true)) {
                    this.ProvinceField = value;
                    this.RaisePropertyChanged("Province");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Remark {
            get {
                return this.RemarkField;
            }
            set {
                if ((object.ReferenceEquals(this.RemarkField, value) != true)) {
                    this.RemarkField = value;
                    this.RaisePropertyChanged("Remark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Sex {
            get {
                return this.SexField;
            }
            set {
                if ((object.ReferenceEquals(this.SexField, value) != true)) {
                    this.SexField = value;
                    this.RaisePropertyChanged("Sex");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Tel {
            get {
                return this.TelField;
            }
            set {
                if ((object.ReferenceEquals(this.TelField, value) != true)) {
                    this.TelField = value;
                    this.RaisePropertyChanged("Tel");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="HrInstantMessageWS.InstantMessagingService")]
    public interface InstantMessagingService {
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:InstantMessagingService/DoWork", ReplyAction="urn:InstantMessagingService/DoWorkResponse")]
        void DoWork();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:InstantMessagingService/GetAllCompany", ReplyAction="urn:InstantMessagingService/GetAllCompanyResponse")]
        SMT.SaaS.Permission.BLL.HrInstantMessageWS.CompanyModel[] GetAllCompany();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:InstantMessagingService/GetAllDepartment", ReplyAction="urn:InstantMessagingService/GetAllDepartmentResponse")]
        SMT.SaaS.Permission.BLL.HrInstantMessageWS.DepartmentModel[] GetAllDepartment();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:InstantMessagingService/GetAllEmployee", ReplyAction="urn:InstantMessagingService/GetAllEmployeeResponse")]
        SMT.SaaS.Permission.BLL.HrInstantMessageWS.EmployeeModel[] GetAllEmployee();
        
        [System.ServiceModel.OperationContractAttribute(Action="urn:InstantMessagingService/GetSingelEmployee", ReplyAction="urn:InstantMessagingService/GetSingelEmployeeResponse")]
        SMT.SaaS.Permission.BLL.HrInstantMessageWS.EmployeeModel GetSingelEmployee(string ID);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface InstantMessagingServiceChannel : SMT.SaaS.Permission.BLL.HrInstantMessageWS.InstantMessagingService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class InstantMessagingServiceClient : System.ServiceModel.ClientBase<SMT.SaaS.Permission.BLL.HrInstantMessageWS.InstantMessagingService>, SMT.SaaS.Permission.BLL.HrInstantMessageWS.InstantMessagingService {
        
        public InstantMessagingServiceClient() {
        }
        
        public InstantMessagingServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public InstantMessagingServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InstantMessagingServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public InstantMessagingServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void DoWork() {
            base.Channel.DoWork();
        }
        
        public SMT.SaaS.Permission.BLL.HrInstantMessageWS.CompanyModel[] GetAllCompany() {
            return base.Channel.GetAllCompany();
        }
        
        public SMT.SaaS.Permission.BLL.HrInstantMessageWS.DepartmentModel[] GetAllDepartment() {
            return base.Channel.GetAllDepartment();
        }
        
        public SMT.SaaS.Permission.BLL.HrInstantMessageWS.EmployeeModel[] GetAllEmployee() {
            return base.Channel.GetAllEmployee();
        }
        
        public SMT.SaaS.Permission.BLL.HrInstantMessageWS.EmployeeModel GetSingelEmployee(string ID) {
            return base.Channel.GetSingelEmployee(ID);
        }
    }
}