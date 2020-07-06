using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace Referoo.CSharp
{
    public static class HttpHelpers
    {
        public static string HttpGet(string URI)
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
