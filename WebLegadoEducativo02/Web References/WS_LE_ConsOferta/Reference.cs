﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebLegadoEducativo02.WS_LE_ConsOferta {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_ConsOfertaSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_ConsOferta : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConsOfertOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_ConsOferta() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_ConsOferta_WS_LE_ConsOferta;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event ConsOfertCompletedEventHandler ConsOfertCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsOfert", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsOferta[] ConsOfert(string opportunityid, string customerid) {
            object[] results = this.Invoke("ConsOfert", new object[] {
                        opportunityid,
                        customerid});
            return ((CsOferta[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsOfertAsync(string opportunityid, string customerid) {
            this.ConsOfertAsync(opportunityid, customerid, null);
        }
        
        /// <remarks/>
        public void ConsOfertAsync(string opportunityid, string customerid, object userState) {
            if ((this.ConsOfertOperationCompleted == null)) {
                this.ConsOfertOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsOfertOperationCompleted);
            }
            this.InvokeAsync("ConsOfert", new object[] {
                        opportunityid,
                        customerid}, this.ConsOfertOperationCompleted, userState);
        }
        
        private void OnConsOfertOperationCompleted(object arg) {
            if ((this.ConsOfertCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsOfertCompleted(this, new ConsOfertCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CsOferta {
        
        private string quoteidField;
        
        private string udem_importetotalenletraField;
        
        private string transactioncurrency_idField;
        
        private string transactioncurrency_nameField;
        
        private string pricelevel_idField;
        
        private string pricelevel_nameField;
        
        private string descriptionField;
        
        private string opportunity_idField;
        
        private string opportunity_nameField;
        
        private string udem_solicituddecompra_idField;
        
        private string udem_solicituddecompra_nameField;
        
        private string customer_idField;
        
        private string customer_nameField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string quoteid {
            get {
                return this.quoteidField;
            }
            set {
                this.quoteidField = value;
            }
        }
        
        /// <remarks/>
        public string udem_importetotalenletra {
            get {
                return this.udem_importetotalenletraField;
            }
            set {
                this.udem_importetotalenletraField = value;
            }
        }
        
        /// <remarks/>
        public string transactioncurrency_id {
            get {
                return this.transactioncurrency_idField;
            }
            set {
                this.transactioncurrency_idField = value;
            }
        }
        
        /// <remarks/>
        public string transactioncurrency_name {
            get {
                return this.transactioncurrency_nameField;
            }
            set {
                this.transactioncurrency_nameField = value;
            }
        }
        
        /// <remarks/>
        public string pricelevel_id {
            get {
                return this.pricelevel_idField;
            }
            set {
                this.pricelevel_idField = value;
            }
        }
        
        /// <remarks/>
        public string pricelevel_name {
            get {
                return this.pricelevel_nameField;
            }
            set {
                this.pricelevel_nameField = value;
            }
        }
        
        /// <remarks/>
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
        
        /// <remarks/>
        public string opportunity_id {
            get {
                return this.opportunity_idField;
            }
            set {
                this.opportunity_idField = value;
            }
        }
        
        /// <remarks/>
        public string opportunity_name {
            get {
                return this.opportunity_nameField;
            }
            set {
                this.opportunity_nameField = value;
            }
        }
        
        /// <remarks/>
        public string udem_solicituddecompra_id {
            get {
                return this.udem_solicituddecompra_idField;
            }
            set {
                this.udem_solicituddecompra_idField = value;
            }
        }
        
        /// <remarks/>
        public string udem_solicituddecompra_name {
            get {
                return this.udem_solicituddecompra_nameField;
            }
            set {
                this.udem_solicituddecompra_nameField = value;
            }
        }
        
        /// <remarks/>
        public string customer_id {
            get {
                return this.customer_idField;
            }
            set {
                this.customer_idField = value;
            }
        }
        
        /// <remarks/>
        public string customer_name {
            get {
                return this.customer_nameField;
            }
            set {
                this.customer_nameField = value;
            }
        }
        
        /// <remarks/>
        public string mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ConsOfertCompletedEventHandler(object sender, ConsOfertCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsOfertCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsOfertCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsOferta[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsOferta[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591