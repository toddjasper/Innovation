using System.Configuration;

namespace Innovation.Voice.Win.UI.Query.SpeechQueries
{
    public class WebSpeechEnrollmentQuery : WebBaseQuery
    {
        public override string UriTemplate => "/identificationProfiles/[profileid]/enroll?[shortAudio]";

        public WebSpeechEnrollmentQuery()
        {
            BasePath = ConfigurationManager.AppSettings["SpeechBasePath"];

            _profileId = new WebQueryStringParameter<string>("profileid");
            _shortAudio = new WebQueryStringParameter<bool>("shortAudio");

            Parameters.Add(_profileId);
            Parameters.Add(_shortAudio);
        }

        private readonly WebQueryStringParameter<string> _profileId;
        public string ProfileId
        {
            get { return _profileId.Value; }
            set { _profileId.Value = value; }
        }

        private readonly WebQueryStringParameter<bool> _shortAudio;
        public bool ShortAudio
        {
            get { return _shortAudio.Value; }
            set { _shortAudio.Value = value; }
        }
    }
}
