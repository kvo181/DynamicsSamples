using Microsoft.ServiceBus;
using System;
using System.Linq;
using System.ServiceModel;
using MyServiceConsole.MyServicePortReference;

namespace MyServiceConsole
{
    class Program
    {
        static ChannelFactory<MyServicePortContractChannel> channelFactory;

        static void Main(string[] args)
        {
            try
            {
                // Create shared access signature token credentials for authentication.
                channelFactory = new ChannelFactory<MyServicePortReference.MyServicePortContractChannel>(new BasicHttpRelayBinding(),
                    "https://dwgpoctest.servicebus.windows.net/dwgpocrelay");
                channelFactory.Endpoint.Behaviors.Add(new TransportClientEndpointBehavior
                {
                    TokenProvider = TokenProvider.CreateSharedAccessSignatureTokenProvider(
                        "RootManageSharedAccessKey", "9NYyNAXFAjCG0zugYxtzTVqyymdEFEECdANkamXSKoQ=")
                });


                MyServicePortContractChannel channel = channelFactory.CreateChannel();
                MyServiceFindRequestRequest request = new MyServiceFindRequestRequest();
                request.CallContext = new CallContext();
                request.CallContext.Company = "snl";
                request._args = new FindRequestArgs();
                request._args.RequestId = "REQ-000142";

                MyServiceFindRequestResponse response = channel.FindRequest(request);
                Console.WriteLine("{0} requests found", response.response.Count());
            }
            catch (Exception e)
            {
                Console.WriteLine("Find failed: {0}\n{1}", e.Message, e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
