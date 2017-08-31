using System.Configuration;

namespace Innovation.Voice.Win.UI.Query.SpeechQueries
{
    public class WebSpeechEnrollmentQuery : WebBaseQuery
    {
        public override string UriTemplate => "/identificationProfiles/[profileid]/enroll";

        public WebSpeechEnrollmentQuery()
        {
            BasePath = ConfigurationManager.AppSettings["SpeechBasePath"];

            _profileId = new WebQueryStringParameter<string>("profileid");

            Parameters.Add(_profileId);
        }

        private readonly WebQueryStringParameter<string> _profileId;
        public string ProfileId
        {
            get { return _profileId.Value; }
            set { _profileId.Value = value; }
        }
    }
}
