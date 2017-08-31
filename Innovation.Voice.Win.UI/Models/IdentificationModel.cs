using Newtonsoft.Json;

namespace Innovation.Voice.Win.UI.Models
{
    public class IdentificationModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("processingResult")]
        public ProcessingResult ProcessingResult { get; set; }
    }

    public class ProcessingResult
    {
        [JsonProperty("identifiedProfileId")]
        public string IdentifiedProfileId { get; set; }

        [JsonProperty("confidence")]
        public string Confidence { get; set; }
    }
}
