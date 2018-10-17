namespace ConsoleCreateToken
{
    public class CreateToken
   {
        public static string createToken(string resourceUri, string keyName, string key)
        {
            System.TimeSpan sinceEpoch = System.DateTime.UtcNow - new System.DateTime(1970, 1, 1);
            var week = 60 * 60 * 24 * 7;
            var expiry = System.Convert.ToString((int)sinceEpoch.TotalSeconds + week);
            string stringToSign = System.Web.HttpUtility.UrlEncode(resourceUri) + "\n" + expiry;
            System.Security.Cryptography.HMACSHA256 hmac = new System.Security.Cryptography.HMACSHA256(System.Text.Encoding.UTF8.GetBytes(key));
            var signature = System.Convert.ToBase64String(hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(stringToSign)));
            var sasToken = System.String.Format(System.Globalization.CultureInfo.InvariantCulture, "SharedAccessSignature sr={0}&sig={1}&se={2}&skn={3}", System.Web.HttpUtility.UrlEncode(resourceUri), System.Web.HttpUtility.UrlEncode(signature), expiry, keyName);
            return sasToken;
        }
        public static string createToken2(string resourceUri, string keyName, string key)
        {
            System.TimeSpan sinceEpoch = System.DateTime.UtcNow - new System.DateTime(1970, 1, 1);
            var week = 60 * 60 * 24 * 7;
            var expiry = System.Convert.ToString((int)sinceEpoch.TotalSeconds + week);
            string stringToSign = System.Uri.EscapeDataString(resourceUri) + "\n" + expiry;
            System.Security.Cryptography.HMACSHA256 hmac = new System.Security.Cryptography.HMACSHA256(System.Text.Encoding.UTF8.GetBytes(key));
            var signature = System.Convert.ToBase64String(hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(stringToSign)));
            var sasToken = System.String.Format("SharedAccessSignature sr={0}&sig={1}&se={2}&skn={3}", System.Uri.EscapeDataString(resourceUri), System.Uri.EscapeDataString(signature), expiry, keyName);
            return sasToken;
        }
    }
}
