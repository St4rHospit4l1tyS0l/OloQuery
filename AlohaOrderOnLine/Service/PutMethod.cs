using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Script.Serialization;
using AlohaOrderOnLine.Model;
using Newtonsoft.Json;


namespace AlohaOrderOnLine.Service
{
    public class PutMethod
    {
        public string PutCreateCustomer(string uri)
        {
            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");

            var myJsonData = CreateJson();

            var json = new JavaScriptSerializer().Serialize(myJsonData);

            json = "{\"Customer\":{\"CustomerId\":\"84520b34-c250-430c-8d11-ef5be3b2e6a7\",\"Email\":\"rolando.starpms@hotmail.com\",\"FirstName\":\"Emiliano\",\"LastName\":\"Gomez\",\"BusinessName\":\"SHS-\",\"VoicePhone\":\"19286285\",\"VoicePhoneExtension\":\"123\",\"DepartmentName\":\"Desarrollo\",\"AltPhone\":\"29286285\",\"AltPhoneExtension\":\"123\",\"FavoriteSiteId\":2,\"LoyaltyCardNumber\":\"sample\",\"SecondaryEmailAddress\":\"sample\",\"Addresses\":[{\"AddressId\":5,\"AddressType\":1,\"IsDefault\":true,\"Description\":\"del casco\",\"DepartmentName\":\"123\",\"AddressLine1\":\"sample string\",\"AddressLine2\":\"sample string\",\"City\":\"sample string\",\"State\":\"LAX\",\"Postal\":\"54172\"]},},\"Password\":\"1234567890\",\"SecurityQuestion\":\"23456789\",\"SecurityAnswer\":\"asdfasdf\"}";  
            //client.DefaultRequestHeaders.Add("Authorization", "Basic YXBpQGFvbC5uY3IuY29tOnBhc3N3b3Jk");
            HttpContent content = new StringContent(
                json
                , Encoding.UTF8, "application/json");

           var byteArray = Encoding.ASCII.GetBytes("XRomeroLabServiceUser:d!az93SW1");
            var value = Convert.ToBase64String(byteArray);
            client.DefaultRequestHeaders.Add("Authorization", "Basic " + value);

            var response = client.PutAsync(uri , content).Result;
            var result = response.Content.ReadAsStringAsync().Result;
            Console.WriteLine(result);
            return result;
        }

        private static object CreateJson()
        {
            var obj = new RegistrationModel
            {
                Customer = new CustomerModel
                {
                    CustomerId = new Guid("84520b34-c250-430c-8d11-ef5be3b2e6a7"),
                    Email = "rolando.starpms@hotmail.com",
                    FirstName = "Emiliano",
                    LastName = "Gomez",
                     BusinessName = "SHS-",
                      VoicePhone= "19286285",
                       VoicePhoneExtension= "123",
                    DepartmentName = "Desarrollo",
                    AltPhone = "29286285",
                    AltPhoneExtension= "123",
                    FavoriteSiteId= 2,
                    LoyaltyCardNumber = "sample",
                    SecondaryEmailAddress = "sample",
                    Addresses = new AddressesModel
                    {
                        AddressId = 5,
                        AddressType = 1,
                        IsDefault = true,
                        Description = "del casco",
                        DepartmentName = "123",
                        AddressLine1 = "sample string",
                        AddressLine2 = "sample string",
                        City = "sample string",
                        State = "LAX",
                        Postal= "54172",
                        ExtraData = new ExtraDataModel
                        {
                            Key = "",
                            Value = ""
                        }
                    },
                    Birthday = "1980-11-19T14:28:36.337238-05:00",
                    LoyaltyZipCode = "",
                    FacebookId = 10,
                }
                ,Password = "1234567890",
                SecurityQuestion = "23456789",
                SecurityAnswer = "asdfasdf"
            };
            return obj;
        }




    }
}
