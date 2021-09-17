using Newtonsoft.Json;

namespace Lirycs
{
    public class PrimaryArtist
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }
    }
}
