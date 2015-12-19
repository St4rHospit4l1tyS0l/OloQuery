﻿using System;
using AlohaOrderOnLine.Infrastructure;
using AlohaOrderOnLine.Model;

namespace AlohaOrderOnLine.Service
{
    public class GetUserInfo
    {
        public string GetCustomerInfo(string uri, string customerId)
        {
            customerId = customerId.Replace("\"", "");
            //var customerInfoJsonData = CreateJson(customerId);
            Console.WriteLine(string.Format("{0} " ,uri + "v1/Customers/" + customerId + ""));
            return GetMethod.GetRequest(uri + "Customers/" + customerId + "");
        }

        private object CreateJson(string customerId)
        {
            var obj = new CustomerModel
            {
                CustomerId = customerId
            };
            return obj;
        }

    }
}
