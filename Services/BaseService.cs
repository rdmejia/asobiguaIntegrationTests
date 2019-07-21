using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace asobiguaIntegrationTests.Services
{
    public class BaseService
    {
        protected static readonly HttpClient client = new HttpClient();
        protected static readonly string baseUrl = "https://mocktesisasobiguaapi.azurewebsites.net";

        public BaseService()
        {
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.BaseAddress = new Uri(baseUrl);
        }
    }
}
