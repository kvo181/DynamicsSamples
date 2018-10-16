using MyAIFService.Interface;
using MyAIFService.Types;

namespace MyAIFService.Service
{
    public class MyService : IMyService
    {
        public MyServiceFindRequestResponse FindRequest(MyServiceFindRequestRequest request)
        {
            MyServicePortServiceReference.MeterReadingRequest[] response = null;
            try
            {
                using (MyServicePortServiceReference.MyServiceClient client = new MyServicePortServiceReference.MyServiceClient())
                {
                    MyServicePortServiceReference.CallContext context = request.CallContext;
                    MyServicePortServiceReference.FindRequestArgs args = request._args;
                    string languageID = request._languageID;
                    response = client.FindRequest(context, args, languageID);
                }
            }
            catch
            {

            }
            MyServiceFindRequestResponse result = new MyServiceFindRequestResponse();
            if (null != response)
            {
                result.response = response;
            }
            return result;
        }
    }
}
