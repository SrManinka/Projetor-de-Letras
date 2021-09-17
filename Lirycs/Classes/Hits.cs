using Newtonsoft.Json;

namespace Lirycs
{
    public class Hits
    {

        [JsonProperty("result")]
        public Result Result { get; set; }
    }
}
