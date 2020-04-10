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

        public Task<string> GetTaskAsync()
        {
            return _restService.GetDataAsync();
        }
    }
}
