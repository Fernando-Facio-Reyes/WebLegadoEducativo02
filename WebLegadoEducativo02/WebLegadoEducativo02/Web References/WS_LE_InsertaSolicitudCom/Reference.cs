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

namespace WebLegadoEducativo02.WS_LE_InsertaSolicitudCom {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="WS_LE_InsertaSolicitudComSoap", Namespace="http://tempuri.org/")]
    public partial class WS_LE_InsertaSolicitudCom : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback InsSolicitudCompraOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public WS_LE_InsertaSolicitudCom() {
            this.Url = global::WebLegadoEducativo02.Properties.Settings.Default.WebLegadoEducativo02_WS_LE_InsertaSolicitudCom_WS_LE_InsertaSolicitudCom;
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
        public event InsSolicitudCompraCompletedEventHandler InsSolicitudCompraCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/InsSolicitudCompra", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public Respuesta InsSolicitudCompra(string opportunityid, string udem_titular, string udem_titulardesignado, string udem_matriculadondeseguardaeldinero, string udem_plazoadevengar, string udem_requiererecibofiscal, string udem_datosfiscales, string udem_formadepago, string udem_documentosentregadostitular, string udem_documentosentregadostitulardesignado, string udem_documentosentregadosbeneficiarios) {
            object[] results = this.Invoke("InsSolicitudCompra", new object[] {
                        opportunityid,
                        udem_titular,
                        udem_titulardesignado,
                        udem_matriculadondeseguardaeldinero,
                        udem_plazoadevengar,
                        udem_requiererecibofiscal,
                        udem_datosfiscales,
                        udem_formadepago,
                        udem_documentosentregadostitular,
                        udem_documentosentregadostitulardesignado,
                        udem_documentosentregadosbeneficiarios});
            return ((Respuesta)(results[0]));
        }
        
        /// <remarks/>
        public void InsSolicitudCompraAsync(string opportunityid, string udem_titular, string udem_titulardesignado, string udem_matriculadondeseguardaeldinero, string udem_plazoadevengar, string udem_requiererecibofiscal, string udem_datosfiscales, string udem_formadepago, string udem_documentosentregadostitular, string udem_documentosentregadostitulardesignado, string udem_documentosentregadosbeneficiarios) {
            this.InsSolicitudCompraAsync(opportunityid, udem_titular, udem_titulardesignado, udem_matriculadondeseguardaeldinero, udem_plazoadevengar, udem_requiererecibofiscal, udem_datosfiscales, udem_formadepago, udem_documentosentregadostitular, udem_documentosentregadostitulardesignado, udem_documentosentregadosbeneficiarios, null);
        }
        
        /// <remarks/>
        public void InsSolicitudCompraAsync(string opportunityid, string udem_titular, string udem_titulardesignado, string udem_matriculadondeseguardaeldinero, string udem_plazoadevengar, string udem_requiererecibofiscal, string udem_datosfiscales, string udem_formadepago, string udem_documentosentregadostitular, string udem_documentosentregadostitulardesignado, string udem_documentosentregadosbeneficiarios, object userState) {
            if ((this.InsSolicitudCompraOperationCompleted == null)) {
                this.InsSolicitudCompraOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInsSolicitudCompraOperationCompleted);
            }
            this.InvokeAsync("InsSolicitudCompra", new object[] {
                        opportunityid,
                        udem_titular,
                        udem_titulardesignado,
                        udem_matriculadondeseguardaeldinero,
                        udem_plazoadevengar,
                        udem_requiererecibofiscal,
                        udem_datosfiscales,
                        udem_formadepago,
                        udem_documentosentregadostitular,
                        udem_documentosentregadostitulardesignado,
                        udem_documentosentregadosbeneficiarios}, this.InsSolicitudCompraOperationCompleted, userState);
        }
        
        private void OnInsSolicitudCompraOperationCompleted(object arg) {
            if ((this.InsSolicitudCompraCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InsSolicitudCompraCompleted(this, new InsSolicitudCompraCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    public partial class Respuesta {
        
        private string codigoMsField;
        
        private string mensajeField;
        
        private string guidField;
        
        /// <remarks/>
        public string CodigoMs {
            get {
                return this.codigoMsField;
            }
            set {
                this.codigoMsField = value;
            }
        }
        
        /// <remarks/>
        public string Mensaje {
            get {
                return this.mensajeField;
            }
            set {
                this.mensajeField = value;
            }
        }
        
        /// <remarks/>
        public string Guid {
            get {
                return this.guidField;
            }
            set {
                this.guidField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void InsSolicitudCompraCompletedEventHandler(object sender, InsSolicitudCompraCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InsSolicitudCompraCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InsSolicitudCompraCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public Respuesta Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((Respuesta)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591