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

        public GetCandidatesResponse ListCandidates(string email = null, Int64? offset = null, Int64? limit = null)
        {
            var url = $"candidates/?";
            if (!string.IsNullOrEmpty(email)) 
                url += $"email={email}&";

            if (offset != null)
                url += $"offset={offset}&";

            if (limit != null)
                url += $"limit={limit}&";

            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetCandidatesResponse>(json);
            return retVal;

        }

        /// <summary>
        /// This API endpoint will return a json object containing a single candidate, based on the num provided in the API call.
        /// </summary>
        /// <param name="num">Numeric ID of the candidate to retrieve</param>
        /// <returns></returns>
        public GetCandidatesResponse RetrieveCandidate(Int64 num)
        {
            var url = $"candidate/{num}";
            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetCandidatesResponse>(json);
            return retVal;
        }

        public GetRefereesResponse RetrieveCandidatesReferees(Int64 num)
        {
            var url = $"candidate/{num}/referees";
            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetRefereesResponse>(json);
            return retVal;
        }


    }
}
