using System;
using System.Web.Script.Serialization;
using AlohaOrderOnLine.Infrastructure;
using AlohaOrderOnLine.Model;

namespace AlohaOrderOnLine.Service
{
    public class Authenticate
    {
        public string AuthenticateUser(string uri, string user, string pwd)
        {
            var authenticateJsonData = CreateJson(user, pwd);
            var json = new JavaScriptSerializer().Serialize(authenticateJsonData);
            Console.WriteLine(string.Format("{0},{1},{2}", uri , "Authenticate/", json ));
            return PostMethod.PostRequest(uri + "Authenticate/", json);
        }

        private object CreateJson(string user, string pwd)
        {
            var obj = new AuthenticateModel
            {
                Email = user, 
                Password = pwd 
            };
            return obj;
        }
    }
}
