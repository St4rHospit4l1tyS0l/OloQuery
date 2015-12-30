using System;
using AlohaOrderOnLine.Infrastructure;

namespace AlohaOrderOnLine.Service
{
    public class Menus
    {
        public string GetMenuInfo(string uri, string menuId)
        {
            Console.WriteLine(string.Format("{0} ", uri + "Menus/" + menuId));
            return GetMethod.GetRequest(uri + "Menus/" + menuId);
        }
    }
}
