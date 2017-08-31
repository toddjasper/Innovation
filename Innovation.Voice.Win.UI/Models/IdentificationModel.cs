using Newtonsoft.Json;

namespace Innovation.Voice.Win.UI.Models
{
    public class IdentificationModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
