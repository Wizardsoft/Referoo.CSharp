using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp.Models
{
    public partial class PostCandidateParameter
    {
        [JsonProperty("first_name", Required = Required.Always)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", Required = Required.Always)]
        public string LastName { get; set; }

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }

        [JsonProperty("phone", Required = Required.AllowNull)]
        public string Phone { get; set; }

        [JsonProperty("notes", Required = Required.AllowNull)]
        public string Notes { get; set; }

        [JsonProperty("job", Required = Required.AllowNull)]
        public string Job { get; set; }

        [JsonProperty("company", Required = Required.AllowNull)]
        public string Company { get; set; }

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public int QuestionnairesNum { get; set; }

        [JsonProperty("number_of_references_required", Required = Required.Always)]
        public int NumberOfReferencesRequired { get; set; }

        [JsonProperty("one_click_reference", Required = Required.Always)]
        public int OneClickReference { get; set; }

    }

    public partial class PostCandidateWithRefereesParameter
    {
        [JsonProperty("candidate", Required = Required.Always)]
        public PostCandidateParameter Candidate { get; set; }

        [JsonProperty("referees", Required = Required.Always)]
        public PostRefereeParameter[] Referees { get; set; }
    }
}
