using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwseTradingExchangeForms.WebApi.ModelData;

namespace TwseTradingExchangeForms.WebApi.DAO
{    
    public class TwseTradingExchangeApiDAO
    {
        private WebApiCore _ApiCore = new WebApiCore();

        public IEnumerable<TwseTradingExchangeApiModelData> GetTwseTradingExchange(DateTime datetime)
        {
            List<TwseTradingExchangeApiModelData> data = new List<TwseTradingExchangeApiModelData>();

            Dictionary<string, string> args = new Dictionary<string, string>();
            args.Add("response", "json");
            args.Add("date", datetime.ToString("yyyyMMdd"));
            args.Add("selectType", "ALL");

            string response = "";
            foreach (var url in TwseApiConfig.GetUrls())
            {
                response = _ApiCore.GetResponse(url + "exchangeReport/BWIBBU_d", args);
                if (response != "")
                    break;
            }

            var responseJson = JsonConvert.DeserializeObject<TwseApiResponseModelData>(response);
            if(responseJson.stat == "OK")
            {
                foreach (var a in responseJson.data)
                {
                    string peRatioStr = a[4].ToString();
                    double peRatio = peRatioStr == "-" ? -99 : double.Parse(peRatioStr);
                    TwseTradingExchangeApiModelData d = new TwseTradingExchangeApiModelData()
                    {
                        SecuritiesID = a[0].ToString(),
                        SecuritiesName = a[1].ToString(),
                        YieldRate = double.Parse(a[2].ToString()),
                        YieldYear = int.Parse(a[3].ToString()),
                        PeRatio = peRatio,
                        PriceToNetRatio = double.Parse(a[5].ToString()),
                        FinantialReportYearSeason = a[6].ToString()
                    };
                    data.Add(d);
                }
            }
            return data;
        }

        public IEnumerable<TwseTradingExchangeApiModelData> GetTwseTradingExchange(List<DateTime> datetimes)
        {
            List<TwseTradingExchangeApiModelData> data = new List<TwseTradingExchangeApiModelData>();
            foreach (var dt in datetimes)
            {
                data.AddRange(GetTwseTradingExchange(dt));
            }
            return data;
        }

        private class TwseApiResponseModelData
        {
            public string stat { get; set; }
            public List<List<string>> data { get; set; }
        }

    }
}
