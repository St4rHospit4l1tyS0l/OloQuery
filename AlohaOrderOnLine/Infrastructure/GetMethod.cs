using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AlohaOrderOnLine.Infrastructure
{
    public class GetMethod
    {
        public static string GetRequest(string uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");
            /*
            HttpContent content = new StringContent("{\"Email\": \"XRomeroLabServiceUser\", \"Password\": \"d!az93SW1\"}",
                                    Encoding.UTF8,
                                    "application/json");
            */
            var byteArray = Encoding.ASCII.GetBytes("XRomeroLabServiceUser:d!az93SW1");
            var value = Convert.ToBase64String(byteArray);
            //var header = new AuthenticationHeaderValue(
            //           "Basic", value);
            //client.DefaultRequestHeaders.Authorization = header;
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + value);

            var respuesta = client.GetAsync(uri).Result;
            var result = respuesta.Content.ReadAsStringAsync().Result;
            
            return result;
        }
    }
}
