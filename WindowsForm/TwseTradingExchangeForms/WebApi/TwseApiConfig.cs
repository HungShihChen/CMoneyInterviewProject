using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwseTradingExchangeForms.WebApi
{
    public static class TwseApiConfig
    {
        public static List<string> GetUrls()
        {
            List<string> urls = new List<string>();
            urls.Add("https://www.twse.com.tw/");
            return urls;
        }
    }
}
