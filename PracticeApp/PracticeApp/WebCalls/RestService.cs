using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using PracticeApp.Helper;

namespace PracticeApp.WebCalls
{
    class RestService : IRestService
    {
        HttpClient _client;

        public RestService()
        {
            _client = new HttpClient();
        }

        public async Task GetDataAsync()
        {
            var uri = new Uri("https://jsonplaceholder.typicode.com/todos/1");

            
            try
            {
                var response = await _client.GetAsync(uri);
                if (response.IsSuccessStatusCode)
                {
                    var responseObj = await response.Content.ReadAsStringAsync();
                    MessagingCenter.Send(this, MessengerKeys.RESTResponse, responseObj);
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
        }
    }
}
