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
    [System.ServiceModel.MessageContractAttribute(WrapperName = "MyServiceFindRequestResponse", WrapperNamespace = "http://mynamespace", IsWrapped = true)]
    public partial class MyServiceFindRequestResponse
    {

        [System.ServiceModel.MessageBodyMemberAttribute(Namespace = "http://mynamespace", Order = 0)]
        public MyAIFService.MyServicePortServiceReference.MeterReadingRequest[] response;

        public MyServiceFindRequestResponse()
        {
        }

        public MyServiceFindRequestResponse(MyAIFService.MyServicePortServiceReference.MeterReadingRequest[] response)
        {
            this.response = response;
        }
    }
}
