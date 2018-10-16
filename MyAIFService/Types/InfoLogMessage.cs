using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAIFService.Types
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "InfologMessage", Namespace = "http://schemas.datacontract.org/2004/07/Microsoft.Dynamics.AX.Framework.Services")]
    [System.SerializableAttribute()]
    public partial class InfologMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyAIFService.MyServicePortServiceReference.InfologMessageType InfologMessageTypeField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MessageField;

        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData
        {
            get
            {
                return this.extensionDataField;
            }
            set
            {
                this.extensionDataField = value;
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyAIFService.MyServicePortServiceReference.InfologMessageType InfologMessageType
        {
            get
            {
                return this.InfologMessageTypeField;
            }
            set
            {
                if ((this.InfologMessageTypeField.Equals(value) != true))
                {
                    this.InfologMessageTypeField = value;
                    this.RaisePropertyChanged("InfologMessageType");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Message
        {
            get
            {
                return this.MessageField;
            }
            set
            {
                if ((object.ReferenceEquals(this.MessageField, value) != true))
                {
                    this.MessageField = value;
                    this.RaisePropertyChanged("Message");
                }
            }
        }

        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

        protected void RaisePropertyChanged(string propertyName)
        {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null))
            {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
