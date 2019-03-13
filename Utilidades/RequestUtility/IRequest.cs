using System;
using System.Collections.Generic;
using System.Text;

namespace Utilidades.RequestUtility
{
    public interface IRequest
    {
        string Post(Uri url, object json,string token);
        string Post(Uri url, string parametros, string token);
        string Get(Uri url, string parametros, string token);


    }
}
