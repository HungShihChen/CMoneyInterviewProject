using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwseTradingExchangeForms.WebApi.ModelData
{
    public class TwseTradingExchangeApiModelData
    {
        /// <summary>
        /// 證券代號
        /// </summary>
        public string SecuritiesID { get; set; }
        /// <summary>
        /// 證券名稱
        /// </summary>
        public string SecuritiesName { get; set; }
        /// <summary>
        /// 殖利率(%)
        /// </summary>
        public double YieldRate { get; set; }
        /// <summary>
        /// 股利年度
        /// </summary>
        public int YieldYear { get; set; }
        /// <summary>
        /// 本益比
        /// </summary>
        public double PeRatio { get; set; }
        /// <summary>
        /// 股價淨值比
        /// </summary>
        public double PriceToNetRatio { get; set; }
        /// <summary>
        /// 財報年/季
        /// </summary>
        public string FinantialReportYearSeason { get; set; }
    }
}
