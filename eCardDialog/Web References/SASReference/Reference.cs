﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Der Quellcode wurde automatisch mit Microsoft.VSDesigner generiert. Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace eCardDialog.SASReference {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="sas_12Binding", Namespace="http://soap.sas.client.chipkarte.at")]
    public partial class SasService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback adressdatenAbfragenOperationCompleted;
        
        private System.Threading.SendOrPostCallback checkStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback patientendatenAbfragenOperationCompleted;
        
        private System.Threading.SendOrPostCallback svNummerAbfragenOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public SasService() {
            this.Url = global::eCardDialog.Properties.Settings.Default.eCardDialog_SASReference_SasService;
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
        public event adressdatenAbfragenCompletedEventHandler adressdatenAbfragenCompleted;
        
        /// <remarks/>
        public event checkStatusCompletedEventHandler checkStatusCompleted;
        
        /// <remarks/>
        public event patientendatenAbfragenCompletedEventHandler patientendatenAbfragenCompleted;
        
        /// <remarks/>
        public event svNummerAbfragenCompletedEventHandler svNummerAbfragenCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.sas.client.chipkarte.at", ResponseNamespace="http://soap.sas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public adressdaten adressdatenAbfragen(string dialogId, string svNummer) {
            object[] results = this.Invoke("adressdatenAbfragen", new object[] {
                        dialogId,
                        svNummer});
            return ((adressdaten)(results[0]));
        }
        
        /// <remarks/>
        public void adressdatenAbfragenAsync(string dialogId, string svNummer) {
            this.adressdatenAbfragenAsync(dialogId, svNummer, null);
        }
        
        /// <remarks/>
        public void adressdatenAbfragenAsync(string dialogId, string svNummer, object userState) {
            if ((this.adressdatenAbfragenOperationCompleted == null)) {
                this.adressdatenAbfragenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnadressdatenAbfragenOperationCompleted);
            }
            this.InvokeAsync("adressdatenAbfragen", new object[] {
                        dialogId,
                        svNummer}, this.adressdatenAbfragenOperationCompleted, userState);
        }
        
        private void OnadressdatenAbfragenOperationCompleted(object arg) {
            if ((this.adressdatenAbfragenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.adressdatenAbfragenCompleted(this, new adressdatenAbfragenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.sas.client.chipkarte.at", ResponseNamespace="http://soap.sas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return", IsNullable=true)]
        public property[] checkStatus(string dialogId) {
            object[] results = this.Invoke("checkStatus", new object[] {
                        dialogId});
            return ((property[])(results[0]));
        }
        
        /// <remarks/>
        public void checkStatusAsync(string dialogId) {
            this.checkStatusAsync(dialogId, null);
        }
        
        /// <remarks/>
        public void checkStatusAsync(string dialogId, object userState) {
            if ((this.checkStatusOperationCompleted == null)) {
                this.checkStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OncheckStatusOperationCompleted);
            }
            this.InvokeAsync("checkStatus", new object[] {
                        dialogId}, this.checkStatusOperationCompleted, userState);
        }
        
        private void OncheckStatusOperationCompleted(object arg) {
            if ((this.checkStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.checkStatusCompleted(this, new checkStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.sas.client.chipkarte.at", ResponseNamespace="http://soap.sas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public abfrageErgebnis patientendatenAbfragen(string dialogId, string svNummer) {
            object[] results = this.Invoke("patientendatenAbfragen", new object[] {
                        dialogId,
                        svNummer});
            return ((abfrageErgebnis)(results[0]));
        }
        
        /// <remarks/>
        public void patientendatenAbfragenAsync(string dialogId, string svNummer) {
            this.patientendatenAbfragenAsync(dialogId, svNummer, null);
        }
        
        /// <remarks/>
        public void patientendatenAbfragenAsync(string dialogId, string svNummer, object userState) {
            if ((this.patientendatenAbfragenOperationCompleted == null)) {
                this.patientendatenAbfragenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpatientendatenAbfragenOperationCompleted);
            }
            this.InvokeAsync("patientendatenAbfragen", new object[] {
                        dialogId,
                        svNummer}, this.patientendatenAbfragenOperationCompleted, userState);
        }
        
        private void OnpatientendatenAbfragenOperationCompleted(object arg) {
            if ((this.patientendatenAbfragenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.patientendatenAbfragenCompleted(this, new patientendatenAbfragenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.sas.client.chipkarte.at", ResponseNamespace="http://soap.sas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public abfrageErgebnis svNummerAbfragen(string dialogId, suchkriterien svNummerAbfragenSuchkriterien) {
            object[] results = this.Invoke("svNummerAbfragen", new object[] {
                        dialogId,
                        svNummerAbfragenSuchkriterien});
            return ((abfrageErgebnis)(results[0]));
        }
        
        /// <remarks/>
        public void svNummerAbfragenAsync(string dialogId, suchkriterien svNummerAbfragenSuchkriterien) {
            this.svNummerAbfragenAsync(dialogId, svNummerAbfragenSuchkriterien, null);
        }
        
        /// <remarks/>
        public void svNummerAbfragenAsync(string dialogId, suchkriterien svNummerAbfragenSuchkriterien, object userState) {
            if ((this.svNummerAbfragenOperationCompleted == null)) {
                this.svNummerAbfragenOperationCompleted = new System.Threading.SendOrPostCallback(this.OnsvNummerAbfragenOperationCompleted);
            }
            this.InvokeAsync("svNummerAbfragen", new object[] {
                        dialogId,
                        svNummerAbfragenSuchkriterien}, this.svNummerAbfragenOperationCompleted, userState);
        }
        
        private void OnsvNummerAbfragenOperationCompleted(object arg) {
            if ((this.svNummerAbfragenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.svNummerAbfragenCompleted(this, new svNummerAbfragenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sas.client.chipkarte.at")]
    public partial class adressdaten {
        
        private string abgabestelleField;
        
        private string anschriftszusatzField;
        
        private string hausnummerField;
        
        private string ortField;
        
        private string plzField;
        
        private string postfachNummerField;
        
        private string postfachTextField;
        
        private string staatscodeField;
        
        private string stockTuerNummerField;
        
        private string strasseField;
        
        /// <remarks/>
        public string abgabestelle {
            get {
                return this.abgabestelleField;
            }
            set {
                this.abgabestelleField = value;
            }
        }
        
        /// <remarks/>
        public string anschriftszusatz {
            get {
                return this.anschriftszusatzField;
            }
            set {
                this.anschriftszusatzField = value;
            }
        }
        
        /// <remarks/>
        public string hausnummer {
            get {
                return this.hausnummerField;
            }
            set {
                this.hausnummerField = value;
            }
        }
        
        /// <remarks/>
        public string ort {
            get {
                return this.ortField;
            }
            set {
                this.ortField = value;
            }
        }
        
        /// <remarks/>
        public string plz {
            get {
                return this.plzField;
            }
            set {
                this.plzField = value;
            }
        }
        
        /// <remarks/>
        public string postfachNummer {
            get {
                return this.postfachNummerField;
            }
            set {
                this.postfachNummerField = value;
            }
        }
        
        /// <remarks/>
        public string postfachText {
            get {
                return this.postfachTextField;
            }
            set {
                this.postfachTextField = value;
            }
        }
        
        /// <remarks/>
        public string staatscode {
            get {
                return this.staatscodeField;
            }
            set {
                this.staatscodeField = value;
            }
        }
        
        /// <remarks/>
        public string stockTuerNummer {
            get {
                return this.stockTuerNummerField;
            }
            set {
                this.stockTuerNummerField = value;
            }
        }
        
        /// <remarks/>
        public string strasse {
            get {
                return this.strasseField;
            }
            set {
                this.strasseField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sas.client.chipkarte.at")]
    public partial class suchkriterien {
        
        private string familiennameField;
        
        private string geburtsdatumField;
        
        private string vornameField;
        
        /// <remarks/>
        public string familienname {
            get {
                return this.familiennameField;
            }
            set {
                this.familiennameField = value;
            }
        }
        
        /// <remarks/>
        public string geburtsdatum {
            get {
                return this.geburtsdatumField;
            }
            set {
                this.geburtsdatumField = value;
            }
        }
        
        /// <remarks/>
        public string vorname {
            get {
                return this.vornameField;
            }
            set {
                this.vornameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.sas.client.chipkarte.at")]
    public partial class abfrageErgebnis {
        
        private string druckFamiliennameField;
        
        private string druckVornameField;
        
        private string familiennameField;
        
        private string geburtsdatumField;
        
        private string svNummerField;
        
        private string todesdatumField;
        
        private string todesdatumBestaetigtKZField;
        
        private string vornameField;
        
        /// <remarks/>
        public string druckFamilienname {
            get {
                return this.druckFamiliennameField;
            }
            set {
                this.druckFamiliennameField = value;
            }
        }
        
        /// <remarks/>
        public string druckVorname {
            get {
                return this.druckVornameField;
            }
            set {
                this.druckVornameField = value;
            }
        }
        
        /// <remarks/>
        public string familienname {
            get {
                return this.familiennameField;
            }
            set {
                this.familiennameField = value;
            }
        }
        
        /// <remarks/>
        public string geburtsdatum {
            get {
                return this.geburtsdatumField;
            }
            set {
                this.geburtsdatumField = value;
            }
        }
        
        /// <remarks/>
        public string svNummer {
            get {
                return this.svNummerField;
            }
            set {
                this.svNummerField = value;
            }
        }
        
        /// <remarks/>
        public string todesdatum {
            get {
                return this.todesdatumField;
            }
            set {
                this.todesdatumField = value;
            }
        }
        
        /// <remarks/>
        public string todesdatumBestaetigtKZ {
            get {
                return this.todesdatumBestaetigtKZField;
            }
            set {
                this.todesdatumBestaetigtKZField = value;
            }
        }
        
        /// <remarks/>
        public string vorname {
            get {
                return this.vornameField;
            }
            set {
                this.vornameField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.base.client.chipkarte.at")]
    public partial class property {
        
        private string keyField;
        
        private string valueField;
        
        /// <remarks/>
        public string key {
            get {
                return this.keyField;
            }
            set {
                this.keyField = value;
            }
        }
        
        /// <remarks/>
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void adressdatenAbfragenCompletedEventHandler(object sender, adressdatenAbfragenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class adressdatenAbfragenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal adressdatenAbfragenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public adressdaten Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((adressdaten)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void checkStatusCompletedEventHandler(object sender, checkStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class checkStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal checkStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public property[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((property[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void patientendatenAbfragenCompletedEventHandler(object sender, patientendatenAbfragenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class patientendatenAbfragenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal patientendatenAbfragenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public abfrageErgebnis Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((abfrageErgebnis)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void svNummerAbfragenCompletedEventHandler(object sender, svNummerAbfragenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class svNummerAbfragenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal svNummerAbfragenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public abfrageErgebnis Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((abfrageErgebnis)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591