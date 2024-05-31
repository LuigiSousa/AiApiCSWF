using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using AiWFClientApi.request;

namespace AiWFClientApi.request
{
    public class postMethod
    {
        public static String AiRequest(String Prompt)
        {
            if (Prompt == null) { return "failed"; } else { }
            var postData = new postData { prompt = Prompt };

            var client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:2007/");

            var jsonData = JsonSerializer.Serialize(postData);
            var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var response = client.PostAsync("post", content).Result;

            if (response.IsSuccessStatusCode)
            {
                var responseContent = response.Content.ReadAsStringAsync().Result;
                return responseContent;
            }else
            {
                return "Failed";
            }
        }
    }
}
