using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Utilidades.RequestUtility
{
    public class Request : IRequest
    {
        public string Get(Uri url, string parametros, string token)
        {
            return null;
        }

        public string Post(Uri url, object json, string token)
        {
            var cli = new WebClient();
            cli.Headers[HttpRequestHeader.ContentType] = "application/json";
            cli.Headers[HttpRequestHeader.Authorization] = string.Format("Bearer {0}", token);
            string response = cli.UploadString(url, Newtonsoft.Json.JsonConvert.SerializeObject(json));
            return response;
        }

        public string Post(Uri url, string parametros, string token)
        {
            return null;
        }
    }
}
