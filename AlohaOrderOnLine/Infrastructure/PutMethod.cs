﻿using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AlohaOrderOnLine.Infrastructure
{
    static public class PutMethod
    {
        static public string PutRequest(string uri, string json )
        {
            
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", Constants.COMPANY_CODE);
            //client.DefaultRequestHeaders.Add("Authorization", "Basic YXBpQGFvbC5uY3IuY29tOnBhc3N3b3Jk");
            HttpContent content = new StringContent(
                json
                , Encoding.UTF8, "application/json");

           var byteArray = Encoding.ASCII.GetBytes("XRomeroLabServiceUser:d!az93SW1");
            var value = Convert.ToBase64String(byteArray);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + value);

            var response = client.PutAsync(uri , content).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            //Console.WriteLine(result);
            return result;

        }
    }
}
