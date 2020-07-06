using Newtonsoft.Json;
using Referoo.CSharp.Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp
{
    public class Candidates
    {
        private static Guid _getCandidatesToken;
        #region Singleton Pattern

        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Candidates instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        public static Candidates Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = new Candidates();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        public GetCandidatesResponse ListCandidates(string email, Int64? offset, Int64? limit)
        {
            var url = $"candidates/?";
            if (!string.IsNullOrEmpty(email)) 
                url += $"email={email}&";

            if (offset != null)
                url += $"offset={offset}&";

            if (limit != null)
                url += $"limit={limit}&";

            var json = HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetCandidatesResponse>(json);
            return retVal;

        }

        private static string HttpGet(string URI)
        {
            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");

            var response = client.Get(request);
            var content = response.Content;

            return content;
        }
    }
}
