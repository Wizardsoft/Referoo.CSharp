using Newtonsoft.Json;

namespace Referoo.NetStandard.Models
{
    public partial class PutRefereeParameter
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("relationship")]
        public string Relationship { get; set; }

        [JsonProperty("notes")]
        public string Notes { get; set; }

        [JsonProperty("job_title")]
        public string JobTitle { get; set; }

        [JsonProperty("candidate_job_title")]
        public string CandidateJobTitle { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("start")]
        public string Start { get; set; }

        [JsonProperty("end")]
        public string End { get; set; }

        [JsonProperty("questionnairesNum")]
        public int QuestionnairesNum { get; set; }

        [JsonProperty("send_email_reminders")]
        public bool SendEmailReminders { get; set; }

        [JsonProperty("custom_data")]
        public string CustomData { get; set; }
    }
}
