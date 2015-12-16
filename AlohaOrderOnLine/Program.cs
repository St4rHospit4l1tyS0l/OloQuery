using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AlohaOrderOnLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //PostExternalResponse("https://admin.aolpp.aedcg.com/");
            //GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/");
            //GetExternalResponse("https://cloudconnect.radianthosting.net/");
            //GetExternalResponse("https://cloudconnect.radianthosting.net/scpp/v1/");

            GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/sites/1");
            //GetExternalResponse2("https://cloudconnect.radianthosting.net/");
            //GetExternalResponse2("https://cloudconnect.radianthosting.net/scpp/v1/");

            //GetExternalResponse("https://api.aolpp.aedcg.com/v1");
            //GetExternalResponse2("https://api.aolpp.aedcg.com/v1");
            //GetExternalResponse3("https://api.aolpp.aedcg.com/v1");


            //GetExternalResponse("https://api.aolpp.aedcg.com/v1/Menus/1");
            //PostExternalResponse("https://api.aolpp.aedcg.com/v1/Authenticate");
            //GetExternalResponse2("https://api.aolpp.aedcg.com/ClientAdmin/");
            //GetExternalResponse3("https://api.aolpp.aedcg.com/ClientAdmin/");
        
        }

        public static string PostExternalResponse(String uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");

            //client.DefaultRequestHeaders.Add("Authorization", "Basic bWZ0K0V5c1o0Ry9YTG43Y2hvOXhaMVhGSw==");
            client.DefaultRequestHeaders.Add("Authorization", "Basic YXBpQGFvbC5uY3IuY29tOnBhc3N3b3Jk");

            HttpContent content = new StringContent("{\"Email\": \"Xavier.Romero@ncr.com\", \"Password\": \"235078\"}",
            //HttpContent content = new StringContent("{\"Email\": \"rolando.gomez@starpms.com\", \"Password\": \"password1\"}",
            //HttpContent content = new StringContent("{\"Email\": \"bily.fernandez@ncr.com\", \"Password\": \"bryan21\"}",
                                    Encoding.UTF8,
                                    "application/json");

            var request = client.PostAsync(uri, content).Result;


            //response.EnsureSuccessStatusCode();
            var result = request.Content.ReadAsStringAsync().Result;
            return result;
        }

        public static string GetExternalResponse(String uri)
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
            Console.WriteLine(result);
            return result;
        }

        public static string GetExternalResponse2(String uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");
            client.DefaultRequestHeaders.Add("Authorization", "Basic bWZ0K0V5c1o0Ry9YTG43Y2hvOXhaMVhGSw==");

            HttpContent content = new StringContent("{\"Email\": \"XRomeroLabServiceUser\", \"Password\": \"d!az93SW1\"}",
                                    Encoding.UTF8,
                                    "application/json");



            var resp2 = client.GetAsync(uri).Result;

            var result = resp2.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
            return result;
        }


        public static string GetExternalResponse3(String uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");
            client.DefaultRequestHeaders.Add("Authorization", "Basic YXBpQGFvbC5uY3IuY29tOnBhc3N3b3Jk ");

            HttpContent content = new StringContent("{\"Email\": \"Xavier.Romero@ncr.com\", \"Password\": \"235078\"}",
                                    Encoding.UTF8,
                                    "application/json");



            var resp2 = client.GetAsync(uri).Result;

            var result = resp2.Content.ReadAsStringAsync().Result;

            Console.WriteLine(result);
            return result;
        }

    }
}


