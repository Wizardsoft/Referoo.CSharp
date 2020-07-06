using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp.Models
{
    public partial class GetCandidatesResponse
    {
        public GetCandidatesResponseData[] Data { get; set; }
    }

    public partial class GetCandidatesResponseData
    {

        [JsonProperty("num")]
        public Int64 Num { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public DateTimeOffset UpdatedDate { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("job")]
        public string Job { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("questionnairesNum")]
        public int QuestionnairesNum { get; set; }

        [JsonProperty("number_of_references_required")]
        public int NumberOfReferencesRequired { get; set; }

        [JsonProperty("one_click_reference")]
        public int OneClickReference { get; set; }

        [JsonProperty("sent")]
        public int Sent { get; set; }

        [JsonProperty("responded")]
        public int Responded { get; set; }

        [JsonProperty("declined")]
        public int Declined { get; set; }

        [JsonProperty("response_date")]
        public DateTimeOffset ResponseDate { get; set; }

    }


    public partial class GetCandidateWithRefereesResponse
    {
        [JsonProperty("candidate")]
        public GetCandidatesResponseData Candidate { get; set; }

        [JsonProperty("referees")]
        public GetRefereesResponseData[] Referees { get; set; }
    }

}
