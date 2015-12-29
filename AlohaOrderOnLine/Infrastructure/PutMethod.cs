using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace AlohaOrderOnLine.Infrastructure
{
    static public class PutMethod
    {
        static public string PutRequest(string uri, string json )
        {
            json = "{  " +
                   "  \"Customer\":{  " +
                   "     \"CustomerId\": \"{998e8e40-433a-4be0-bcc3-c65ba58a576b}\"," +
                   "     \"Email\":\"rolando.starpms76@hotmail.com\", " +
                   "     \"FirstName\":\"Emiliano\", " +
                   "     \"LastName\":\"Gomez\", " +
                   "     \"BusinessName\":\"SHS-\", " +
                   "     \"VoicePhone\":\"19286285\", " +
                   "     \"VoicePhoneExtension\":\"123\", " +
                   "     \"DepartmentName\":\"Desarrollo\", " +
                   "     \"AltPhone\":\"29286285\", " +
                   "     \"AltPhoneExtension\":\"123\", " +
                   "     \"FavoriteSiteId\":2, " +
                   "     \"LoyaltyCardNumber\":\"sample\", " +
                   "     \"SecondaryEmailAddress\":\"rolando.starpms@hotmail.com\", " +
                   "     \"Addresses\":[{" +
                   
                   " \"AddressId\": 0, " +
        "\"AddressType\": \"\", " +
        "\"IsDefault\": false, " +
        "\"Description\": \"\", " +
        "\"DepartmentName\": \"\", " +
        "\"AddressLine1\": \"\", " +
        "\"AddressLine2\": \"\", " +
        "\"City\": \"\", " +
        "\"State\": \"LAX\", " +
        "\"Postal\": \"54172\" " +
        //"\"ExtraData\": [ " +
        //"  { " +
        //"    \"Key\": \"\", " +
        //"    \"Value\": \"\" " +
        //"  } " +
        //"] " +

                   "}], " +
                   //"     \"Birthday\":null, " +
                   //"     \"LoyaltyZipCode\":null, " +
                   "     \"FacebookId\":0 " +
                   "  }, " +
                   "  \"Password\":\"pwd123456789\", " +
                   "  \"SecurityQuestion\":\"sec quest\", " +
                   "  \"SecurityAnswer\":\"sec answ\" }";

            var client = new HttpClient();
            client.DefaultRequestHeaders
            .Accept
            .Add(new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Add("X-Api-CompanyCode", "PHSP001");
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
