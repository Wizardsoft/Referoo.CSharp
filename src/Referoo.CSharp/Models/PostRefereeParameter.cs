using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp.Models
{
    public partial class PostRefereeParameter
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; }

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; }

        [JsonProperty("phone", Required = Required.Always)]
        public string Phone { get; set; }

        [JsonProperty("relationship", Required = Required.Always)]
        public string Relationship { get; set; }

        [JsonProperty("notes", Required = Required.AllowNull)]
        public string Notes { get; set; }

        [JsonProperty("job_title", Required = Required.AllowNull)]
        public string JobTitle { get; set; }

        [JsonProperty("candidate_job_title", Required = Required.AllowNull)]
        public string CandidateJobTitle { get; set; }

        [JsonProperty("company", Required = Required.AllowNull)]
        public string Company { get; set; }

        [JsonProperty("start", Required = Required.AllowNull)]
        public string Start { get; set; }

        [JsonProperty("end", Required = Required.AllowNull)]
        public string End { get; set; }

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public string QuestionnairesNum { get; set; }

        [JsonProperty("send_email_reminders", Required = Required.Always)]
        public int SendEmailReminders { get; set; }

    }
}
