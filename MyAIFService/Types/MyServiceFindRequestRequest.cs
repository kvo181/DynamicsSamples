using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAIFService.Types
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName = "MyServiceFindRequestRequest", WrapperNamespace = "http://mynamespace", IsWrapped = true)]
    public partial class MyServiceFindRequestRequest
    {

        [System.ServiceModel.MessageHeaderAttribute(Namespace = "http://schemas.microsoft.com/dynamics/2010/01/datacontracts")]
        public MyAIFService.MyServicePortServiceReference.CallContext CallContext;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://mynamespace", Order = 0)]
        public MyAIFService.MyServicePortServiceReference.FindRequestArgs _args;

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://mynamespace", Order = 1)]
        public string _languageID;

        public MyServiceFindRequestRequest()
        {
        }

        public MyServiceFindRequestRequest(MyAIFService.MyServicePortServiceReference.CallContext CallContext, MyAIFService.MyServicePortServiceReference.FindRequestArgs _args, string _languageID)
        {
            this.CallContext = CallContext;
            this._args = _args;
            this._languageID = _languageID;
        }
    }
}
