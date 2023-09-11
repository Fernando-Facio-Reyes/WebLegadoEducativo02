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

namespace WebLegadoEducativo02.WS_LE_ConsProducto {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_ConsProductoSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_ConsProducto : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConsProductoOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_ConsProducto() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_ConsProducto_WS_LE_ConsProducto;
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
        public event ConsProductoCompletedEventHandler ConsProductoCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConsProducto", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsProducto[] ConsProducto(string area) {
            object[] results = this.Invoke("ConsProducto", new object[] {
                        area});
            return ((CsProducto[])(results[0]));
        }
        
        /// <remarks/>
        public void ConsProductoAsync(string area) {
            this.ConsProductoAsync(area, null);
        }
        
        /// <remarks/>
        public void ConsProductoAsync(string area, object userState) {
            if ((this.ConsProductoOperationCompleted == null)) {
                this.ConsProductoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConsProductoOperationCompleted);
            }
            this.InvokeAsync("ConsProducto", new object[] {
                        area}, this.ConsProductoOperationCompleted, userState);
        }
        
        private void OnConsProductoOperationCompleted(object arg) {
            if ((this.ConsProductoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConsProductoCompleted(this, new ConsProductoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class CsProducto {
        
        private string productidField;
        
        private string nameField;
        
        private string productnumberField;
        
        private string validfromdateField;
        
        private string validtodateField;
        
        private string descriptionField;
        
        private string defaultuomscheduleidField;
        
        private string defaultuomschedule_nameField;
        
        private string defaultuomidField;
        
        private string defaultuom_nameField;
        
        private string pricelevelidField;
        
        private string pricelevel_nameField;
        
        private string quantitydecimalField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string productid {
            get {
                return this.productidField;
            }
            set {
                this.productidField = value;
            }
        }
        
        /// <remarks/>
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        /// <remarks/>
        public string productnumber {
            get {
                return this.productnumberField;
            }
            set {
                this.productnumberField = value;
            }
        }
        
        /// <remarks/>
        public string validfromdate {
            get {
                return this.validfromdateField;
            }
            set {
                this.validfromdateField = value;
            }
        }
        
        /// <remarks/>
        public string validtodate {
            get {
                return this.validtodateField;
            }
            set {
                this.validtodateField = value;
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
        public string defaultuomscheduleid {
            get {
                return this.defaultuomscheduleidField;
            }
            set {
                this.defaultuomscheduleidField = value;
            }
        }
        
        /// <remarks/>
        public string defaultuomschedule_name {
            get {
                return this.defaultuomschedule_nameField;
            }
            set {
                this.defaultuomschedule_nameField = value;
            }
        }
        
        /// <remarks/>
        public string defaultuomid {
            get {
                return this.defaultuomidField;
            }
            set {
                this.defaultuomidField = value;
            }
        }
        
        /// <remarks/>
        public string defaultuom_name {
            get {
                return this.defaultuom_nameField;
            }
            set {
                this.defaultuom_nameField = value;
            }
        }
        
        /// <remarks/>
        public string pricelevelid {
            get {
                return this.pricelevelidField;
            }
            set {
                this.pricelevelidField = value;
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
        public string quantitydecimal {
            get {
                return this.quantitydecimalField;
            }
            set {
                this.quantitydecimalField = value;
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
    public delegate void ConsProductoCompletedEventHandler(object sender, ConsProductoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConsProductoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConsProductoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsProducto[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsProducto[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591