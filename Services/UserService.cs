using System;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using asobiguaIntegrationTests.Models;
using Newtonsoft.Json;

namespace asobiguaIntegrationTests.Services
{
    public class UserService : BaseService
    {
        public async System.Threading.Tasks.Task<User> LoginAsync(string username, string password)
        {
            var json = JsonConvert.SerializeObject(new { username, password });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("/v1/users/login", content);

            if(response.IsSuccessStatusCode)
            {
                var stream = await response.Content.ReadAsStreamAsync();
                var serializer = new DataContractJsonSerializer(typeof(User));

                var user = serializer.ReadObject(stream) as User;

                return user;
            }

            return null;
        }
    }
}
