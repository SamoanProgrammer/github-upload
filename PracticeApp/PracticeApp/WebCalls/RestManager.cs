using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApp.WebCalls
{
    public class RestManager
    {
        IRestService _restService;

        public RestManager(IRestService restService)
        {
            _restService = restService;
        }

        public async Task GetTaskAsync()
        {
            await _restService.GetDataAsync();
        }
    }
}
