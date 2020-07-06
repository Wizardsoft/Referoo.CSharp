using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp.Models
{
    public partial class GetQuestionnairesResponse
    {
        public GetQuestionnairesResponseData[] Data { get; set; }
    }

    public partial class GetQuestionnairesResponseData
    {
        [JsonProperty("num")]
        public Int64 Num { get; set; }

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
