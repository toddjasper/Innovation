using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;

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
            request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            var encoding = (Encoding)new UTF8Encoding(false);
            request.ContentLength = postData.Length;

            var sw = new StreamWriter(request.GetRequestStream(), encoding);
            sw.Write(postData);
            sw.Close();

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
