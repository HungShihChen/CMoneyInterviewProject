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
                    string sID;
                    string sName;
                    double yRate;
                    int? yYear;
                    string peRStr;
                    double ptnRatio;
                    string frySeason;
                    if (a.Count == 7)
                    {
                        sID = a[0].ToString();
                        sName = a[1].ToString();
                        yRate = double.Parse(a[2].ToString());
                        yYear = int.Parse(a[3].ToString());
                        peRStr = a[4].ToString();
                        ptnRatio = double.Parse(a[5].ToString());
                        frySeason = a[6].ToString();
                    }
                    else
                    {
                        sID = a[0].ToString();
                        sName = a[1].ToString();
                        peRStr = a[2].ToString();
                        yRate = double.Parse(a[3].ToString());
                        yYear = null;
                        ptnRatio = double.Parse(a[4].ToString());
                        frySeason = "";
                    }
                    double? peRatio = peRStr == "-" ? new double?() : double.Parse(peRStr);
                    TwseTradingExchangeModelData d = new TwseTradingExchangeModelData()
                    {
                        SecuritiesID = sID,
                        Time = datetime,
                        SecuritiesName = sName,
                        YieldRate = yRate,
                        YieldYear = yYear,
                        PeRatio = peRatio,
                        PriceToNetRatio = ptnRatio,
                        FinantialReportYearSeason = frySeason
                    };
                    data.Add(d);
                }
            }
            return data;
        }

        

        
    }
}
