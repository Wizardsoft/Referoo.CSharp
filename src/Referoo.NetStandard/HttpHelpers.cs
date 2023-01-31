using Newtonsoft.Json;
using RestSharp;
using System;
using System.Net;

namespace Referoo.NetStandard
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

            url += $"limit={limit}&";

            return url;
        }

        public static string HttpGet(string URI)
        {
            URI = URI.TrimEnd('&');
            URI = URI.TrimEnd('?');
            URI = URI.TrimEnd('/');

            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");

            var response = client.Get(request);

            if(response.StatusCode == HttpStatusCode.OK)
            {
                var content = response.Content;
                return content;
            }
            else
            {
                throw new Exception($"HttpStatusCode: {response.StatusCode}");
            }
        }

        public static byte[] DownloadData(string URI)
        {
            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");

            var response = client.DownloadData(request);

            return response;
        }

        public static string HttpPost(string URI, object body)
        {
            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            var settings = new JsonSerializerSettings() { ContractResolver = new NullToEmptyStringResolver(), NullValueHandling = NullValueHandling.Ignore };
            var jsonBody = JsonConvert.SerializeObject(body, settings);

            request.Parameters.Clear();
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");
            request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

            var response = client.Post(request);

            if (response.StatusCode == HttpStatusCode.OK || response.StatusCode == HttpStatusCode.Created)
            {
                var content = response.Content;
                return content;
            }
            else
            {
                throw new Exception($"HttpStatusCode: {response.StatusCode}. Error: {response.Content}");
            }
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

        public static string HttpDelete(string URI, object body)
        {
            var client = new RestClient(Configuration.BaseUrl);
            var request = new RestRequest(URI);

            request.AddHeader("Accept", "application/json");
            request.AddHeader("Authorization", $"Bearer {Configuration.AccessToken}");
            if (body != null)
                request.AddJsonBody(body);
            var response = client.Delete(request);

            if (response.StatusCode == HttpStatusCode.NoContent)
            {
                var content = response.Content;
                return content;
            }
            else
            {
                throw new Exception($"HttpStatusCode: {response.StatusCode}. Error: {response.Content}");
            }

        }

        public static string HttpRefreshToken(string URI, string requestParams)
        {
            var client = new RestClient(URI);
            var request = new RestRequest(Method.POST);
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddParameter("application/x-www-form-urlencoded", requestParams, ParameterType.RequestBody);
            var response = client.Execute(request);
            if (response.StatusCode == HttpStatusCode.OK)
            {
                return response.Content;
            }
            else
            {
                throw new Exception($"HttpStatusCode: {response.StatusCode}. Error: {response.Content}");
            }
        }
    }
}