using System;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Windows;

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


            var str = System.Text.Encoding.Default.GetString(postData);

            var request = (HttpWebRequest)WebRequest.Create(uri.ToString());

            request.Method = "POST";
            request.ContentType = "multipart/form-data";
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


            /*
             static String API_KEY = "YOUR-KEY";
            static String PROFILE_ID = "YOUR-PROFILE-ID";
            static String LOCATION = "westus"; // Check, might be different in the future 

            public static void main(String[] args) {
                HttpClient httpclient = HttpClients.createDefault();

                try {
                    URIBuilder builder = new URIBuilder(
                        String.format("https://%s.api.cognitive.microsoft.com/spid/v1.0/identificationProfiles/%s/enroll", LOCATION, PROFILE_ID));
                    URI uri = builder.build();
                    HttpPost request = new HttpPost(uri);
                    request.setHeader("Ocp-Apim-Subscription-Key", API_KEY);
                    request.setEntity(new FileEntity(new File("test.wav"), ContentType.APPLICATION_OCTET_STREAM));

                    HttpResponse response = httpclient.execute(request);
                    HttpEntity entity = response.getEntity();

                    // Response is empty on success; the following will contain the URI where you can check the status
                    System.out.println(response.getHeaders("Operation-Location")[0].getValue());
                } catch (Exception e) {
                    System.out.println(e.getMessage());
                }
            }
             */





            //var responseString = string.Empty;
            //var request = (HttpWebRequest)WebRequest.Create(uri);
            //request.Method = "POST";
            //request.Headers.Add("Ocp-Apim-Subscription-Key", ConfigurationManager.AppSettings["SpeechKey1"]);

            //var encoding = (Encoding)new UTF8Encoding(false);
            //request.ContentLength = postData.Length;

            //var sw = new StreamWriter(request.GetRequestStream(), encoding);
            //sw.Write(postData);

            //var httpWebResponse = (HttpWebResponse) request.GetResponse();
            //var responseStream = httpWebResponse.GetResponseStream();
            //var responseMemoryStream = new MemoryStream();
            //responseStream?.CopyTo(responseMemoryStream);
            //var responseBytes = responseMemoryStream.ToArray();

            //var toStringMemoryStream = new MemoryStream(responseBytes);
            //var streamReader = new StreamReader(toStringMemoryStream);
            //responseString = streamReader.ReadToEnd();
            //return responseString;
        }
    }
}
