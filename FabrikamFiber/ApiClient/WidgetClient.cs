using RestSharp;
using System;

namespace ApiClient
{
    public class WidgetClient
    {
        public object Get(int id)
        {
            var client = new RestClient("http://localhost:11709/api");
            var request = new RestRequest($"Widget/{id}", Method.GET);

            var response = client.Execute(request);

            return response.Content;
        }
    }
}
