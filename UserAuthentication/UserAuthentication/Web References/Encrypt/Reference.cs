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

namespace UserAuthentication.Encrypt {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="EncryptSoap", Namespace="http://tempuri.org/")]
    public partial class Encrypt : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback EncryptCorpusOperationCompleted;
        
        private System.Threading.SendOrPostCallback DecryptCorpusOperationCompleted;
        
        private System.Threading.SendOrPostCallback EncryptWithPassphraseOperationCompleted;
        
        private System.Threading.SendOrPostCallback DecryptWithPassphraseOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public Encrypt() {
            this.Url = global::UserAuthentication.Properties.Settings.Default.UserAuthentication_Encrypt_Encrypt;
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
        public event EncryptCorpusCompletedEventHandler EncryptCorpusCompleted;
        
        /// <remarks/>
        public event DecryptCorpusCompletedEventHandler DecryptCorpusCompleted;
        
        /// <remarks/>
        public event EncryptWithPassphraseCompletedEventHandler EncryptWithPassphraseCompleted;
        
        /// <remarks/>
        public event DecryptWithPassphraseCompletedEventHandler DecryptWithPassphraseCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EncryptCorpus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string EncryptCorpus(string password) {
            object[] results = this.Invoke("EncryptCorpus", new object[] {
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EncryptCorpusAsync(string password) {
            this.EncryptCorpusAsync(password, null);
        }
        
        /// <remarks/>
        public void EncryptCorpusAsync(string password, object userState) {
            if ((this.EncryptCorpusOperationCompleted == null)) {
                this.EncryptCorpusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEncryptCorpusOperationCompleted);
            }
            this.InvokeAsync("EncryptCorpus", new object[] {
                        password}, this.EncryptCorpusOperationCompleted, userState);
        }
        
        private void OnEncryptCorpusOperationCompleted(object arg) {
            if ((this.EncryptCorpusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EncryptCorpusCompleted(this, new EncryptCorpusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DecryptCorpus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DecryptCorpus(string password) {
            object[] results = this.Invoke("DecryptCorpus", new object[] {
                        password});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DecryptCorpusAsync(string password) {
            this.DecryptCorpusAsync(password, null);
        }
        
        /// <remarks/>
        public void DecryptCorpusAsync(string password, object userState) {
            if ((this.DecryptCorpusOperationCompleted == null)) {
                this.DecryptCorpusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDecryptCorpusOperationCompleted);
            }
            this.InvokeAsync("DecryptCorpus", new object[] {
                        password}, this.DecryptCorpusOperationCompleted, userState);
        }
        
        private void OnDecryptCorpusOperationCompleted(object arg) {
            if ((this.DecryptCorpusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DecryptCorpusCompleted(this, new DecryptCorpusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/EncryptWithPassphrase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string EncryptWithPassphrase(string password, string passphrase) {
            object[] results = this.Invoke("EncryptWithPassphrase", new object[] {
                        password,
                        passphrase});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void EncryptWithPassphraseAsync(string password, string passphrase) {
            this.EncryptWithPassphraseAsync(password, passphrase, null);
        }
        
        /// <remarks/>
        public void EncryptWithPassphraseAsync(string password, string passphrase, object userState) {
            if ((this.EncryptWithPassphraseOperationCompleted == null)) {
                this.EncryptWithPassphraseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnEncryptWithPassphraseOperationCompleted);
            }
            this.InvokeAsync("EncryptWithPassphrase", new object[] {
                        password,
                        passphrase}, this.EncryptWithPassphraseOperationCompleted, userState);
        }
        
        private void OnEncryptWithPassphraseOperationCompleted(object arg) {
            if ((this.EncryptWithPassphraseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.EncryptWithPassphraseCompleted(this, new EncryptWithPassphraseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DecryptWithPassphrase", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string DecryptWithPassphrase(string password, string passphrase) {
            object[] results = this.Invoke("DecryptWithPassphrase", new object[] {
                        password,
                        passphrase});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void DecryptWithPassphraseAsync(string password, string passphrase) {
            this.DecryptWithPassphraseAsync(password, passphrase, null);
        }
        
        /// <remarks/>
        public void DecryptWithPassphraseAsync(string password, string passphrase, object userState) {
            if ((this.DecryptWithPassphraseOperationCompleted == null)) {
                this.DecryptWithPassphraseOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDecryptWithPassphraseOperationCompleted);
            }
            this.InvokeAsync("DecryptWithPassphrase", new object[] {
                        password,
                        passphrase}, this.DecryptWithPassphraseOperationCompleted, userState);
        }
        
        private void OnDecryptWithPassphraseOperationCompleted(object arg) {
            if ((this.DecryptWithPassphraseCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DecryptWithPassphraseCompleted(this, new DecryptWithPassphraseCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void EncryptCorpusCompletedEventHandler(object sender, EncryptCorpusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EncryptCorpusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EncryptCorpusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void DecryptCorpusCompletedEventHandler(object sender, DecryptCorpusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DecryptCorpusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DecryptCorpusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void EncryptWithPassphraseCompletedEventHandler(object sender, EncryptWithPassphraseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class EncryptWithPassphraseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal EncryptWithPassphraseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    public delegate void DecryptWithPassphraseCompletedEventHandler(object sender, DecryptWithPassphraseCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.3752.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DecryptWithPassphraseCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DecryptWithPassphraseCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591