using Newtonsoft.Json;

namespace Referoo.NetStandard.Models
{
    public partial class PutCandidateParameter
    {
        [JsonProperty("first_name", Required = Required.Always)]
        public string FirstName { get; set; }

        [JsonProperty("last_name", Required = Required.Always)]
        public string LastName { get; set; }

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public int QuestionnairesNum { get; set; }

        [JsonProperty("number_of_references_required", Required = Required.Always)]
        public int NumberOfReferencesRequired { get; set; }

        public int CandidateLocked { get; set; }

        [JsonProperty("archived")]
        public int Archived { get; set; }
    }
}
