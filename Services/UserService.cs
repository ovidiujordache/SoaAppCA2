using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Diagnostics;
using WebApiCA2MobileApp.Models;

namespace WebApiCA2MobileApp.Services
{
   
    internal class UserService:IUserService
    {
        JsonSerializerOptions _serializerOptions;
        HttpClient _client;
        public UserService() {
            _client = new HttpClient();
            _serializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
        }
        public List<User> User { get; private set; }

        public async Task<List<User>> RefreshUserDataAsync()
        {
            User = new List<User>();
            Uri uri = new Uri("https://webapica2.azurewebsites.net/api/User");
            try
            {
                HttpResponseMessage response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    string content = await response.Content.ReadAsStringAsync();
                    User = JsonSerializer.Deserialize<List<User>>(content, _serializerOptions);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return User;

        }


    }
}

