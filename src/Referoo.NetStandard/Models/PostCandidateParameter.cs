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

        [JsonProperty("questionnairesNum", Required = Required.AllowNull)]
        public int QuestionnairesNum { get; set; } //The Questionnaire num of the candidate

        [JsonProperty("number_of_references_required", Required = Required.Always)]
        public int NumberOfReferencesRequired { get; set; } //The number of references required for the candidate

        [JsonProperty("one_click_reference", Required = Required.Always)]
        public int OneClickReference { get; set; } //Should Referoo automatically email Candidates and Referee's requesting references.

    }

    public partial class PostCandidateWithRefereesParameter
    {
        [JsonProperty("candidate", Required = Required.Always)]
        public PostCandidateParameter Candidate { get; set; }

        [JsonProperty("referees", Required = Required.Always)]
        public PostRefereeParameter[] Referees { get; set; }
    }
}
