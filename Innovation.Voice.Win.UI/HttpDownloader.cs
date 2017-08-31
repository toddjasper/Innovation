using System;
using System.IO;
using System.Net;

namespace Innovation.Voice.Win.UI
{
    public class HttpDownloader
    {
        public void MakeRequest(Uri uri)
        {
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Proxy = null;
            request.ServicePoint.Expect100Continue = false;
            request.Method = "POST";

            //request.Headers.Add("Authorization", "Basic " + basicAuth);
            //request.Headers.Add("X-Forwarded-For", parameters["ip"] + "," + xff);

            request.ServicePoint.Expect100Continue = false;
            using (var httpWebResponse = (HttpWebResponse)request.GetResponse())
            {
                byte[] responseBytes;
                using (var responseStream = httpWebResponse.GetResponseStream())
                {
                    using (var memoryStream = new MemoryStream())
                    {
                        if (responseStream != null)
                        {
                            // TODO: RecycableMemoryStream? Chunks? MS documentation seems to suggest that chunks = slower than CopyTo
                            responseStream.CopyTo(memoryStream);
                        }
                        responseBytes = memoryStream.ToArray();
                    }
                }
            }
        }
    }
}
