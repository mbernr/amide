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

namespace eCardDialog.VDASRef {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="vdas_14Binding", Namespace="http://soap.vdas.client.chipkarte.at")]
    public partial class VdasService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback checkStatusOperationCompleted;
        
        private System.Threading.SendOrPostCallback getVersichertenDatenOperationCompleted;
        
        private System.Threading.SendOrPostCallback retrieveVersichertendatenPerStichtagOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public VdasService() {
            this.Url = global::eCardDialog.Properties.Settings.Default.eCardDialog_VDASRef_VdasService;
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
        public event checkStatusCompletedEventHandler checkStatusCompleted;
        
        /// <remarks/>
        public event getVersichertenDatenCompletedEventHandler getVersichertenDatenCompleted;
        
        /// <remarks/>
        public event retrieveVersichertendatenPerStichtagCompletedEventHandler retrieveVersichertendatenPerStichtagCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.vdas.client.chipkarte.at", ResponseNamespace="http://soap.vdas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
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
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.vdas.client.chipkarte.at", ResponseNamespace="http://soap.vdas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public versichertendatenAbfrageErgebnis getVersichertenDaten(string dialogId, versichertendatenAbfrage suchKriterien, string cardReaderId) {
            object[] results = this.Invoke("getVersichertenDaten", new object[] {
                        dialogId,
                        suchKriterien,
                        cardReaderId});
            return ((versichertendatenAbfrageErgebnis)(results[0]));
        }
        
        /// <remarks/>
        public void getVersichertenDatenAsync(string dialogId, versichertendatenAbfrage suchKriterien, string cardReaderId) {
            this.getVersichertenDatenAsync(dialogId, suchKriterien, cardReaderId, null);
        }
        
        /// <remarks/>
        public void getVersichertenDatenAsync(string dialogId, versichertendatenAbfrage suchKriterien, string cardReaderId, object userState) {
            if ((this.getVersichertenDatenOperationCompleted == null)) {
                this.getVersichertenDatenOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetVersichertenDatenOperationCompleted);
            }
            this.InvokeAsync("getVersichertenDaten", new object[] {
                        dialogId,
                        suchKriterien,
                        cardReaderId}, this.getVersichertenDatenOperationCompleted, userState);
        }
        
        private void OngetVersichertenDatenOperationCompleted(object arg) {
            if ((this.getVersichertenDatenCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getVersichertenDatenCompleted(this, new getVersichertenDatenCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("", RequestNamespace="http://soap.vdas.client.chipkarte.at", ResponseNamespace="http://soap.vdas.client.chipkarte.at", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute("return")]
        public versichertendatenAbfrageErgebnis retrieveVersichertendatenPerStichtag(string dialogId, versichertendatenAbfragePerStichtag suchKriterien, string cardReaderId) {
            object[] results = this.Invoke("retrieveVersichertendatenPerStichtag", new object[] {
                        dialogId,
                        suchKriterien,
                        cardReaderId});
            return ((versichertendatenAbfrageErgebnis)(results[0]));
        }
        
        /// <remarks/>
        public void retrieveVersichertendatenPerStichtagAsync(string dialogId, versichertendatenAbfragePerStichtag suchKriterien, string cardReaderId) {
            this.retrieveVersichertendatenPerStichtagAsync(dialogId, suchKriterien, cardReaderId, null);
        }
        
        /// <remarks/>
        public void retrieveVersichertendatenPerStichtagAsync(string dialogId, versichertendatenAbfragePerStichtag suchKriterien, string cardReaderId, object userState) {
            if ((this.retrieveVersichertendatenPerStichtagOperationCompleted == null)) {
                this.retrieveVersichertendatenPerStichtagOperationCompleted = new System.Threading.SendOrPostCallback(this.OnretrieveVersichertendatenPerStichtagOperationCompleted);
            }
            this.InvokeAsync("retrieveVersichertendatenPerStichtag", new object[] {
                        dialogId,
                        suchKriterien,
                        cardReaderId}, this.retrieveVersichertendatenPerStichtagOperationCompleted, userState);
        }
        
        private void OnretrieveVersichertendatenPerStichtagOperationCompleted(object arg) {
            if ((this.retrieveVersichertendatenPerStichtagCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.retrieveVersichertendatenPerStichtagCompleted(this, new retrieveVersichertendatenPerStichtagCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.vdas.client.chipkarte.at")]
    public partial class versichertendatenSvPerson {
        
        private string druckNachnameField;
        
        private string druckTitelHintenField;
        
        private string druckTitelVorneField;
        
        private string druckVornameField;
        
        private string geburtsdatumField;
        
        private string geschlechtField;
        
        private string nachnameField;
        
        private string svNummerField;
        
        private string titelHintenField;
        
        private string titelVorneField;
        
        private string todesdatumField;
        
        private string todesdatumBestaetigtField;
        
        private string vornameField;
        
        /// <remarks/>
        public string druckNachname {
            get {
                return this.druckNachnameField;
            }
            set {
                this.druckNachnameField = value;
            }
        }
        
        /// <remarks/>
        public string druckTitelHinten {
            get {
                return this.druckTitelHintenField;
            }
            set {
                this.druckTitelHintenField = value;
            }
        }
        
        /// <remarks/>
        public string druckTitelVorne {
            get {
                return this.druckTitelVorneField;
            }
            set {
                this.druckTitelVorneField = value;
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
        public string geburtsdatum {
            get {
                return this.geburtsdatumField;
            }
            set {
                this.geburtsdatumField = value;
            }
        }
        
        /// <remarks/>
        public string geschlecht {
            get {
                return this.geschlechtField;
            }
            set {
                this.geschlechtField = value;
            }
        }
        
        /// <remarks/>
        public string nachname {
            get {
                return this.nachnameField;
            }
            set {
                this.nachnameField = value;
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
        public string titelHinten {
            get {
                return this.titelHintenField;
            }
            set {
                this.titelHintenField = value;
            }
        }
        
        /// <remarks/>
        public string titelVorne {
            get {
                return this.titelVorneField;
            }
            set {
                this.titelVorneField = value;
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
        public string todesdatumBestaetigt {
            get {
                return this.todesdatumBestaetigtField;
            }
            set {
                this.todesdatumBestaetigtField = value;
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
    public partial class svPersonV2 {
        
        private string druckNachnameField;
        
        private string druckTitelHintenField;
        
        private string druckTitelVorneField;
        
        private string druckVornameField;
        
        private string geburtsdatumField;
        
        private string geschlechtField;
        
        private string nachnameField;
        
        private string svNummerField;
        
        private string titelHintenField;
        
        private string titelVorneField;
        
        private string vornameField;
        
        /// <remarks/>
        public string druckNachname {
            get {
                return this.druckNachnameField;
            }
            set {
                this.druckNachnameField = value;
            }
        }
        
        /// <remarks/>
        public string druckTitelHinten {
            get {
                return this.druckTitelHintenField;
            }
            set {
                this.druckTitelHintenField = value;
            }
        }
        
        /// <remarks/>
        public string druckTitelVorne {
            get {
                return this.druckTitelVorneField;
            }
            set {
                this.druckTitelVorneField = value;
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
        public string geburtsdatum {
            get {
                return this.geburtsdatumField;
            }
            set {
                this.geburtsdatumField = value;
            }
        }
        
        /// <remarks/>
        public string geschlecht {
            get {
                return this.geschlechtField;
            }
            set {
                this.geschlechtField = value;
            }
        }
        
        /// <remarks/>
        public string nachname {
            get {
                return this.nachnameField;
            }
            set {
                this.nachnameField = value;
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
        public string titelHinten {
            get {
                return this.titelHintenField;
            }
            set {
                this.titelHintenField = value;
            }
        }
        
        /// <remarks/>
        public string titelVorne {
            get {
                return this.titelVorneField;
            }
            set {
                this.titelVorneField = value;
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
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.vdas.client.chipkarte.at")]
    public partial class anspruchsdaten {
        
        private svPersonV2 abgeleiteteDatenField;
        
        private string anspruchsartField;
        
        private bool kostenanteilbefreitField;
        
        private bool kostenanteilbefreitFieldSpecified;
        
        private bool rezeptgebbefreitField;
        
        private bool rezeptgebbefreitFieldSpecified;
        
        private string svtCodeField;
        
        private string versichertenKategorieField;
        
        private string versichertenartCodeField;
        
        /// <remarks/>
        public svPersonV2 abgeleiteteDaten {
            get {
                return this.abgeleiteteDatenField;
            }
            set {
                this.abgeleiteteDatenField = value;
            }
        }
        
        /// <remarks/>
        public string anspruchsart {
            get {
                return this.anspruchsartField;
            }
            set {
                this.anspruchsartField = value;
            }
        }
        
        /// <remarks/>
        public bool kostenanteilbefreit {
            get {
                return this.kostenanteilbefreitField;
            }
            set {
                this.kostenanteilbefreitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool kostenanteilbefreitSpecified {
            get {
                return this.kostenanteilbefreitFieldSpecified;
            }
            set {
                this.kostenanteilbefreitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public bool rezeptgebbefreit {
            get {
                return this.rezeptgebbefreitField;
            }
            set {
                this.rezeptgebbefreitField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rezeptgebbefreitSpecified {
            get {
                return this.rezeptgebbefreitFieldSpecified;
            }
            set {
                this.rezeptgebbefreitFieldSpecified = value;
            }
        }
        
        /// <remarks/>
        public string svtCode {
            get {
                return this.svtCodeField;
            }
            set {
                this.svtCodeField = value;
            }
        }
        
        /// <remarks/>
        public string versichertenKategorie {
            get {
                return this.versichertenKategorieField;
            }
            set {
                this.versichertenKategorieField = value;
            }
        }
        
        /// <remarks/>
        public string versichertenartCode {
            get {
                return this.versichertenartCodeField;
            }
            set {
                this.versichertenartCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.vdas.client.chipkarte.at")]
    public partial class versichertendatenAbfrageErgebnis {
        
        private anspruchsdaten[] anspruchsDatenField;
        
        private string vdasIdField;
        
        private System.Nullable<int>[] vdasMessageCodesField;
        
        private versichertendatenSvPerson versichertenDatenField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("anspruchsDaten", IsNullable=true)]
        public anspruchsdaten[] anspruchsDaten {
            get {
                return this.anspruchsDatenField;
            }
            set {
                this.anspruchsDatenField = value;
            }
        }
        
        /// <remarks/>
        public string vdasId {
            get {
                return this.vdasIdField;
            }
            set {
                this.vdasIdField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("vdasMessageCodes", IsNullable=true)]
        public System.Nullable<int>[] vdasMessageCodes {
            get {
                return this.vdasMessageCodesField;
            }
            set {
                this.vdasMessageCodesField = value;
            }
        }
        
        /// <remarks/>
        public versichertendatenSvPerson versichertenDaten {
            get {
                return this.versichertenDatenField;
            }
            set {
                this.versichertenDatenField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(versichertendatenAbfragePerStichtag))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.vdas.client.chipkarte.at")]
    public partial class versichertendatenAbfrage {
        
        private string abteilungsFunktionsCodeField;
        
        private string cinField;
        
        private bool forceExecutionField;
        
        private bool forceExecutionFieldSpecified;
        
        private string svNummerField;
        
        private string svNummerAbgeleitetField;
        
        private string svtCodeField;
        
        /// <remarks/>
        public string abteilungsFunktionsCode {
            get {
                return this.abteilungsFunktionsCodeField;
            }
            set {
                this.abteilungsFunktionsCodeField = value;
            }
        }
        
        /// <remarks/>
        public string cin {
            get {
                return this.cinField;
            }
            set {
                this.cinField = value;
            }
        }
        
        /// <remarks/>
        public bool forceExecution {
            get {
                return this.forceExecutionField;
            }
            set {
                this.forceExecutionField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool forceExecutionSpecified {
            get {
                return this.forceExecutionFieldSpecified;
            }
            set {
                this.forceExecutionFieldSpecified = value;
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
        public string svNummerAbgeleitet {
            get {
                return this.svNummerAbgeleitetField;
            }
            set {
                this.svNummerAbgeleitetField = value;
            }
        }
        
        /// <remarks/>
        public string svtCode {
            get {
                return this.svtCodeField;
            }
            set {
                this.svtCodeField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.1067.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://soap.vdas.client.chipkarte.at")]
    public partial class versichertendatenAbfragePerStichtag : versichertendatenAbfrage {
        
        private string stichtagsdatumField;
        
        /// <remarks/>
        public string stichtagsdatum {
            get {
                return this.stichtagsdatumField;
            }
            set {
                this.stichtagsdatumField = value;
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
    public delegate void getVersichertenDatenCompletedEventHandler(object sender, getVersichertenDatenCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getVersichertenDatenCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getVersichertenDatenCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public versichertendatenAbfrageErgebnis Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((versichertendatenAbfrageErgebnis)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    public delegate void retrieveVersichertendatenPerStichtagCompletedEventHandler(object sender, retrieveVersichertendatenPerStichtagCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1055.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class retrieveVersichertendatenPerStichtagCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal retrieveVersichertendatenPerStichtagCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public versichertendatenAbfrageErgebnis Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((versichertendatenAbfrageErgebnis)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591