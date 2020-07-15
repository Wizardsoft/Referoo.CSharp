using Newtonsoft.Json;
using System;

namespace Referoo.NetStandard.Models
{
    public partial class GetAccountsResponse
    {
        public GetAccountsResponseData[] Data { get; set; }
    }

    public partial class GetAccountsResponseData
    {
        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public DateTimeOffset UpdatedDate { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("work_phone")]
        public string WorkPhone { get; set; }

        [JsonProperty("office_phone")]
        public string OfficePhone { get; set; }

    }
}
