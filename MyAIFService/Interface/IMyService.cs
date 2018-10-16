using MyAIFService.Types;
using System.ServiceModel;

namespace MyAIFService.Interface
{
    [ServiceContract(Name ="MyServicePortContract", Namespace = "http://mynamespace")]
    interface IMyService
    {
        [OperationContract(Action = "http://mynamespace/MyService/FindRequest", ReplyAction = "http://mynamespace/MyService/FindRequestResponse")]
        [FaultContract(typeof(AifFault), Action = "http://mynamespace/MyService/FindRequestAifFaultFault", Name = "AifFault", Namespace = "http://schemas.microsoft.com/dynamics/2008/01/documents/Fault")]
        MyServiceFindRequestResponse FindRequest(MyServiceFindRequestRequest request);
    }
}
