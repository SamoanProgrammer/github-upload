using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PracticeApp.WebCalls
{
    public interface IRestService
    {
        Task<string> GetDataAsync();
    }
}
