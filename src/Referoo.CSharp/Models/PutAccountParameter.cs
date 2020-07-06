using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp.Models
{
    public partial class PutAccountParameter
    {
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        public string LastName { get; set; }

        [JsonProperty("company")]
        public string Company { get; set; }

        [JsonProperty("position")]
        public string Position { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("phone")]
        public string Phone { get; set; }

        [JsonProperty("work_phone")]
        public string WorkPhone { get; set; }

        [JsonProperty("office_phone")]
        public string OfficePhone { get; set; }

        [JsonProperty("password")]
        public string Password { get; set; }

        [JsonProperty("website")]
        public string Website { get; set; }

    }
}
