using System;
using System.Security.Policy;
using AlohaOrderOnLine.Infrastructure;
using AlohaOrderOnLine.Service;

namespace AlohaOrderOnLine
{
    class Program
    {
        
        static void Main()
        {
            //string userGuid = AuthenticateUser();
            //Console.WriteLine(userGuid);
            Console.WriteLine(GetCustomerInfo("1"));

            //Console.WriteLine(GetSiteInfo());
            //Console.WriteLine(CreateCustomer());
            Console.ReadLine();
        }

        private static string GetSiteInfo()
        {
            var sites = new Sites();
            return sites.GetSitesInfo(Constants.URI,"1");
        }

        private static string GetCustomerInfo(string userGuid)
        {
            var getUserInfo = new GetUserInfo();
            return getUserInfo.GetCustomerInfo(Constants.URI, userGuid);
        }

        public static string AuthenticateUser()
        {
            var authenticateUser = new Authenticate();
            return authenticateUser.AuthenticateUser(Constants.URI, "rolando.starpms@hotmail.com", "+2c;s^i#$TJTDR");
                // "sales@starpms.com", "=7Q7BYbZ0cwh5h");
        }

        public static string CreateCustomer()
        {
            var createCustomer = new Customers();
            return createCustomer.CreateCustomer(Constants.URI);
        }
    }
}


