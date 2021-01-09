using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwseTradingExchangeForms.WebApi
{
    class WebApiCore
    {
        public string GetResponse(string url, Dictionary<string, string> keyValues)
        {
            string requestUrl = url + "?";
            foreach (var item in keyValues)
                requestUrl += item.Key + "=" + item.Value + "&";
            requestUrl.TrimEnd('&');
            var client = new RestClient(requestUrl);
            var request = new RestRequest(Method.GET);
            request.AddHeader("user-agent", "vscode-restclient");
            IRestResponse response = client.Execute(request);
            return response.Content;
        }
    }
}
