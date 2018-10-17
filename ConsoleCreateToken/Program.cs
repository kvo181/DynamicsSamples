using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCreateToken
{
    class Program
    {
        static void Main(string[] args)
        {
            string resourceUri = "https://dwgpoctest.servicebus.windows.net/dwgpocrelay";
            string keyName = "RootManageSharedAccessKey";
            string key = "9NYyNAXFAjCG0zugYxtzTVqyymdEFEECdANkamXSKoQ=";
            try
            {
                string sasToken = CreateToken.createToken(resourceUri, keyName, key);
                Console.WriteLine("SAS Token = '{0}'", sasToken);
                string sasToken2 = CreateToken.createToken2(resourceUri, keyName, key);
                Console.WriteLine("SAS Token = '{0}'", sasToken2);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
