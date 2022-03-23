﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWeb.srstores {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="srstores.wsstoresSoap")]
    public interface wsstoresSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Listar();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Listar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Agregar(int stor_id, string stor_name, string stor_address, string city, string state, string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Agregar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> AgregarAsync(int stor_id, string stor_name, string stor_address, string city, string state, string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Actualizar(int stor_id, string stor_name, string stor_address, string city, string state, string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Actualizar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> ActualizarAsync(int stor_id, string stor_name, string stor_address, string city, string state, string zip);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        string[] Eliminar(int stor_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Eliminar", ReplyAction="*")]
        System.Threading.Tasks.Task<string[]> EliminarAsync(int stor_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet Buscar(int stor_id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Buscar", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(int stor_id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface wsstoresSoapChannel : ClienteWeb.srstores.wsstoresSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class wsstoresSoapClient : System.ServiceModel.ClientBase<ClienteWeb.srstores.wsstoresSoap>, ClienteWeb.srstores.wsstoresSoap {
        
        public wsstoresSoapClient() {
        }
        
        public wsstoresSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public wsstoresSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsstoresSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public wsstoresSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet Listar() {
            return base.Channel.Listar();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> ListarAsync() {
            return base.Channel.ListarAsync();
        }
        
        public string[] Agregar(int stor_id, string stor_name, string stor_address, string city, string state, string zip) {
            return base.Channel.Agregar(stor_id, stor_name, stor_address, city, state, zip);
        }
        
        public System.Threading.Tasks.Task<string[]> AgregarAsync(int stor_id, string stor_name, string stor_address, string city, string state, string zip) {
            return base.Channel.AgregarAsync(stor_id, stor_name, stor_address, city, state, zip);
        }
        
        public string[] Actualizar(int stor_id, string stor_name, string stor_address, string city, string state, string zip) {
            return base.Channel.Actualizar(stor_id, stor_name, stor_address, city, state, zip);
        }
        
        public System.Threading.Tasks.Task<string[]> ActualizarAsync(int stor_id, string stor_name, string stor_address, string city, string state, string zip) {
            return base.Channel.ActualizarAsync(stor_id, stor_name, stor_address, city, state, zip);
        }
        
        public string[] Eliminar(int stor_id) {
            return base.Channel.Eliminar(stor_id);
        }
        
        public System.Threading.Tasks.Task<string[]> EliminarAsync(int stor_id) {
            return base.Channel.EliminarAsync(stor_id);
        }
        
        public System.Data.DataSet Buscar(int stor_id) {
            return base.Channel.Buscar(stor_id);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> BuscarAsync(int stor_id) {
            return base.Channel.BuscarAsync(stor_id);
        }
    }
}