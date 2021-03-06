﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Consumir.ServiceReference2 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProdutoViewModel", Namespace="http://schemas.datacontract.org/2004/07/GerenciamentoProduto.Model")]
    [System.SerializableAttribute()]
    public partial class ProdutoViewModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategoriaField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FlagField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ImagemField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NomeProdutoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PrecoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int QuantidadeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int idProdutoField;
        
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
        public string Categoria {
            get {
                return this.CategoriaField;
            }
            set {
                if ((object.ReferenceEquals(this.CategoriaField, value) != true)) {
                    this.CategoriaField = value;
                    this.RaisePropertyChanged("Categoria");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Flag {
            get {
                return this.FlagField;
            }
            set {
                if ((object.ReferenceEquals(this.FlagField, value) != true)) {
                    this.FlagField = value;
                    this.RaisePropertyChanged("Flag");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Imagem {
            get {
                return this.ImagemField;
            }
            set {
                if ((object.ReferenceEquals(this.ImagemField, value) != true)) {
                    this.ImagemField = value;
                    this.RaisePropertyChanged("Imagem");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NomeProduto {
            get {
                return this.NomeProdutoField;
            }
            set {
                if ((object.ReferenceEquals(this.NomeProdutoField, value) != true)) {
                    this.NomeProdutoField = value;
                    this.RaisePropertyChanged("NomeProduto");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Preco {
            get {
                return this.PrecoField;
            }
            set {
                if ((object.ReferenceEquals(this.PrecoField, value) != true)) {
                    this.PrecoField = value;
                    this.RaisePropertyChanged("Preco");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Quantidade {
            get {
                return this.QuantidadeField;
            }
            set {
                if ((this.QuantidadeField.Equals(value) != true)) {
                    this.QuantidadeField = value;
                    this.RaisePropertyChanged("Quantidade");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int idProduto {
            get {
                return this.idProdutoField;
            }
            set {
                if ((this.idProdutoField.Equals(value) != true)) {
                    this.idProdutoField = value;
                    this.RaisePropertyChanged("idProduto");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost:49577/v1", ConfigurationName="ServiceReference2.Produtos")]
    public interface Produtos {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:49577/v1/Produtos/AdicionarNaFila", ReplyAction="http://localhost:49577/v1/Produtos/AdicionarNaFilaResponse")]
        bool AdicionarNaFila(Consumir.ServiceReference2.ProdutoViewModel produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:49577/v1/Produtos/AdicionarNaFila", ReplyAction="http://localhost:49577/v1/Produtos/AdicionarNaFilaResponse")]
        System.Threading.Tasks.Task<bool> AdicionarNaFilaAsync(Consumir.ServiceReference2.ProdutoViewModel produto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:49577/v1/Produtos/ConsumirFila", ReplyAction="http://localhost:49577/v1/Produtos/ConsumirFilaResponse")]
        bool ConsumirFila();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost:49577/v1/Produtos/ConsumirFila", ReplyAction="http://localhost:49577/v1/Produtos/ConsumirFilaResponse")]
        System.Threading.Tasks.Task<bool> ConsumirFilaAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ProdutosChannel : Consumir.ServiceReference2.Produtos, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProdutosClient : System.ServiceModel.ClientBase<Consumir.ServiceReference2.Produtos>, Consumir.ServiceReference2.Produtos {
        
        public ProdutosClient() {
        }
        
        public ProdutosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProdutosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProdutosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProdutosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AdicionarNaFila(Consumir.ServiceReference2.ProdutoViewModel produto) {
            return base.Channel.AdicionarNaFila(produto);
        }
        
        public System.Threading.Tasks.Task<bool> AdicionarNaFilaAsync(Consumir.ServiceReference2.ProdutoViewModel produto) {
            return base.Channel.AdicionarNaFilaAsync(produto);
        }
        
        public bool ConsumirFila() {
            return base.Channel.ConsumirFila();
        }
        
        public System.Threading.Tasks.Task<bool> ConsumirFilaAsync() {
            return base.Channel.ConsumirFilaAsync();
        }
    }
}
