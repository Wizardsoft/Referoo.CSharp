using System;

namespace Referoo.CSharp
{
    public partial class ReferooClient
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="accessToken"></param>
        /// <param name="refreshToken"></param>
        /// <param name="sandBox"></param>
        public ReferooClient(string accessToken, string refreshToken = "", bool sandBox = false)
        {
            string baseUrl = "https://api.referoo.com.au/oauth2/";

            if(sandBox)
                baseUrl = "https://api.sandbox.referoo.com.au/oauth2/";

            if (string.IsNullOrEmpty(accessToken))
                throw new Exception("Empty AccessToken not Allowed");

            if (string.IsNullOrEmpty(baseUrl))
                throw new Exception("Empty BaseUrl not Allowed");

            Configuration.BaseUrl = baseUrl;
            Configuration.AccessToken = accessToken;
            Configuration.RefreshToken = refreshToken;
        }

        public Accounts Accounts
        {
            get { return Accounts.Instance; }
        }

        public Candidates Candidates
        {
            get { return Candidates.Instance; }
        }

        public Questionnaires Questionnaires
        {
            get { return Questionnaires.Instance; }
        }

        public Referees Referees
        {
            get { return Referees.Instance; }
        }
    }
}