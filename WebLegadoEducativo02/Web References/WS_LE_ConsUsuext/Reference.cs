﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WebLegadoEducativo02.WS_LE_ConsUsuext {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_ConsUsuextSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_ConsUsuext : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ConUsuExtOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_ConsUsuext() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_ConsUsuext_WS_LE_ConsUsuext;
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
        public event ConUsuExtCompletedEventHandler ConUsuExtCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ConUsuExt", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public CsConUsuExt[] ConUsuExt(string UsEx, string direccion) {
            object[] results = this.Invoke("ConUsuExt", new object[] {
                        UsEx,
                        direccion});
            return ((CsConUsuExt[])(results[0]));
        }
        
        /// <remarks/>
        public void ConUsuExtAsync(string UsEx, string direccion) {
            this.ConUsuExtAsync(UsEx, direccion, null);
        }
        
        /// <remarks/>
        public void ConUsuExtAsync(string UsEx, string direccion, object userState) {
            if ((this.ConUsuExtOperationCompleted == null)) {
                this.ConUsuExtOperationCompleted = new System.Threading.SendOrPostCallback(this.OnConUsuExtOperationCompleted);
            }
            this.InvokeAsync("ConUsuExt", new object[] {
                        UsEx,
                        direccion}, this.ConUsuExtOperationCompleted, userState);
        }
        
        private void OnConUsuExtOperationCompleted(object arg) {
            if ((this.ConUsuExtCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ConUsuExtCompleted(this, new ConUsuExtCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.9032.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class CsConUsuExt {
        
        private string recr_contraseniahashField;
        
        private string recr_correoField;
        
        private string recr_direccionField;
        
        private string recr_nameField;
        
        private string recr_salField;
        
        private string recr_contactoidField;
        
        private string mensajeField;
        
        /// <remarks/>
        public string recr_contraseniahash {
            get {
                return this.recr_contraseniahashField;
            }
            set {
                this.recr_contraseniahashField = value;
            }
        }
        
        /// <remarks/>
        public string recr_correo {
            get {
                return this.recr_correoField;
            }
            set {
                this.recr_correoField = value;
            }
        }
        
        /// <remarks/>
        public string recr_direccion {
            get {
                return this.recr_direccionField;
            }
            set {
                this.recr_direccionField = value;
            }
        }
        
        /// <remarks/>
        public string recr_name {
            get {
                return this.recr_nameField;
            }
            set {
                this.recr_nameField = value;
            }
        }
        
        /// <remarks/>
        public string recr_sal {
            get {
                return this.recr_salField;
            }
            set {
                this.recr_salField = value;
            }
        }
        
        /// <remarks/>
        public string recr_contactoid {
            get {
                return this.recr_contactoidField;
            }
            set {
                this.recr_contactoidField = value;
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void ConUsuExtCompletedEventHandler(object sender, ConUsuExtCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class ConUsuExtCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal ConUsuExtCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public CsConUsuExt[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((CsConUsuExt[])(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591