using System.Web.Script.Serialization;
using AlohaOrderOnLine.Infrastructure;
using AlohaOrderOnLine.Model;

namespace AlohaOrderOnLine.Service
{
    public class Orders
    {
        public string PutCreateOrder(string uri, string siteId)
        {
            var userJsonData = CreateJson();
            //var json = new JavaScriptSerializer().Serialize(userJsonData);
            string json = "{\"SiteId\":1,\"OrderId\":0,\"DesignId\":0,\"MenuId\":1000,\"PromiseDateTime\":\"2015-12-30T16:14:50.00\",\"LineItems\":[{\"$id\":\"261\",\"ItemLineNumber\":1,\"MenuItemId\":1129,\"SalesItemId\":2129,\"POSItemId\":14028,\"SpecialInstructions\":\"SpecialInstructions\",\"RecipientName\":\"RecipientName\",\"Quantity\":1,\"NextModifierSequenceNumber\":0,\"ItemOrderingMode\":\"02\",\"UnitPriceOverride\":0,\"EnablePriceOverride\":false}],\"OrderMode\":\"Delivery\",\"UpdateTimeDisabled\":false,\"PaymentMode\":\"PaidOnline\",\"OrderSource\":\"Web\",\"Destination\":\"\",\"ShouldManualRelease\":false,\"TaxJurisdictionId\":0,\"Customer\":{\"Email\":\"rolando.gomez@gmail.com\",\"FirstName\":\"Rolando\",\"LastName\":\"Gomez\",\"BusinessName\":\"SHS-123\",\"VoicePhone\":\"19286285\",\"VoicePhoneExtension\":\"123\",\"DepartmentName\":\"Desarrollo\",\"AltPhone\":\"29286285\",\"AltPhoneExtension\":\"123\",\"FavoriteSiteId\":2,\"LoyaltyCardNumber\":\"sample\",\"SecondaryEmailAddress\":\"rolando.starpms@hotmail.com\",\"Addresses\":[{\"AddressId\":0,\"AddressType\":\"\",\"IsDefault\":false,\"Description\":\"\",\"DepartmentName\":\"\",\"AddressLine1\":\"\",\"AddressLine2\":\"\",\"City\":\"GRANADA\",\"State\":\"GA\",\"Postal\":\"18001\"}],\"FacebookId\":0},\"CustomerAddressForOrder\":{\"AddressId\":0,\"AddressType\":\"\",\"IsDefault\":false,\"Description\":\"\",\"DepartmentName\":\"\",\"AddressLine1\":\"\",\"AddressLine2\":\"\",\"City\":\"GRANADA\",\"State\":\"GA\",\"Postal\":\"18001\"},\"SpecialInstructions\":\"\",\"LoyaltyNumber\":\"\",\"CompId\":0,\"ReferenceNumber\":0}";
            //json = "{\"Customer\":{\"CustomerId\":{},\"Email\":\"rolando.starpms@hotmail.com\",\"FirstName\":\"Emiliano\",\"LastName\":\"Gomez\",\"BusinessName\":\"SHS-\",\"VoicePhone\":\"19286285\",\"VoicePhoneExtension\":\"123\",\"DepartmentName\":\"Desarrollo\",\"AltPhone\":\"29286285\",\"AltPhoneExtension\":\"123\",\"FavoriteSiteId\":2,\"LoyaltyCardNumber\":\"sample\",\"SecondaryEmailAddress\":\"sample\",\"Addresses\":[]},\"Password\":\"1234567890\",\"SecurityQuestion\":\"23456789\",\"SecurityAnswer\":\"asdfasdf\"}";
            return PutMethod.PutRequest(uri + "Orders/" + siteId + "?verbose=True", json);
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
