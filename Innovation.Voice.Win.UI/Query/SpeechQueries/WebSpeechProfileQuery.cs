using System.Configuration;

namespace Innovation.Voice.Win.UI.Query.SpeechQueries
{
    public class WebSpeechProfileQuery : WebBaseQuery
    {
        public override string UriTemplate => "/identificationProfiles";

        public WebSpeechProfileQuery()
        {
            BasePath = ConfigurationManager.AppSettings["SpeechBasePath"];
        }
    }
}
