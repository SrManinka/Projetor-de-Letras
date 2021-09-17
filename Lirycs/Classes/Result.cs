using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lirycs
{
    public class Result
    {

        //public string song_art_image_thumbnail_url { get; set; }



        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }


        [JsonProperty("primary_artist")]
        public PrimaryArtist Primary_Artist { get; set; }

        [JsonProperty("song_art_image_url")]
        public string Song_Art_Image_Url { get; set; }
    }
}
