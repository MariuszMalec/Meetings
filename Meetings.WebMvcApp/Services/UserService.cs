using Meetings.WebMvcApp.Models;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Text;

namespace Meetings.WebMvcApp.Services
{
    public class UserService
    {
        IHttpClientFactory httpClientFactory;
        private const string AppiUrl = "https://localhost:7085/api";

        public UserService(IHttpClientFactory httpClientFactory)
        {
            this.httpClientFactory = httpClientFactory;
        }

        public async Task<List<UserView>> GetAll()
        {

            HttpClient client = httpClientFactory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"{AppiUrl}/Users");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            var result = await client.SendAsync(request);

            var content = await result.Content.ReadAsStringAsync();

            var trainers = JsonConvert.DeserializeObject<List<UserView>>(content);

            return trainers;
        }

        public async Task<UserView> GetById(int id)
        {

            HttpClient client = httpClientFactory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Get, $"{AppiUrl}/Users/{id}");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Headers.Add("Accept", "application/json");

            var result = await client.SendAsync(request);

            if (!result.IsSuccessStatusCode)
            {
                return null;
            }

            var content = await result.Content.ReadAsStringAsync();

            var model = JsonConvert.DeserializeObject<UserView>(content);

            return model;
        }

        public async Task<bool> Create(UserView model)
        {

            HttpClient client = httpClientFactory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Post, $"{AppiUrl}/Users");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var result = await client.SendAsync(request);

            return true;
        }

        public async Task<bool> Delete(int id, UserView model)
        {

            HttpClient client = httpClientFactory.CreateClient();

            var request = new HttpRequestMessage(HttpMethod.Delete, $"{AppiUrl}/Users/{model.Id}");

            request.Headers.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");

            var result = await client.SendAsync(request);

            if (!result.IsSuccessStatusCode)
            {
                return false;
            }

            return true;
        }

    }
}
