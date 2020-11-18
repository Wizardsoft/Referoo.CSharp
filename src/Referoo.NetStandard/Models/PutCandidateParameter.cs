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

        [JsonProperty("phone", Required = Required.AllowNull)]
        public string Phone { get; set; }

        [JsonProperty("notes", Required = Required.AllowNull)]
        public string Notes { get; set; }

        [JsonProperty("job", Required = Required.AllowNull)]
        public string Job { get; set; }

        [JsonProperty("company", Required = Required.AllowNull)]
        public string Company { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public int QuestionnairesNum { get; set; }

        [JsonProperty("brandsNum")]
        public int? BrandsNum { get; set; }

        [JsonProperty("number_of_references_required", Required = Required.Always)]
        public int NumberOfReferencesRequired { get; set; }

        [JsonProperty("one_click_reference", Required = Required.Always)]
        public int OneClickReference { get; set; }

        [JsonProperty("send_referee_email_reminders")]
        public int SendRefereeEmailReminders { get; set; }

        [JsonProperty("send_candidate_email_reminders")]
        public int SendCandidateEmailReminders { get; set; }

        [JsonProperty("do_not_contact")]
        public int DoNotContact { get; set; }

        [JsonProperty("do_not_contact_recruiter")]
        public int DoNotContactRecruiter { get; set; }

        [JsonProperty("candidate_locked")]
        public int CandidateLocked { get; set; }

        [JsonProperty("custom_data")]
        public string CustomData { get; set; }
    }
}
