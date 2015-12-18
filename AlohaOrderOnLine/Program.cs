using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using AlohaOrderOnLine.Service;

namespace AlohaOrderOnLine
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //ExecPostMethods();
            //ExecGetMethods();
            ExecPutMethods();

        }

        private static void ExecPutMethods()
        {
            var putmethods = new PutMethod();
            putmethods.PutCreateCustomer("https://cloudconnect.radianthosting.net/aoopreprod/v1/Customers/");
        }

        private static void ExecGetMethods()
        {
            //GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/sites/1");
            //GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/Menus/1/1000");
            GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/sites/1");
            // GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/Menus/1/1");
            //GetExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/Instructions");
        }

        private static void ExecPostMethods()
        {
            PostExternalResponse("https://cloudconnect.radianthosting.net/aoopreprod/v1/");
        }

        public static string PostExternalResponse(String uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");

            //client.DefaultRequestHeaders.Add("Authorization", "Basic YXBpQGFvbC5uY3IuY29tOnBhc3N3b3Jk");
            HttpContent content = new StringContent("{}",            
                                    Encoding.UTF8,
                                    "application/json");

            var byteArray = Encoding.ASCII.GetBytes("XRomeroLabServiceUser:d!az93SW1");
            var value = Convert.ToBase64String(byteArray);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + value);

            var response = client.PostAsync(uri, content).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            return result;
            //var request = client.PostAsync(uri, content).Result;
            //var result = request.Content.ReadAsStringAsync().Result;
            //return result;
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
    }
}


