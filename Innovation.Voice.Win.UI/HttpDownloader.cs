using System;
using System.Configuration;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;

namespace Innovation.Voice.Win.UI
{
    public class HttpDownloader
    {
        public string GetResponse(Uri uri, byte[] postData)
        {
            //var bytesContent = new ByteArrayContent(postData);
            //using (var client = new HttpClient())
            //using (var formData = new MultipartFormDataContent())
            //{
            //    formData.Add(bytesContent);
            //    formData.Headers.Add("Ocp-Apim-Subscription-Key", "58947882-f4eb-4bde-98eb-14c269144e4c");
            //    var response = client.PostAsync(uri.ToString(), formData).Result;
            //    if (!response.IsSuccessStatusCode)
            //    {
            //        return null;
            //    }

            //    var reader = new StreamReader(response.Content.ReadAsStreamAsync().Result);
            //    return reader.ReadToEnd();
            //}


            var responseString = string.Empty;
            var request = (HttpWebRequest)WebRequest.Create(uri);
            request.Method = "POST";
            request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            var encoding = (Encoding)new UTF8Encoding(false);
            request.ContentLength = postData.Length;

            var sw = new StreamWriter(request.GetRequestStream(), encoding);
            sw.Write(postData);

            var httpWebResponse = (HttpWebResponse) request.GetResponse();
            var responseStream = httpWebResponse.GetResponseStream();
            var responseMemoryStream = new MemoryStream();
            responseStream?.CopyTo(responseMemoryStream);
            var responseBytes = responseMemoryStream.ToArray();

            var toStringMemoryStream = new MemoryStream(responseBytes);
            var streamReader = new StreamReader(toStringMemoryStream);
            responseString = streamReader.ReadToEnd();
            return responseString;
        }
    }
}
