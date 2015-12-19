using AlohaOrderOnLine.Infrastructure;
using System;

namespace AlohaOrderOnLine.Service
{
    public class Sites
    {
        public string GetSitesInfo(string uri, string siteId )
        {
            //var customerInfoJsonData = CreateJson(customerId);
            Console.WriteLine(string.Format("{0} ", uri + "sites/" + siteId ));
            return GetMethod.GetRequest(uri + "sites/" + siteId);
        }
    }
}
