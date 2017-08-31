using System.Configuration;

namespace Innovation.Voice.Win.UI.Query.SpeechQueries
{
    public class WebSpeechIdentificationQuery : WebBaseQuery
    {
        //https://westus.api.cognitive.microsoft.com/spid/v1.0/identify?identificationProfileIds=111f427c-3791-468f-b709-fcef7660fff9,111f427c-3791-468f-b709-fcef7660fff9,111f427c-3791-468f-b709-fcef7660fff9

        public override string UriTemplate => "/identify?[identificationProfileIds][shortAudio]";

        public WebSpeechIdentificationQuery()
        {
            BasePath = ConfigurationManager.AppSettings["SpeechBasePath"];

            _identificationProfileIds = new WebQueryStringParameter<string>("identificationProfileIds");
            _shortAudio = new WebQueryStringParameter<bool>("shortAudio");

            Parameters.Add(_identificationProfileIds);
            Parameters.Add(_shortAudio);
        }

        private readonly WebQueryStringParameter<string> _identificationProfileIds;
        public string IdentificationProfileIds
        {
            get { return _identificationProfileIds.Value; }
            set { _identificationProfileIds.Value = value; }
        }

        private readonly WebQueryStringParameter<bool> _shortAudio;
        public bool ShortAudio
        {
            get { return _shortAudio.Value; }
            set { _shortAudio.Value = value; }
        }
    }
}
