using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyAIFService.Types
{
    [DataContract(Name = "AifFault", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
    [System.Serializable()]
    public partial class AifFault : object, IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged
    {

        [NonSerialized()]
        private ExtensionDataObject extensionDataField;

        [OptionalField()]
        private string CustomDetailXmlField;

        [OptionalField()]
        private FaultMessageList[] FaultMessageListArrayField;

        [OptionalField()]
        private InfologMessage[] InfologMessageListField;

        [OptionalField()]
        private string StackTraceField;

        [OptionalField()]
        private int XppExceptionTypeField;

        [global::System.ComponentModel.Browsable(false)]
        public ExtensionDataObject ExtensionData
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

        [DataMember()]
        public string CustomDetailXml
        {
            get
            {
                return this.CustomDetailXmlField;
            }
            set
            {
                if ((object.ReferenceEquals(this.CustomDetailXmlField, value) != true))
                {
                    this.CustomDetailXmlField = value;
                    this.RaisePropertyChanged("CustomDetailXml");
                }
            }
        }

        [DataMember()]
        public FaultMessageList[] FaultMessageListArray
        {
            get
            {
                return this.FaultMessageListArrayField;
            }
            set
            {
                if ((object.ReferenceEquals(this.FaultMessageListArrayField, value) != true))
                {
                    this.FaultMessageListArrayField = value;
                    this.RaisePropertyChanged("FaultMessageListArray");
                }
            }
        }

        [DataMember()]
        public InfologMessage[] InfologMessageList
        {
            get
            {
                return this.InfologMessageListField;
            }
            set
            {
                if ((object.ReferenceEquals(this.InfologMessageListField, value) != true))
                {
                    this.InfologMessageListField = value;
                    this.RaisePropertyChanged("InfologMessageList");
                }
            }
        }

        [DataMember()]
        public string StackTrace
        {
            get
            {
                return this.StackTraceField;
            }
            set
            {
                if ((object.ReferenceEquals(this.StackTraceField, value) != true))
                {
                    this.StackTraceField = value;
                    this.RaisePropertyChanged("StackTrace");
                }
            }
        }

        [DataMember()]
        public int XppExceptionType
        {
            get
            {
                return this.XppExceptionTypeField;
            }
            set
            {
                if ((this.XppExceptionTypeField.Equals(value) != true))
                {
                    this.XppExceptionTypeField = value;
                    this.RaisePropertyChanged("XppExceptionType");
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
