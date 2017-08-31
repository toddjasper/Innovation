using Newtonsoft.Json;

namespace Innovation.Voice.Win.UI.Models
{
    public class ProfileModel
    {
        [JsonProperty("identificationProfileId")]
        public string ProfileId { get; set; }
    }
}
