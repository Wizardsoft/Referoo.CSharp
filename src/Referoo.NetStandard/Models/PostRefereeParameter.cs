using Newtonsoft.Json;

namespace Referoo.NetStandard.Models
{
    public partial class PostRefereeParameter
    {
        [JsonProperty("name", Required = Required.Always)]
        public string Name { get; set; } //The name of the referee

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; } //The email address of the referee

        [JsonProperty("phone", Required = Required.Always)]
        public string Phone { get; set; } //The phone number of the referee

        [JsonProperty("relationship", Required = Required.Always)]
        public string Relationship { get; set; } //The relationship of the referee to the candidate

        [JsonProperty("notes", Required = Required.AllowNull)]
        public string Notes { get; set; } //Any notes added against the referee by a recruiter

        [JsonProperty("job_title", Required = Required.AllowNull)]
        public string JobTitle { get; set; } //The job title of the referee

        [JsonProperty("candidate_job_title", Required = Required.AllowNull)]
        public string CandidateJobTitle { get; set; } //The job title the candidate had while working with the referee

        [JsonProperty("company", Required = Required.AllowNull)]
        public string Company { get; set; } //The company the referee and candidate worked at together

        [JsonProperty("start", Required = Required.AllowNull)]
        public string Start { get; set; } //When the candidate started working with the referee

        [JsonProperty("end", Required = Required.AllowNull)]
        public string End { get; set; } //When the candidate stopped working with the referee

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public string QuestionnairesNum { get; set; } //The Questionnaire used for this reference.

        [JsonProperty("send_email_reminders", Required = Required.Always)]
        public int SendEmailReminders { get; set; } //Set to one if the referee is receiving email reminders

    }
}
