using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAIFService.Types
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name = "FaultMessageList", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.SerializableAttribute()]
    public partial class FaultMessageList : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DocumentOperationField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private MyAIFService.MyServicePortServiceReference.FaultMessage[] FaultMessageArrayField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FieldField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceOperationField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ServiceOperationParameterField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XPathField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlLineField;

        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string XmlPositionField;

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
        public string Document
        {
            get
            {
                return this.DocumentField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DocumentField, value) != true))
                {
                    this.DocumentField = value;
                    this.RaisePropertyChanged("Document");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DocumentOperation
        {
            get
            {
                return this.DocumentOperationField;
            }
            set
            {
                if ((object.ReferenceEquals(this.DocumentOperationField, value) != true))
                {
                    this.DocumentOperationField = value;
                    this.RaisePropertyChanged("DocumentOperation");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public MyAIFService.MyServicePortServiceReference.FaultMessage[] FaultMessageArray
        {
            get
            {
                return this.FaultMessageArrayField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FaultMessageArrayField, value) != true))
                {
                    this.FaultMessageArrayField = value;
                    this.RaisePropertyChanged("FaultMessageArray");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Field
        {
            get
            {
                return this.FieldField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FieldField, value) != true))
                {
                    this.FieldField = value;
                    this.RaisePropertyChanged("Field");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Service
        {
            get
            {
                return this.ServiceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ServiceField, value) != true))
                {
                    this.ServiceField = value;
                    this.RaisePropertyChanged("Service");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperation
        {
            get
            {
                return this.ServiceOperationField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ServiceOperationField, value) != true))
                {
                    this.ServiceOperationField = value;
                    this.RaisePropertyChanged("ServiceOperation");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ServiceOperationParameter
        {
            get
            {
                return this.ServiceOperationParameterField;
            }
            set
            {
                if ((object.ReferenceEquals(this.ServiceOperationParameterField, value) != true))
                {
                    this.ServiceOperationParameterField = value;
                    this.RaisePropertyChanged("ServiceOperationParameter");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XPath
        {
            get
            {
                return this.XPathField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XPathField, value) != true))
                {
                    this.XPathField = value;
                    this.RaisePropertyChanged("XPath");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlLine
        {
            get
            {
                return this.XmlLineField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XmlLineField, value) != true))
                {
                    this.XmlLineField = value;
                    this.RaisePropertyChanged("XmlLine");
                }
            }
        }

        [System.Runtime.Serialization.DataMemberAttribute()]
        public string XmlPosition
        {
            get
            {
                return this.XmlPositionField;
            }
            set
            {
                if ((object.ReferenceEquals(this.XmlPositionField, value) != true))
                {
                    this.XmlPositionField = value;
                    this.RaisePropertyChanged("XmlPosition");
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
