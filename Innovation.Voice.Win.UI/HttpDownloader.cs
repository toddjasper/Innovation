using System;
using System.IO;
using System.Net;

namespace Innovation.Voice.Win.UI
{
    public class HttpDownloader
    {
        public string GetResponse(Uri uri, byte[] postData)
        {
            var responseString = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Proxy = null;
            request.ServicePoint.Expect100Continue = false;
            request.Method = "POST";

            //request.Headers.Add("Authorization", "Basic " + basicAuth);
            //request.Headers.Add("X-Forwarded-For", parameters["ip"] + "," + xff);

            request.ServicePoint.Expect100Continue = false;
            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                using (var responseStream = httpWebResponse.GetResponseStream())
                {
                    byte[] responseBytes;
                    using (var responseMemoryStream = new MemoryStream())
                    {
                        responseStream?.CopyTo(responseMemoryStream);
                        responseBytes = responseMemoryStream.ToArray();
                    }

                    using (var toStringMemoryStream = new MemoryStream(responseBytes))
                    {
                        using (var streamReader = new StreamReader(toStringMemoryStream))
                        {
                            responseString = streamReader.ReadToEnd();
                        }
                    }
                    return responseString;
                }
            }
        }
    }
}
