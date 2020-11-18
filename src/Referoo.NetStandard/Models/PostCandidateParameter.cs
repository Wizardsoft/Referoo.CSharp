using Newtonsoft.Json;

namespace Referoo.NetStandard.Models
{
    public partial class PostCandidateParameter
    {
        [JsonProperty("first_name", Required = Required.Always)]
        public string FirstName { get; set; } //The candidates first name

        [JsonProperty("last_name", Required = Required.Always)]
        public string LastName { get; set; } //The candidates last name

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; } //The Candidates email

        [JsonProperty("phone", Required = Required.AllowNull)]
        public string Phone { get; set; } //The Candidates phone number

        [JsonProperty("notes", Required = Required.AllowNull)]
        public string Notes { get; set; } //Notes on the Candidate

        [JsonProperty("job", Required = Required.AllowNull)]
        public string Job { get; set; } //The new job the candidate is applying for

        [JsonProperty("company", Required = Required.AllowNull)]
        public string Company { get; set; } //The candidates client company

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; } //The IP address of the candidate. This is checked against the referee IP address to see if they match.

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public int QuestionnairesNum { get; set; } //The Questionnaire num of the candidate

        [JsonProperty("brandsNum")]
        public int? BrandsNum { get; set; } //The ID of the brand that is linked to candidate. An error will be returned if the user does not have access to the brand system.

        [JsonProperty("number_of_references_required", Required = Required.Always)]
        public int NumberOfReferencesRequired { get; set; } //The number of references required for the candidate

        [JsonProperty("one_click_reference", Required = Required.Always)]
        public int OneClickReference { get; set; } //Should Referoo automatically email Candidates and Referee's requesting references.

        [JsonProperty("send_referee_email_reminders")]
        public int SendRefereeEmailReminders { get; set; } //Should we send this candidate's referees email reminders asking them to complete their references? These are sent after a referee is sent a reference dash email.

        [JsonProperty("send_candidate_email_reminders")]
        public int SendCandidateEmailReminders { get; set; } //Should send this candidate email reminders asking them to complete their references via email? These are only sent after a candidate has received a candidate dash email.

        [JsonProperty("do_not_contact")]
        public int DoNotContact { get; set; } //If set, Referoo will not send the candidate any emails as they go through the reference process. Note - If one_click_reference is enabled, Referoo still sends the referee request dash and reference request dash emails to the candidate and referee, but will not send the candidate referee confirmation email (which is sent when using the Quick Referee endpoint).

        [JsonProperty("do_not_contact_recruiter")]
        public int DoNotContactRecruiter { get; set; } //If set, Referoo will not send the recruiter any update emails as the candidate's references are processed.

        [JsonProperty("candidate_locked")]
        public int CandidateLocked { get; set; } //If set, the recruiter will not be able to update the candidate via the Referoo UI and all update actions must happen via the API.

        [JsonProperty("custom_data")]
        public string CustomData { get; set; } //This property allows you to store custom values against the referee.

    }

    public partial class PostCandidateWithRefereesParameter
    {
        [JsonProperty("candidate", Required = Required.Always)]
        public PostCandidateParameter Candidate { get; set; }

        [JsonProperty("referees", Required = Required.Always)]
        public PostRefereeParameter[] Referees { get; set; }
    }
}
