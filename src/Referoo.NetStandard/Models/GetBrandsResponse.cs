using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.NetStandard.Models
{
    public class GetBrandsResponse
    {
        public GetBrandsResponseData[] Data { get; set; }
    }

    public class GetBrandsResponseData
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

        [JsonProperty("custom_username")]
        public string CustomUsername { get; set; }

        [JsonProperty("primary_colour")]
        public string PrimaryColour { get; set; }

        [JsonProperty("secondary_colour")]
        public string SecondaryColour { get; set; }

        [JsonProperty("third_colour")]
        public string ThirdColour { get; set; }
    }
}
