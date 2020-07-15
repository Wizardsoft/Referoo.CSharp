using Newtonsoft.Json;

namespace Referoo.CSharp.Models
{
    public partial class PutCandidateParameter
    {
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
    }
}
