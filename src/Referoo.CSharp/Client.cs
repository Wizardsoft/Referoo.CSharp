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
        /// <param name="baseUrl"></param>
        public ReferooClient(string accessToken, string refreshToken = "", string baseUrl = "https://api.sandbox.referoo.com.au/oauth2/")
        {
            if (string.IsNullOrEmpty(accessToken))
                throw new Exception("Empty AccessToken not Allowed");

            if (string.IsNullOrEmpty(baseUrl))
                throw new Exception("Empty BaseUrl not Allowed");

            Configuration.BaseUrl = baseUrl;
            Configuration.AccessToken = accessToken;
            Configuration.RefreshToken = refreshToken;
        }

        //public Numbers Numbers
        //{
        //    get { return Numbers.Instance; }
        //}
    }
}