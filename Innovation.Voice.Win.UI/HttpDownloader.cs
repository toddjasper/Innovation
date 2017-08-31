using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Innovation.Voice.Win.UI
{
    public class HttpDownloader
    {
        public string GetRegistrationResponse(Uri uri, byte[] postData)
        {
            if (postData == null || postData.Length == 0) return "No wave data to POST";

            var request = (HttpWebRequest)WebRequest.Create(uri.ToString());

            request.Method = "POST";
            request.ContentType = "audio/wav";
            request.ContentLength = postData.Length;
            request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            var reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            var httpWebResponse = (HttpWebResponse)request.GetResponse();
            var responseStream = httpWebResponse.GetResponseStream();
            var responseMemoryStream = new MemoryStream();
            responseStream?.CopyTo(responseMemoryStream);

            return "Registration complete";
        }

        public string GetIdentificationResponse(Uri uri, byte[] postData)
        {
            if (postData == null || postData.Length == 0) return null;

            var request = (HttpWebRequest)WebRequest.Create(uri.ToString());

            request.Method = "POST";
            request.ContentType = "application/octet-stream";
            request.ContentLength = postData.Length;
            request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            var reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            var httpWebResponse = (HttpWebResponse)request.GetResponse();
            return httpWebResponse.Headers["Operation-Location"];
        }

        public string GetOperationResponse(Uri uri)
        {
            //var request = (HttpWebRequest)WebRequest.Create(uri.ToString());

            //request.Method = "GET";
            //request.ContentType = "application/json";
            //request.ContentLength = 0;
            //request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            //var httpWebResponse = (HttpWebResponse)request.GetResponse();
            //var responseStream = httpWebResponse.GetResponseStream();
            //var responseMemoryStream = new MemoryStream();
            //responseStream?.CopyTo(responseMemoryStream);

            //var responseBytes = responseMemoryStream.ToArray();
            //var toStringMemoryStream = new MemoryStream(responseBytes);
            //var streamReader = new StreamReader(toStringMemoryStream);

            //return streamReader.ReadToEnd();

            var client = new HttpClient();
            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);
            var response = Task.Run(() => client.GetAsync(uri)).Result;

            while (true)
            {
                if (response.IsSuccessStatusCode)
                {
                    var text =  response.Content.ReadAsStringAsync().Result;
                    return text;
                }
            }
        }
    }
}
