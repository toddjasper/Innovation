using System;
using System.Configuration;
using System.IO;
using System.Net;

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

            //var responseBytes = responseMemoryStream.ToArray();
            //var toStringMemoryStream = new MemoryStream(responseBytes);
            //var streamReader = new StreamReader(toStringMemoryStream);
            return "Registration complete";
        }

        public string GetIdentificationResponse(Uri uri, byte[] postData)
        {
            if (postData == null || postData.Length == 0) return "No wave data to POST";

            var request = (HttpWebRequest)WebRequest.Create(uri.ToString());

            request.Method = "POST";
            request.ContentType = "application/octet-stream";
            request.ContentLength = postData.Length;
            request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            var reqStream = request.GetRequestStream();
            reqStream.Write(postData, 0, postData.Length);
            reqStream.Close();

            var httpWebResponse = (HttpWebResponse)request.GetResponse();
            var responseStream = httpWebResponse.GetResponseStream();
            var responseMemoryStream = new MemoryStream();
            responseStream?.CopyTo(responseMemoryStream);

            var responseBytes = responseMemoryStream.ToArray();
            var toStringMemoryStream = new MemoryStream(responseBytes);
            var streamReader = new StreamReader(toStringMemoryStream);
            return streamReader.ReadToEnd();
        }
    }
}
