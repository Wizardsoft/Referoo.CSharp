using RestSharp;

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
