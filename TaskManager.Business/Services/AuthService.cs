using Newtonsoft.Json;
using System.Net.Http;
using System.Text;
using TaskManager.Core.Models;

namespace TaskManager.Business.Services
{
    public class AuthService
    {
        private readonly string baseApi = "http://localhost/Hotel-Management-System-main/api/";
        private readonly HttpClient client = new HttpClient();

        public User Login(string username, string password)
        {
            var payload = new
            {
                username,
                password
            };

            var content = new StringContent(
                JsonConvert.SerializeObject(payload),
                Encoding.UTF8,
                "application/json"
            );

            var response = client.PostAsync(baseApi + "login", content).Result;
            var json = response.Content.ReadAsStringAsync().Result;

            if (!response.IsSuccessStatusCode)
                return null;

            if (string.IsNullOrWhiteSpace(json))
                return null;

            if (json.TrimStart().StartsWith("<"))
                return null; // HTML error protection

            if (json.Contains("error"))
                return null;

            return JsonConvert.DeserializeObject<User>(json);
        }
    }
}