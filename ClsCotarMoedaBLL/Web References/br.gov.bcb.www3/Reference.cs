﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// Este código-fonte foi gerado automaticamente por Microsoft.VSDesigner, Versão 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace ClsCotarMoedaBLL.br.gov.bcb.www3 {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="FachadaWSSGSSoapBinding", Namespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
    public partial class FachadaWSSGSService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback getValoresSeriesVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUltimosValoresSerieVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback getValoresSeriesXMLOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUltimoValorVOOperationCompleted;
        
        private System.Threading.SendOrPostCallback getUltimoValorXMLOperationCompleted;
        
        private System.Threading.SendOrPostCallback getValorOperationCompleted;
        
        private System.Threading.SendOrPostCallback getValorEspecialOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public FachadaWSSGSService() {
            this.Url = global::ClsCotarMoedaBLL.Properties.Settings.Default.ClsCotarMoedaBLL_br_gov_bcb_www3_FachadaWSSGSService;
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
        public event getValoresSeriesVOCompletedEventHandler getValoresSeriesVOCompleted;
        
        /// <remarks/>
        public event getUltimosValoresSerieVOCompletedEventHandler getUltimosValoresSerieVOCompleted;
        
        /// <remarks/>
        public event getValoresSeriesXMLCompletedEventHandler getValoresSeriesXMLCompleted;
        
        /// <remarks/>
        public event getUltimoValorVOCompletedEventHandler getUltimoValorVOCompleted;
        
        /// <remarks/>
        public event getUltimoValorXMLCompletedEventHandler getUltimoValorXMLCompleted;
        
        /// <remarks/>
        public event getValorCompletedEventHandler getValorCompleted;
        
        /// <remarks/>
        public event getValorEspecialCompletedEventHandler getValorEspecialCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getValoresSeriesVOReturn")]
        public WSSerieVO[] getValoresSeriesVO(long[] in0, string in1, string in2) {
            object[] results = this.Invoke("getValoresSeriesVO", new object[] {
                        in0,
                        in1,
                        in2});
            return ((WSSerieVO[])(results[0]));
        }
        
        /// <remarks/>
        public void getValoresSeriesVOAsync(long[] in0, string in1, string in2) {
            this.getValoresSeriesVOAsync(in0, in1, in2, null);
        }
        
        /// <remarks/>
        public void getValoresSeriesVOAsync(long[] in0, string in1, string in2, object userState) {
            if ((this.getValoresSeriesVOOperationCompleted == null)) {
                this.getValoresSeriesVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetValoresSeriesVOOperationCompleted);
            }
            this.InvokeAsync("getValoresSeriesVO", new object[] {
                        in0,
                        in1,
                        in2}, this.getValoresSeriesVOOperationCompleted, userState);
        }
        
        private void OngetValoresSeriesVOOperationCompleted(object arg) {
            if ((this.getValoresSeriesVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getValoresSeriesVOCompleted(this, new getValoresSeriesVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getUltimosValoresSerieVOReturn")]
        public WSSerieVO getUltimosValoresSerieVO(long in0, long in1) {
            object[] results = this.Invoke("getUltimosValoresSerieVO", new object[] {
                        in0,
                        in1});
            return ((WSSerieVO)(results[0]));
        }
        
        /// <remarks/>
        public void getUltimosValoresSerieVOAsync(long in0, long in1) {
            this.getUltimosValoresSerieVOAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void getUltimosValoresSerieVOAsync(long in0, long in1, object userState) {
            if ((this.getUltimosValoresSerieVOOperationCompleted == null)) {
                this.getUltimosValoresSerieVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUltimosValoresSerieVOOperationCompleted);
            }
            this.InvokeAsync("getUltimosValoresSerieVO", new object[] {
                        in0,
                        in1}, this.getUltimosValoresSerieVOOperationCompleted, userState);
        }
        
        private void OngetUltimosValoresSerieVOOperationCompleted(object arg) {
            if ((this.getUltimosValoresSerieVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUltimosValoresSerieVOCompleted(this, new getUltimosValoresSerieVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getValoresSeriesXMLReturn")]
        public string getValoresSeriesXML(long[] in0, string in1, string in2) {
            object[] results = this.Invoke("getValoresSeriesXML", new object[] {
                        in0,
                        in1,
                        in2});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getValoresSeriesXMLAsync(long[] in0, string in1, string in2) {
            this.getValoresSeriesXMLAsync(in0, in1, in2, null);
        }
        
        /// <remarks/>
        public void getValoresSeriesXMLAsync(long[] in0, string in1, string in2, object userState) {
            if ((this.getValoresSeriesXMLOperationCompleted == null)) {
                this.getValoresSeriesXMLOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetValoresSeriesXMLOperationCompleted);
            }
            this.InvokeAsync("getValoresSeriesXML", new object[] {
                        in0,
                        in1,
                        in2}, this.getValoresSeriesXMLOperationCompleted, userState);
        }
        
        private void OngetValoresSeriesXMLOperationCompleted(object arg) {
            if ((this.getValoresSeriesXMLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getValoresSeriesXMLCompleted(this, new getValoresSeriesXMLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getUltimoValorVOReturn")]
        public WSSerieVO getUltimoValorVO(long in0) {
            object[] results = this.Invoke("getUltimoValorVO", new object[] {
                        in0});
            return ((WSSerieVO)(results[0]));
        }
        
        /// <remarks/>
        public void getUltimoValorVOAsync(long in0) {
            this.getUltimoValorVOAsync(in0, null);
        }
        
        /// <remarks/>
        public void getUltimoValorVOAsync(long in0, object userState) {
            if ((this.getUltimoValorVOOperationCompleted == null)) {
                this.getUltimoValorVOOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUltimoValorVOOperationCompleted);
            }
            this.InvokeAsync("getUltimoValorVO", new object[] {
                        in0}, this.getUltimoValorVOOperationCompleted, userState);
        }
        
        private void OngetUltimoValorVOOperationCompleted(object arg) {
            if ((this.getUltimoValorVOCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUltimoValorVOCompleted(this, new getUltimoValorVOCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getUltimoValorXMLReturn")]
        public string getUltimoValorXML(long in0) {
            object[] results = this.Invoke("getUltimoValorXML", new object[] {
                        in0});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void getUltimoValorXMLAsync(long in0) {
            this.getUltimoValorXMLAsync(in0, null);
        }
        
        /// <remarks/>
        public void getUltimoValorXMLAsync(long in0, object userState) {
            if ((this.getUltimoValorXMLOperationCompleted == null)) {
                this.getUltimoValorXMLOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetUltimoValorXMLOperationCompleted);
            }
            this.InvokeAsync("getUltimoValorXML", new object[] {
                        in0}, this.getUltimoValorXMLOperationCompleted, userState);
        }
        
        private void OngetUltimoValorXMLOperationCompleted(object arg) {
            if ((this.getUltimoValorXMLCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getUltimoValorXMLCompleted(this, new getUltimoValorXMLCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getValorReturn")]
        public decimal getValor(long in0, string in1) {
            object[] results = this.Invoke("getValor", new object[] {
                        in0,
                        in1});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public void getValorAsync(long in0, string in1) {
            this.getValorAsync(in0, in1, null);
        }
        
        /// <remarks/>
        public void getValorAsync(long in0, string in1, object userState) {
            if ((this.getValorOperationCompleted == null)) {
                this.getValorOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetValorOperationCompleted);
            }
            this.InvokeAsync("getValor", new object[] {
                        in0,
                        in1}, this.getValorOperationCompleted, userState);
        }
        
        private void OngetValorOperationCompleted(object arg) {
            if ((this.getValorCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getValorCompleted(this, new getValorCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapRpcMethodAttribute("", RequestNamespace="http://publico.ws.casosdeuso.sgs.pec.bcb.gov.br", ResponseNamespace="https://www3.bcb.gov.br/wssgs/services/FachadaWSSGS")]
        [return: System.Xml.Serialization.SoapElementAttribute("getValorEspecialReturn")]
        public decimal getValorEspecial(long in0, string in1, string in2) {
            object[] results = this.Invoke("getValorEspecial", new object[] {
                        in0,
                        in1,
                        in2});
            return ((decimal)(results[0]));
        }
        
        /// <remarks/>
        public void getValorEspecialAsync(long in0, string in1, string in2) {
            this.getValorEspecialAsync(in0, in1, in2, null);
        }
        
        /// <remarks/>
        public void getValorEspecialAsync(long in0, string in1, string in2, object userState) {
            if ((this.getValorEspecialOperationCompleted == null)) {
                this.getValorEspecialOperationCompleted = new System.Threading.SendOrPostCallback(this.OngetValorEspecialOperationCompleted);
            }
            this.InvokeAsync("getValorEspecial", new object[] {
                        in0,
                        in1,
                        in2}, this.getValorEspecialOperationCompleted, userState);
        }
        
        private void OngetValorEspecialOperationCompleted(object arg) {
            if ((this.getValorEspecialCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.getValorEspecialCompleted(this, new getValorEspecialCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://comum.ws.casosdeuso.sgs.pec.bcb.gov.br")]
    public partial class WSSerieVO {
        
        private int anoFimField;
        
        private int anoInicioField;
        
        private string avisoField;
        
        private int diaFimField;
        
        private int diaInicioField;
        
        private bool especialField;
        
        private string fonteField;
        
        private string fullNameField;
        
        private string gestorProprietarioField;
        
        private int mesFimField;
        
        private int mesInicioField;
        
        private string nomeAbreviadoField;
        
        private string nomeCompletoField;
        
        private long oidField;
        
        private string periodicidadeField;
        
        private string periodicidadeSiglaField;
        
        private bool possuiBloqueiosField;
        
        private bool publicaField;
        
        private string shortNameField;
        
        private WSValorSerieVO ultimoValorField;
        
        private string unidadePadraoField;
        
        private string unidadePadraoInglesField;
        
        private bool valorDiaNaoUtilField;
        
        private WSValorSerieVO[] valoresField;
        
        /// <remarks/>
        public int anoFim {
            get {
                return this.anoFimField;
            }
            set {
                this.anoFimField = value;
            }
        }
        
        /// <remarks/>
        public int anoInicio {
            get {
                return this.anoInicioField;
            }
            set {
                this.anoInicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string aviso {
            get {
                return this.avisoField;
            }
            set {
                this.avisoField = value;
            }
        }
        
        /// <remarks/>
        public int diaFim {
            get {
                return this.diaFimField;
            }
            set {
                this.diaFimField = value;
            }
        }
        
        /// <remarks/>
        public int diaInicio {
            get {
                return this.diaInicioField;
            }
            set {
                this.diaInicioField = value;
            }
        }
        
        /// <remarks/>
        public bool especial {
            get {
                return this.especialField;
            }
            set {
                this.especialField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string fonte {
            get {
                return this.fonteField;
            }
            set {
                this.fonteField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string fullName {
            get {
                return this.fullNameField;
            }
            set {
                this.fullNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string gestorProprietario {
            get {
                return this.gestorProprietarioField;
            }
            set {
                this.gestorProprietarioField = value;
            }
        }
        
        /// <remarks/>
        public int mesFim {
            get {
                return this.mesFimField;
            }
            set {
                this.mesFimField = value;
            }
        }
        
        /// <remarks/>
        public int mesInicio {
            get {
                return this.mesInicioField;
            }
            set {
                this.mesInicioField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string nomeAbreviado {
            get {
                return this.nomeAbreviadoField;
            }
            set {
                this.nomeAbreviadoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string nomeCompleto {
            get {
                return this.nomeCompletoField;
            }
            set {
                this.nomeCompletoField = value;
            }
        }
        
        /// <remarks/>
        public long oid {
            get {
                return this.oidField;
            }
            set {
                this.oidField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string periodicidade {
            get {
                return this.periodicidadeField;
            }
            set {
                this.periodicidadeField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string periodicidadeSigla {
            get {
                return this.periodicidadeSiglaField;
            }
            set {
                this.periodicidadeSiglaField = value;
            }
        }
        
        /// <remarks/>
        public bool possuiBloqueios {
            get {
                return this.possuiBloqueiosField;
            }
            set {
                this.possuiBloqueiosField = value;
            }
        }
        
        /// <remarks/>
        public bool publica {
            get {
                return this.publicaField;
            }
            set {
                this.publicaField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string shortName {
            get {
                return this.shortNameField;
            }
            set {
                this.shortNameField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public WSValorSerieVO ultimoValor {
            get {
                return this.ultimoValorField;
            }
            set {
                this.ultimoValorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string unidadePadrao {
            get {
                return this.unidadePadraoField;
            }
            set {
                this.unidadePadraoField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string unidadePadraoIngles {
            get {
                return this.unidadePadraoInglesField;
            }
            set {
                this.unidadePadraoInglesField = value;
            }
        }
        
        /// <remarks/>
        public bool valorDiaNaoUtil {
            get {
                return this.valorDiaNaoUtilField;
            }
            set {
                this.valorDiaNaoUtilField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public WSValorSerieVO[] valores {
            get {
                return this.valoresField;
            }
            set {
                this.valoresField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.SoapTypeAttribute(Namespace="http://comum.ws.casosdeuso.sgs.pec.bcb.gov.br")]
    public partial class WSValorSerieVO {
        
        private int anoField;
        
        private int anoFimField;
        
        private bool bloqueadoField;
        
        private bool bloqueioLiberadoField;
        
        private int diaField;
        
        private int diaFimField;
        
        private int mesField;
        
        private int mesFimField;
        
        private long oidField;
        
        private long oidSerieField;
        
        private string svalorField;
        
        private System.Nullable<decimal> valorField;
        
        /// <remarks/>
        public int ano {
            get {
                return this.anoField;
            }
            set {
                this.anoField = value;
            }
        }
        
        /// <remarks/>
        public int anoFim {
            get {
                return this.anoFimField;
            }
            set {
                this.anoFimField = value;
            }
        }
        
        /// <remarks/>
        public bool bloqueado {
            get {
                return this.bloqueadoField;
            }
            set {
                this.bloqueadoField = value;
            }
        }
        
        /// <remarks/>
        public bool bloqueioLiberado {
            get {
                return this.bloqueioLiberadoField;
            }
            set {
                this.bloqueioLiberadoField = value;
            }
        }
        
        /// <remarks/>
        public int dia {
            get {
                return this.diaField;
            }
            set {
                this.diaField = value;
            }
        }
        
        /// <remarks/>
        public int diaFim {
            get {
                return this.diaFimField;
            }
            set {
                this.diaFimField = value;
            }
        }
        
        /// <remarks/>
        public int mes {
            get {
                return this.mesField;
            }
            set {
                this.mesField = value;
            }
        }
        
        /// <remarks/>
        public int mesFim {
            get {
                return this.mesFimField;
            }
            set {
                this.mesFimField = value;
            }
        }
        
        /// <remarks/>
        public long oid {
            get {
                return this.oidField;
            }
            set {
                this.oidField = value;
            }
        }
        
        /// <remarks/>
        public long oidSerie {
            get {
                return this.oidSerieField;
            }
            set {
                this.oidSerieField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public string svalor {
            get {
                return this.svalorField;
            }
            set {
                this.svalorField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.SoapElementAttribute(IsNullable=true)]
        public System.Nullable<decimal> valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getValoresSeriesVOCompletedEventHandler(object sender, getValoresSeriesVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getValoresSeriesVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getValoresSeriesVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WSSerieVO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WSSerieVO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getUltimosValoresSerieVOCompletedEventHandler(object sender, getUltimosValoresSerieVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUltimosValoresSerieVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUltimosValoresSerieVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WSSerieVO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WSSerieVO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getValoresSeriesXMLCompletedEventHandler(object sender, getValoresSeriesXMLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getValoresSeriesXMLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getValoresSeriesXMLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getUltimoValorVOCompletedEventHandler(object sender, getUltimoValorVOCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUltimoValorVOCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUltimoValorVOCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public WSSerieVO Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((WSSerieVO)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getUltimoValorXMLCompletedEventHandler(object sender, getUltimoValorXMLCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getUltimoValorXMLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getUltimoValorXMLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getValorCompletedEventHandler(object sender, getValorCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getValorCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getValorCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public decimal Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((decimal)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    public delegate void getValorEspecialCompletedEventHandler(object sender, getValorEspecialCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.7.3056.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class getValorEspecialCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal getValorEspecialCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public decimal Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((decimal)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591