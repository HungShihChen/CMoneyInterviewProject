using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwseTradingExchangeForms.Data.ModelData;

namespace TwseTradingExchangeForms.WebApi.DAO
{    
    public class TwseTradingExchangeApiDAO
    {
        private WebApiCore _ApiCore = new WebApiCore();

        private class TwseApiResponseModelData
        {
            public string stat { get; set; }
            public List<string> fields { get; set; }
            public List<List<string>> data { get; set; }
        }

        //public IEnumerable<TwseTradingExchangeModelData> GetTwseTradingExchange(DateTime st, DateTime et)
        //{
        //    List<DateTime> dts = new List<DateTime>();
        //    for (DateTime t = st; t <= et; t = t.AddDays(1))
        //    {
        //        dts.Add(t);
        //    }
        //    return GetTwseTradingExchange(dts);
        //}

        //public IEnumerable<TwseTradingExchangeModelData> GetTwseTradingExchange(List<DateTime> datetimes)
        //{
        //    List<TwseTradingExchangeModelData> data = new List<TwseTradingExchangeModelData>();
        //    foreach (var dt in datetimes)
        //    {
        //        data.AddRange(GetTwseTradingExchange(dt));
        //    }
        //    return data;
        //}

        public IEnumerable<TwseTradingExchangeModelData> GetTwseTradingExchange(DateTime datetime)
        {
            List<TwseTradingExchangeModelData> data = new List<TwseTradingExchangeModelData>();

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
                    TwseTradingExchangeModelData d = new TwseTradingExchangeModelData()
                    {
                        SecuritiesID = a[0].ToString(),
                        Time = datetime,
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

        

        
    }
}
