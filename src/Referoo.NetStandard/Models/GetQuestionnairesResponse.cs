using Newtonsoft.Json;
using System;

namespace Referoo.NetStandard.Models
{
    public partial class GetQuestionnairesResponse
    {
        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public DateTimeOffset UpdatedDate { get; set; }

        [JsonProperty("membersNum")]
        public int MembersNum { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
