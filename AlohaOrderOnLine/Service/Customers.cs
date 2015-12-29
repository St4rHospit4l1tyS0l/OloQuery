using System;
using System.Web.Script.Serialization;
using AlohaOrderOnLine.Infrastructure;
using AlohaOrderOnLine.Model;


namespace AlohaOrderOnLine.Service
{
    public class Customers
    {
        public string CreateCustomer(string uri)
        {
            //var userJsonData = CreateJson();
            //var json = new JavaScriptSerializer().Serialize(userJsonData);

            string json = "{  " +
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


            //json = "{\"Customer\":{\"CustomerId\":{},\"Email\":\"rolando.starpms@hotmail.com\",\"FirstName\":\"Emiliano\",\"LastName\":\"Gomez\",\"BusinessName\":\"SHS-\",\"VoicePhone\":\"19286285\",\"VoicePhoneExtension\":\"123\",\"DepartmentName\":\"Desarrollo\",\"AltPhone\":\"29286285\",\"AltPhoneExtension\":\"123\",\"FavoriteSiteId\":2,\"LoyaltyCardNumber\":\"sample\",\"SecondaryEmailAddress\":\"sample\",\"Addresses\":[]},\"Password\":\"1234567890\",\"SecurityQuestion\":\"23456789\",\"SecurityAnswer\":\"asdfasdf\"}";
            return PutMethod.PutRequest(uri + "Customers/", json);
        }

        private object CreateJson()
        {
            var obj = new RegistrationModel
            {
                Customer = new CustomerModel
                {
                    //CustomerId = new Guid("84520b34-c250-430c-8d11-ef5be3b2e6a7"),
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
                    SecondaryEmailAddress = "sample"
                    }
                //    Addresses = new AddressesModel
                //    {
                //        AddressId = 5,
                //        AddressType = 1,
                //        IsDefault = true,
                //        Description = "del casco",
                //        DepartmentName = "123",
                //        AddressLine1 = "sample string",
                //        AddressLine2 = "sample string",
                //        City = "sample string",
                //        State = "LAX",
                //        Postal= "54172",
                //        ExtraData = new ExtraDataModel
                //        {
                //            Key = "",
                //            Value = ""
                //        }
                //    },
                //    Birthday = "1980-11-19T14:28:36.337238-05:00",
                //    LoyaltyZipCode = "",
                //    FacebookId = 10,
                //}
                //,Password = "1234567890",
                //SecurityQuestion = "23456789",
                //SecurityAnswer = "asdfasdf"
            };
            return obj;
        }
    }
}
