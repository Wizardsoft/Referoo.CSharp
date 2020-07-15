using RestSharp;
using System;

namespace Referoo.CSharp
{
    public static class HttpHelpers
    {
        public static string OffSetsandLimits(string url, long offset, long limit)
        {
            if (offset < 0)
                offset = 0;

            if (limit > 50)
                limit = 50;

            if (offset != 0)
                url += $"offset={offset}&";

            if (limit != 50)
                url += $"limit={limit}&";

            return url;
        }

        public static string HttpGet(string URI)
        {
            URI = URI.TrimEnd('&');
            URI = URI.TrimEnd('?');

            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");

            var response = client.Get(request);

            if(response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var content = response.Content;
                return content;
            }
            else
            {
                throw new Exception($"HttpStatusCode: {response.StatusCode}");
            }
        }

        public static string HttpPost(string URI, object body)
        {
            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");
            request.AddJsonBody(body);

            var response = client.Post(request);
            var content = response.Content;

            return content;
        }

        public static string HttpPut(string URI, object body)
        {
            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");
            if (body != null)
                request.AddJsonBody(body);

            var response = client.Put(request);
            var content = response.Content;

            return content;
        }
    }
}
