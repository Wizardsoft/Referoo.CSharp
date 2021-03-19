using Newtonsoft.Json;
using System;

namespace Referoo.NetStandard.Models
{
    public partial class GetRefereesResponse
    {
        public GetRefereesResponseData[] Data { get; set; }
    }

    public partial class GetRefereesResponseData
    {
        [JsonProperty("num")]
        public long Num { get; set; }

        [JsonProperty("createdDate")]
        public DateTimeOffset CreatedDate { get; set; }

        [JsonProperty("updatedDate")]
        public DateTimeOffset UpdatedDate { get; set; }

        [JsonProperty("unique_id")]
        public string UniqueId { get; set; }

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

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("questionnairesNum")]
        public int QuestionnairesNum { get; set; }

        [JsonProperty("membersNum")]
        public string MembersNum { get; set; }

        [JsonProperty("candidatesNum")]
        public string CandidatesNum { get; set; }

        [JsonProperty("invite_sent_date")]
        public string InviteSentDate { get; set; }

        [JsonProperty("invite_sent")]
        public int InviteSent { get; set; }

        [JsonProperty("send_email_reminders")]
        public int SendEmailReminders { get; set; }

        [JsonProperty("cancelled_reminders")]
        public int CancelledReminders { get; set; }

        [JsonProperty("reference_completed")]
        public int ReferenceCompleted { get; set; }

        [JsonProperty("custom_data")]
        public string CustomData { get; set; }

        [JsonProperty("ip_matches_candidate")]
        public bool IpMatchesCandidate { get; set; }
    }
}