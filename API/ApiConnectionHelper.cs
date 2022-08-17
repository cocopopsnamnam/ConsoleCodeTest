using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public static class ApiConnectionHelper
    {
        public static HttpClient ApiConnection { get; set; }

        public static void InitializeConnection()
        {
            ApiConnection = new HttpClient();
            ApiConnection.DefaultRequestHeaders.Accept.Clear();
            ApiConnection.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
