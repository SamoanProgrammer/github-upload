using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace PracticeApp.WebCalls
{
    class RestService : IRestService
    {
        HttpClient _client;
        public string Response { get; set; }

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task<string> GetDataAsync()
        {
            var uri = new Uri("http://dummy.restapiexample.com/api/v1/employee/1");

            Response = string.Empty;
            
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    Response = await response.Content.ReadAsStringAsync();
                }
                else
                {
                    Debug.WriteLine($"{response.StatusCode} - {response.ToString()}");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"\tERROR {0}", ex.Message);
            }

            return Response;
        }
    }
}
