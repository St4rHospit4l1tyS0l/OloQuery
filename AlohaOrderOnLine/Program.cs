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
            
            //Console.WriteLine(AuthenticateUser());
            //Console.WriteLine(userGuid);
            //Console.WriteLine(GetCustomerInfo("1"));
            //Console.WriteLine(GetSiteInfo());
            //Console.WriteLine(CreateCustomer());
            Console.WriteLine(GetMenu());
            //Console.WriteLine(CreateOrder());
            Console.ReadLine();
        }

        private static string GetMenu()
        {
            var menus = new Menus();
            return menus.GetMenuInfo(Constants.URI,"2");
        }

        private static string GetSiteInfo()
        {
            var sites = new Sites();
            return sites.GetSitesInfo(Constants.URI,"2");
        }

        private static string GetCustomerInfo(string userGuid)
        {
            var getUserInfo = new GetUserInfo();
            return getUserInfo.GetCustomerInfo(Constants.URI, Constants.USER_UID);
        }

        public static string AuthenticateUser()
        {
            var authenticateUser = new Authenticate();
            return authenticateUser.AuthenticateUser(Constants.URI, Constants.USER_NAME, Constants.USER_PWD);
                // "sales@starpms.com", "=7Q7BYbZ0cwh5h");
        }

        public static string CreateCustomer()
        {
            var createCustomer = new Customers();
            return createCustomer.CreateCustomer(Constants.URI);
        }

        public static string CreateOrder()
        {
            var createOrder = new Orders();
            return createOrder.PutCreateOrder(Constants.URI, "2");
        }
    }
}


