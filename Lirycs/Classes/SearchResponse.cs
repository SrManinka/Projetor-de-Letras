using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirycs
{
    public class SearchResponse
    {
        [JsonProperty("meta")]
        public object Meta { get; set; }
        [JsonProperty("response")]
        public Response Response { get; set; }

        //declarar response, hits e result  
    }
}
