﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LetsLearnCzech.Web.CzechService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Word", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    [System.SerializableAttribute()]
    public partial class Word : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Aspect> AspectField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Case> CaseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Conjugation> ConjugationField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LetsLearnCzech.Web.CzechService.User CreatorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DateModifiedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Gender> ForeignGenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ForeignWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsProcessedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Gender> LocalGenderField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LocalWordField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Person> PersonField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<LetsLearnCzech.Web.CzechService.Tense> TenseField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private LetsLearnCzech.Web.CzechService.WordType WordTypeField;
        
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
        public System.Nullable<LetsLearnCzech.Web.CzechService.Aspect> Aspect {
            get {
                return this.AspectField;
            }
            set {
                if ((this.AspectField.Equals(value) != true)) {
                    this.AspectField = value;
                    this.RaisePropertyChanged("Aspect");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<LetsLearnCzech.Web.CzechService.Case> Case {
            get {
                return this.CaseField;
            }
            set {
                if ((this.CaseField.Equals(value) != true)) {
                    this.CaseField = value;
                    this.RaisePropertyChanged("Case");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<LetsLearnCzech.Web.CzechService.Conjugation> Conjugation {
            get {
                return this.ConjugationField;
            }
            set {
                if ((this.ConjugationField.Equals(value) != true)) {
                    this.ConjugationField = value;
                    this.RaisePropertyChanged("Conjugation");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LetsLearnCzech.Web.CzechService.User Creator {
            get {
                return this.CreatorField;
            }
            set {
                if ((object.ReferenceEquals(this.CreatorField, value) != true)) {
                    this.CreatorField = value;
                    this.RaisePropertyChanged("Creator");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DateModified {
            get {
                return this.DateModifiedField;
            }
            set {
                if ((this.DateModifiedField.Equals(value) != true)) {
                    this.DateModifiedField = value;
                    this.RaisePropertyChanged("DateModified");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<LetsLearnCzech.Web.CzechService.Gender> ForeignGender {
            get {
                return this.ForeignGenderField;
            }
            set {
                if ((this.ForeignGenderField.Equals(value) != true)) {
                    this.ForeignGenderField = value;
                    this.RaisePropertyChanged("ForeignGender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ForeignWord {
            get {
                return this.ForeignWordField;
            }
            set {
                if ((object.ReferenceEquals(this.ForeignWordField, value) != true)) {
                    this.ForeignWordField = value;
                    this.RaisePropertyChanged("ForeignWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsProcessed {
            get {
                return this.IsProcessedField;
            }
            set {
                if ((this.IsProcessedField.Equals(value) != true)) {
                    this.IsProcessedField = value;
                    this.RaisePropertyChanged("IsProcessed");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<LetsLearnCzech.Web.CzechService.Gender> LocalGender {
            get {
                return this.LocalGenderField;
            }
            set {
                if ((this.LocalGenderField.Equals(value) != true)) {
                    this.LocalGenderField = value;
                    this.RaisePropertyChanged("LocalGender");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LocalWord {
            get {
                return this.LocalWordField;
            }
            set {
                if ((object.ReferenceEquals(this.LocalWordField, value) != true)) {
                    this.LocalWordField = value;
                    this.RaisePropertyChanged("LocalWord");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<LetsLearnCzech.Web.CzechService.Person> Person {
            get {
                return this.PersonField;
            }
            set {
                if ((this.PersonField.Equals(value) != true)) {
                    this.PersonField = value;
                    this.RaisePropertyChanged("Person");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<LetsLearnCzech.Web.CzechService.Tense> Tense {
            get {
                return this.TenseField;
            }
            set {
                if ((this.TenseField.Equals(value) != true)) {
                    this.TenseField = value;
                    this.RaisePropertyChanged("Tense");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public LetsLearnCzech.Web.CzechService.WordType WordType {
            get {
                return this.WordTypeField;
            }
            set {
                if ((this.WordTypeField.Equals(value) != true)) {
                    this.WordTypeField = value;
                    this.RaisePropertyChanged("WordType");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="User", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    [System.SerializableAttribute()]
    public partial class User : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int UserIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string UserNameField;
        
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
        public int UserId {
            get {
                return this.UserIdField;
            }
            set {
                if ((this.UserIdField.Equals(value) != true)) {
                    this.UserIdField = value;
                    this.RaisePropertyChanged("UserId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string UserName {
            get {
                return this.UserNameField;
            }
            set {
                if ((object.ReferenceEquals(this.UserNameField, value) != true)) {
                    this.UserNameField = value;
                    this.RaisePropertyChanged("UserName");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Aspect", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum Aspect : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Perfective = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Imperfective = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Case", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum Case : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Nominative = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Genitive = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Dative = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Accusative = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Vocative = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Locative = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Instrumental = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Conjugation", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum Conjugation : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        AT = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        OVAT = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        IT = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Special = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gender", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum Gender : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        M = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        F = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        N = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Person", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum Person : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Infinitive = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FirstPersonSingular = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecondPersonSingular = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ThirdPersonSingular = 4,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        FirstPersonPlural = 5,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        SecondPersonPlural = 6,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        ThirdPersonPlural = 7,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Tense", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum Tense : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Unknown = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Infinitive = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Present = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Past = 3,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Future = 4,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="WordType", Namespace="http://schemas.datacontract.org/2004/07/LetsLearnCzech.DomainModel")]
    public enum WordType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Noun = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Verb = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CzechService.ICzechService")]
    public interface ICzechService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetAllWords", ReplyAction="http://tempuri.org/ICzechService/GetAllWordsResponse")]
        LetsLearnCzech.Web.CzechService.Word[] GetAllWords();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetAllWords", ReplyAction="http://tempuri.org/ICzechService/GetAllWordsResponse")]
        System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word[]> GetAllWordsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetAllWordsOfType", ReplyAction="http://tempuri.org/ICzechService/GetAllWordsOfTypeResponse")]
        LetsLearnCzech.Web.CzechService.Word[] GetAllWordsOfType(LetsLearnCzech.Web.CzechService.WordType wordType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetAllWordsOfType", ReplyAction="http://tempuri.org/ICzechService/GetAllWordsOfTypeResponse")]
        System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word[]> GetAllWordsOfTypeAsync(LetsLearnCzech.Web.CzechService.WordType wordType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetUnprocessedWordsOfType", ReplyAction="http://tempuri.org/ICzechService/GetUnprocessedWordsOfTypeResponse")]
        LetsLearnCzech.Web.CzechService.Word[] GetUnprocessedWordsOfType(LetsLearnCzech.Web.CzechService.WordType wordType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetUnprocessedWordsOfType", ReplyAction="http://tempuri.org/ICzechService/GetUnprocessedWordsOfTypeResponse")]
        System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word[]> GetUnprocessedWordsOfTypeAsync(LetsLearnCzech.Web.CzechService.WordType wordType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetSingleWord", ReplyAction="http://tempuri.org/ICzechService/GetSingleWordResponse")]
        LetsLearnCzech.Web.CzechService.Word GetSingleWord(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/GetSingleWord", ReplyAction="http://tempuri.org/ICzechService/GetSingleWordResponse")]
        System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word> GetSingleWordAsync(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/CreateWord", ReplyAction="http://tempuri.org/ICzechService/CreateWordResponse")]
        void CreateWord(LetsLearnCzech.Web.CzechService.Word word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/CreateWord", ReplyAction="http://tempuri.org/ICzechService/CreateWordResponse")]
        System.Threading.Tasks.Task CreateWordAsync(LetsLearnCzech.Web.CzechService.Word word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/UpdateWord", ReplyAction="http://tempuri.org/ICzechService/UpdateWordResponse")]
        void UpdateWord(LetsLearnCzech.Web.CzechService.Word word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/UpdateWord", ReplyAction="http://tempuri.org/ICzechService/UpdateWordResponse")]
        System.Threading.Tasks.Task UpdateWordAsync(LetsLearnCzech.Web.CzechService.Word word);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/DeleteWord", ReplyAction="http://tempuri.org/ICzechService/DeleteWordResponse")]
        void DeleteWord(System.Nullable<int> id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICzechService/DeleteWord", ReplyAction="http://tempuri.org/ICzechService/DeleteWordResponse")]
        System.Threading.Tasks.Task DeleteWordAsync(System.Nullable<int> id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICzechServiceChannel : LetsLearnCzech.Web.CzechService.ICzechService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CzechServiceClient : System.ServiceModel.ClientBase<LetsLearnCzech.Web.CzechService.ICzechService>, LetsLearnCzech.Web.CzechService.ICzechService {
        
        public CzechServiceClient() {
        }
        
        public CzechServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CzechServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CzechServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CzechServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public LetsLearnCzech.Web.CzechService.Word[] GetAllWords() {
            return base.Channel.GetAllWords();
        }
        
        public System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word[]> GetAllWordsAsync() {
            return base.Channel.GetAllWordsAsync();
        }
        
        public LetsLearnCzech.Web.CzechService.Word[] GetAllWordsOfType(LetsLearnCzech.Web.CzechService.WordType wordType) {
            return base.Channel.GetAllWordsOfType(wordType);
        }
        
        public System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word[]> GetAllWordsOfTypeAsync(LetsLearnCzech.Web.CzechService.WordType wordType) {
            return base.Channel.GetAllWordsOfTypeAsync(wordType);
        }
        
        public LetsLearnCzech.Web.CzechService.Word[] GetUnprocessedWordsOfType(LetsLearnCzech.Web.CzechService.WordType wordType) {
            return base.Channel.GetUnprocessedWordsOfType(wordType);
        }
        
        public System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word[]> GetUnprocessedWordsOfTypeAsync(LetsLearnCzech.Web.CzechService.WordType wordType) {
            return base.Channel.GetUnprocessedWordsOfTypeAsync(wordType);
        }
        
        public LetsLearnCzech.Web.CzechService.Word GetSingleWord(System.Nullable<int> id) {
            return base.Channel.GetSingleWord(id);
        }
        
        public System.Threading.Tasks.Task<LetsLearnCzech.Web.CzechService.Word> GetSingleWordAsync(System.Nullable<int> id) {
            return base.Channel.GetSingleWordAsync(id);
        }
        
        public void CreateWord(LetsLearnCzech.Web.CzechService.Word word) {
            base.Channel.CreateWord(word);
        }
        
        public System.Threading.Tasks.Task CreateWordAsync(LetsLearnCzech.Web.CzechService.Word word) {
            return base.Channel.CreateWordAsync(word);
        }
        
        public void UpdateWord(LetsLearnCzech.Web.CzechService.Word word) {
            base.Channel.UpdateWord(word);
        }
        
        public System.Threading.Tasks.Task UpdateWordAsync(LetsLearnCzech.Web.CzechService.Word word) {
            return base.Channel.UpdateWordAsync(word);
        }
        
        public void DeleteWord(System.Nullable<int> id) {
            base.Channel.DeleteWord(id);
        }
        
        public System.Threading.Tasks.Task DeleteWordAsync(System.Nullable<int> id) {
            return base.Channel.DeleteWordAsync(id);
        }
    }
}