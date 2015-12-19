using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AlohaOrderOnLine.Infrastructure
{
    public static class PostMethod
    {
        public static string PostRequest(string uri, string json)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");

            //client.DefaultRequestHeaders.Add("Authorization", "Basic YXBpQGFvbC5uY3IuY29tOnBhc3N3b3Jk");
            HttpContent content = new StringContent(
                                    json,            
                                    Encoding.UTF8,
                                    "application/json");

            var byteArray = Encoding.ASCII.GetBytes("XRomeroLabServiceUser:d!az93SW1");
            var value = Convert.ToBase64String(byteArray);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + value);

            var response = client.PostAsync(uri, content).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(result);
            return result;
            //var request = client.PostAsync(uri, content).Result;
            //var result = request.Content.ReadAsStringAsync().Result;
            //return result;
        }
    }
}
