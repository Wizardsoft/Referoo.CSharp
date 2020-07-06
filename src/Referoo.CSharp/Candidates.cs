using Newtonsoft.Json;
using Referoo.CSharp.Models;
using System;

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

        /// <summary>
        /// This endpoint will return a list of candidates linked to your account in order of creation date. A maximum of 50 can be returned at a time, 20 are returned by default.
        /// </summary>
        /// <param name="email">Filter the candidates using a full or partial email address</param>
        /// <param name="offset">The number of items to skip before starting to collect the result set</param>
        /// <param name="limit">The numbers of items to return. Up to 50 items can be returned at a time, 25 are returned by default</param>
        /// <returns></returns>
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

        /// <summary>
        /// This API endpoint will return a json object containing all of the referees a candidate has based on the record num provided in the API call.
        /// </summary>
        /// <param name="num">Numeric ID of the candidates referee's to retrieve</param>
        /// <returns></returns>
        public GetRefereesResponse RetrieveCandidatesReferees(Int64 num)
        {
            var url = $"candidate/{num}/referees";
            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetRefereesResponse>(json);
            return retVal;
        }

        /// <summary>
        /// This endpoint will create a candidate and add them to Referoo. If you want the candidate to be emailed right away requesting referee's, ensure the variable one_click_reference is set to 1.
        /// </summary>
        /// <param name="data">Data of candidate to create</param>
        /// <returns></returns>
        public GetCandidatesResponse CreateCandidate(PostCandidateParameter data)
        {
            var url = $"candidate";
            var json = HttpHelpers.HttpPost(url, data);
            var retVal = JsonConvert.DeserializeObject<GetCandidatesResponse>(json);
            return retVal;
        }

        /// <summary>
        /// This endpoint will create a new candidate and create a new referee for them with one call. You can add up to 5 referee's per candidate. The referee will also be sent a reference request email.
        /// </summary>
        /// <param name="data">Data of candidate and referees to be created</param>
        /// <returns></returns>
        public GetCandidateWithRefereesResponse CreateCandidateWithReferees(PostCandidateWithRefereesParameter data)
        {
            var url = $"referee/quick";
            var json = HttpHelpers.HttpPost(url, data);
            var retVal = JsonConvert.DeserializeObject<GetCandidateWithRefereesResponse>(json);
            return retVal;
        }

        /// <summary>
        /// This API end point will update a candidate based on the record num passed in the call. Pass a JSON object containing the variables you wish to update.
        /// </summary>
        /// <param name="num">Numeric ID of the candidate to update</param>
        /// <param name="data">You do not need to update all the variables, only pass those you wish to update.</param>
        /// <returns></returns>
        public GetCandidatesResponse UpdateCandidate(Int64 num, PutCandidateParameter data)
        {
            var url = $"candidate/{num}";
            var json = HttpHelpers.HttpPut(url, data);
            var retVal = JsonConvert.DeserializeObject<GetCandidatesResponse>(json);
            return retVal;
        }

        /// <summary>
        /// This API endpoint will send the candidate a reference request email.
        /// </summary>
        /// <param name="num">Numeric ID of the candidate to email</param>
        /// <returns></returns>
        public string SendCandidateReferenceRequestEmail(Int64 num)
        {
            var url = $"candidate/{num}/email";
            var json = HttpHelpers.HttpPut(url, null);
            return json;
        }


    }
}
