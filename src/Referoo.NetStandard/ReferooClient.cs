using Newtonsoft.Json;
using Referoo.NetStandard.Models;
using System;
using System.Net;

namespace Referoo.NetStandard
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

        public RefreshTokenResponse RefreshToken(string clientId, string clientSecret)
        {
            if (string.IsNullOrEmpty(Configuration.RefreshToken))
                throw new Exception("Empty RefreshToken cannot be used");

            string refreshEndpoint = "https://api.referoo.com.au/oauth/token";
            refreshEndpoint += $"?client_id={clientId}&client_secret={clientSecret}&grant_type=refresh_token&refresh_token={Configuration.RefreshToken}";
            var json = HttpHelpers.HttpPost(refreshEndpoint, null);
            var obj = JsonConvert.DeserializeObject<RefreshTokenResponse>(json);
            Configuration.AccessToken = obj.AccessToken;
            Configuration.RefreshToken = obj.RefreshToken;
            return obj;
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

        public Brands Brands
        {
            get { return Brands.Instance; }
        }
    }
}