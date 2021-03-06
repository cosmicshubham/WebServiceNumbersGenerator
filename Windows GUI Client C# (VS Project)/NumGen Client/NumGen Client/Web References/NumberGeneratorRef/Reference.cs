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

namespace NumGen_Client.NumberGeneratorRef {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="NumberGeneratorServiceSoap", Namespace="NS_NumGen")]
    public partial class NumberGeneratorService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback primeRangeOperationCompleted;
        
        private System.Threading.SendOrPostCallback compositeRangeOperationCompleted;
        
        private System.Threading.SendOrPostCallback perfectSquaresRangeOperationCompleted;
        
        private System.Threading.SendOrPostCallback fibonacciRangeOperationCompleted;
        
        private System.Threading.SendOrPostCallback randomNumbersOperationCompleted;
        
        private System.Threading.SendOrPostCallback powersofTwoOperationCompleted;
        
        private System.Threading.SendOrPostCallback evenRangeOperationCompleted;
        
        private System.Threading.SendOrPostCallback oddRangeOperationCompleted;
        
        private System.Threading.SendOrPostCallback palindromeRangeOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public NumberGeneratorService() {
            this.Url = global::NumGen_Client.Properties.Settings.Default.NumGen_Client_com_somee_shubham_NumberGeneratorService;
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
        public event primeRangeCompletedEventHandler primeRangeCompleted;
        
        /// <remarks/>
        public event compositeRangeCompletedEventHandler compositeRangeCompleted;
        
        /// <remarks/>
        public event perfectSquaresRangeCompletedEventHandler perfectSquaresRangeCompleted;
        
        /// <remarks/>
        public event fibonacciRangeCompletedEventHandler fibonacciRangeCompleted;
        
        /// <remarks/>
        public event randomNumbersCompletedEventHandler randomNumbersCompleted;
        
        /// <remarks/>
        public event powersofTwoCompletedEventHandler powersofTwoCompleted;
        
        /// <remarks/>
        public event evenRangeCompletedEventHandler evenRangeCompleted;
        
        /// <remarks/>
        public event oddRangeCompletedEventHandler oddRangeCompleted;
        
        /// <remarks/>
        public event palindromeRangeCompletedEventHandler palindromeRangeCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/primeRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string primeRange(int low, int high) {
            object[] results = this.Invoke("primeRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void primeRangeAsync(int low, int high) {
            this.primeRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void primeRangeAsync(int low, int high, object userState) {
            if ((this.primeRangeOperationCompleted == null)) {
                this.primeRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprimeRangeOperationCompleted);
            }
            this.InvokeAsync("primeRange", new object[] {
                        low,
                        high}, this.primeRangeOperationCompleted, userState);
        }
        
        private void OnprimeRangeOperationCompleted(object arg) {
            if ((this.primeRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.primeRangeCompleted(this, new primeRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/compositeRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string compositeRange(int low, int high) {
            object[] results = this.Invoke("compositeRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void compositeRangeAsync(int low, int high) {
            this.compositeRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void compositeRangeAsync(int low, int high, object userState) {
            if ((this.compositeRangeOperationCompleted == null)) {
                this.compositeRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OncompositeRangeOperationCompleted);
            }
            this.InvokeAsync("compositeRange", new object[] {
                        low,
                        high}, this.compositeRangeOperationCompleted, userState);
        }
        
        private void OncompositeRangeOperationCompleted(object arg) {
            if ((this.compositeRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.compositeRangeCompleted(this, new compositeRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/perfectSquaresRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string perfectSquaresRange(int low, int high) {
            object[] results = this.Invoke("perfectSquaresRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void perfectSquaresRangeAsync(int low, int high) {
            this.perfectSquaresRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void perfectSquaresRangeAsync(int low, int high, object userState) {
            if ((this.perfectSquaresRangeOperationCompleted == null)) {
                this.perfectSquaresRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnperfectSquaresRangeOperationCompleted);
            }
            this.InvokeAsync("perfectSquaresRange", new object[] {
                        low,
                        high}, this.perfectSquaresRangeOperationCompleted, userState);
        }
        
        private void OnperfectSquaresRangeOperationCompleted(object arg) {
            if ((this.perfectSquaresRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.perfectSquaresRangeCompleted(this, new perfectSquaresRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/fibonacciRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string fibonacciRange(int low, int high) {
            object[] results = this.Invoke("fibonacciRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void fibonacciRangeAsync(int low, int high) {
            this.fibonacciRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void fibonacciRangeAsync(int low, int high, object userState) {
            if ((this.fibonacciRangeOperationCompleted == null)) {
                this.fibonacciRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfibonacciRangeOperationCompleted);
            }
            this.InvokeAsync("fibonacciRange", new object[] {
                        low,
                        high}, this.fibonacciRangeOperationCompleted, userState);
        }
        
        private void OnfibonacciRangeOperationCompleted(object arg) {
            if ((this.fibonacciRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.fibonacciRangeCompleted(this, new fibonacciRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/randomNumbers", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string randomNumbers(int low, int high, int n) {
            object[] results = this.Invoke("randomNumbers", new object[] {
                        low,
                        high,
                        n});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void randomNumbersAsync(int low, int high, int n) {
            this.randomNumbersAsync(low, high, n, null);
        }
        
        /// <remarks/>
        public void randomNumbersAsync(int low, int high, int n, object userState) {
            if ((this.randomNumbersOperationCompleted == null)) {
                this.randomNumbersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnrandomNumbersOperationCompleted);
            }
            this.InvokeAsync("randomNumbers", new object[] {
                        low,
                        high,
                        n}, this.randomNumbersOperationCompleted, userState);
        }
        
        private void OnrandomNumbersOperationCompleted(object arg) {
            if ((this.randomNumbersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.randomNumbersCompleted(this, new randomNumbersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/powersofTwo", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string powersofTwo(int low, int high) {
            object[] results = this.Invoke("powersofTwo", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void powersofTwoAsync(int low, int high) {
            this.powersofTwoAsync(low, high, null);
        }
        
        /// <remarks/>
        public void powersofTwoAsync(int low, int high, object userState) {
            if ((this.powersofTwoOperationCompleted == null)) {
                this.powersofTwoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpowersofTwoOperationCompleted);
            }
            this.InvokeAsync("powersofTwo", new object[] {
                        low,
                        high}, this.powersofTwoOperationCompleted, userState);
        }
        
        private void OnpowersofTwoOperationCompleted(object arg) {
            if ((this.powersofTwoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.powersofTwoCompleted(this, new powersofTwoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/evenRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string evenRange(int low, int high) {
            object[] results = this.Invoke("evenRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void evenRangeAsync(int low, int high) {
            this.evenRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void evenRangeAsync(int low, int high, object userState) {
            if ((this.evenRangeOperationCompleted == null)) {
                this.evenRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnevenRangeOperationCompleted);
            }
            this.InvokeAsync("evenRange", new object[] {
                        low,
                        high}, this.evenRangeOperationCompleted, userState);
        }
        
        private void OnevenRangeOperationCompleted(object arg) {
            if ((this.evenRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.evenRangeCompleted(this, new evenRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/oddRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string oddRange(int low, int high) {
            object[] results = this.Invoke("oddRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void oddRangeAsync(int low, int high) {
            this.oddRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void oddRangeAsync(int low, int high, object userState) {
            if ((this.oddRangeOperationCompleted == null)) {
                this.oddRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnoddRangeOperationCompleted);
            }
            this.InvokeAsync("oddRange", new object[] {
                        low,
                        high}, this.oddRangeOperationCompleted, userState);
        }
        
        private void OnoddRangeOperationCompleted(object arg) {
            if ((this.oddRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.oddRangeCompleted(this, new oddRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("NS_NumGen/palindromeRange", RequestNamespace="NS_NumGen", ResponseNamespace="NS_NumGen", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string palindromeRange(int low, int high) {
            object[] results = this.Invoke("palindromeRange", new object[] {
                        low,
                        high});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void palindromeRangeAsync(int low, int high) {
            this.palindromeRangeAsync(low, high, null);
        }
        
        /// <remarks/>
        public void palindromeRangeAsync(int low, int high, object userState) {
            if ((this.palindromeRangeOperationCompleted == null)) {
                this.palindromeRangeOperationCompleted = new System.Threading.SendOrPostCallback(this.OnpalindromeRangeOperationCompleted);
            }
            this.InvokeAsync("palindromeRange", new object[] {
                        low,
                        high}, this.palindromeRangeOperationCompleted, userState);
        }
        
        private void OnpalindromeRangeOperationCompleted(object arg) {
            if ((this.palindromeRangeCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.palindromeRangeCompleted(this, new palindromeRangeCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void primeRangeCompletedEventHandler(object sender, primeRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class primeRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal primeRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void compositeRangeCompletedEventHandler(object sender, compositeRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class compositeRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal compositeRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void perfectSquaresRangeCompletedEventHandler(object sender, perfectSquaresRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class perfectSquaresRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal perfectSquaresRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void fibonacciRangeCompletedEventHandler(object sender, fibonacciRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class fibonacciRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal fibonacciRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void randomNumbersCompletedEventHandler(object sender, randomNumbersCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class randomNumbersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal randomNumbersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void powersofTwoCompletedEventHandler(object sender, powersofTwoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class powersofTwoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal powersofTwoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void evenRangeCompletedEventHandler(object sender, evenRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class evenRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal evenRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void oddRangeCompletedEventHandler(object sender, oddRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class oddRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal oddRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    public delegate void palindromeRangeCompletedEventHandler(object sender, palindromeRangeCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.2046.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class palindromeRangeCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal palindromeRangeCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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