using Newtonsoft.Json;

namespace Referoo.CSharp.Models
{
    public partial class PostAccountParameter
    {
        [JsonProperty("first_name", Required = Required.Always)]
        public string FirstName { get; set; } //The first name of the child account user.

        [JsonProperty("last_name", Required = Required.Always)]
        public string LastName { get; set; } //The last name of the child account user.

        [JsonProperty("company", Required = Required.AllowNull)]
        public string Company { get; set; } //The company of the child account user.

        [JsonProperty("position", Required = Required.AllowNull)]
        public string Position { get; set; } //The position of the child account user.

        [JsonProperty("email", Required = Required.Always)]
        public string Email { get; set; } //The email address of the child account user

        [JsonProperty("phone", Required = Required.Always)]
        public string Phone { get; set; } //The phone number of the child account user.

        [JsonProperty("work_phone", Required = Required.AllowNull)]
        public string WorkPhone { get; set; } //The work phone number of the child account user

        [JsonProperty("office_phone", Required = Required.AllowNull)]
        public string OfficePhone { get; set; } //The office phone number of the child account user.

        [JsonProperty("password", Required = Required.Always)]
        public string Password { get; set; } //The password will be automatically validated and encrypted on save.

        [JsonProperty("website", Required = Required.AllowNull)]
        public string Website { get; set; } //The website of the child account.

    }
}
