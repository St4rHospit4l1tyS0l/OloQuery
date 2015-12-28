using System.Web.Script.Serialization;
using AlohaOrderOnLine.Infrastructure;
using AlohaOrderOnLine.Model;

namespace AlohaOrderOnLine.Service
{
    public class Orders
    {
        public string CreateOrder(string uri)
        {
            var userJsonData = CreateJson();
            var json = new JavaScriptSerializer().Serialize(userJsonData);
            //json = "{\"Customer\":{\"CustomerId\":{},\"Email\":\"rolando.starpms@hotmail.com\",\"FirstName\":\"Emiliano\",\"LastName\":\"Gomez\",\"BusinessName\":\"SHS-\",\"VoicePhone\":\"19286285\",\"VoicePhoneExtension\":\"123\",\"DepartmentName\":\"Desarrollo\",\"AltPhone\":\"29286285\",\"AltPhoneExtension\":\"123\",\"FavoriteSiteId\":2,\"LoyaltyCardNumber\":\"sample\",\"SecondaryEmailAddress\":\"sample\",\"Addresses\":[]},\"Password\":\"1234567890\",\"SecurityQuestion\":\"23456789\",\"SecurityAnswer\":\"asdfasdf\"}";
            return PutMethod.PutRequest(uri + "Customers/", json);
        }


         private object CreateJson()
        {
            var obj = new InOrderModel
            {
                SiteId = 0,
                OrderId = 0,
                DesignId = 0,
                MenuId = 0,



            };
            return obj;
        }
    }
}
