using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace EagleEye
{
    class Spider
    {
        /* get HTTP response status code */
        public HttpStatusCode GetHttpStatusCode(string url)
        { 
            var request = HttpWebRequest.Create(url);
            request.Method = "HEAD";
            var response = (HttpWebResponse)request.GetResponse();
            return response.StatusCode;
        }
        public bool spiderUrl(string url)
        {
            try
            {
                using (System.IO.StringReader reader = new System.IO.StringReader(Properties.Resources.defaultWordlist))
                {
                    string subDomainString = reader.ReadLine();
                    string subDomain = subDomainString + "." + url.Split('/')[2];
                    var statusCode = GetHttpStatusCode(subDomain);

                    switch(statusCode)
                    {
                        case HttpStatusCode.BadRequest:
                            break;
                    }
                }
            }
            catch(InvalidOperationException)
            {
                return false;
            }
        }
    }
}
