using Newtonsoft.Json;
using Referoo.CSharp.Models;
using System;

namespace Referoo.CSharp
{
    public class Accounts
    {
        #region Singleton Pattern
        //private static variables for the singleton pattern
        private static object syncObject = new object();
        private static Accounts instance = null;

        /// <summary>
        /// Singleton pattern implementation
        /// </summary>
        public static Accounts Instance
        {
            get
            {
                lock (syncObject)
                {
                    if (instance == null)
                    {
                        instance = new Accounts();
                    }
                }
                return instance;
            }
        }
        #endregion Singleton Pattern

        /// <summary>
        /// This endpoint will return a list of accounts linked to the recruiters parent account in order of last name then first name.
        /// </summary>
        /// <param name="offset">The number of items to skip before starting to collect the result set</param>
        /// <param name="limit">The numbers of items to return. Up to 50 items can be returned at a time</param>
        /// <returns></returns>
        public GetAccountsResponse ListChildAccounts(long offset = 0, long limit = 50)
        {
            var url = $"accounts/?";

            url = HttpHelpers.OffSetsandLimits(url, offset, limit);

            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetAccountsResponse>(json);
            return retVal;
        }

        /// <summary>
        /// This API endpoint will return a json object containing a single account based on the ID provided in the API call
        /// </summary>
        /// <param name="num">Numeric ID of the account to retrieve</param>
        /// <returns></returns>
        public GetAccountsResponse RetrieveSingleChildAccount(long num)
        {
            var url = $"account/{num}";
            var json = HttpHelpers.HttpGet(url);
            var retVal = JsonConvert.DeserializeObject<GetAccountsResponse>(json);
            return retVal;
        }


        /// <summary>
        /// This endpoint will create a new child account under the recruiter using the API.
        /// </summary>
        /// <param name="data">Data of account to create</param>
        /// <returns></returns>
        public GetAccountsResponse CreateAccount(PostAccountParameter data)
        {
            var url = $"account";
            var json = HttpHelpers.HttpPost(url, data);
            var retVal = JsonConvert.DeserializeObject<GetAccountsResponse>(json);
            return retVal;
        }

        /// <summary>
        /// This API end point will update a child account based on the ID passed in the call. Pass a JSON object containing the variables you wish to update.
        /// </summary>
        /// <param name="num">Numeric ID of the account to update</param>
        /// <param name="data">Data of account to update</param>
        /// <returns></returns>
        public GetAccountsResponse UpdateChildAccount(long num, PostAccountParameter data)
        {
            var url = $"account/{num}";
            var json = HttpHelpers.HttpPut(url, data);
            var retVal = JsonConvert.DeserializeObject<GetAccountsResponse>(json);
            return retVal;
        }

    }
}
