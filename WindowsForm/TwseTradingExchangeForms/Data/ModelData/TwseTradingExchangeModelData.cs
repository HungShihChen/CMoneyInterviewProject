using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwseTradingExchangeForms.Data.ModelData
{
    public class TwseTradingExchangeModelData
    {
        /// <summary>
        /// 證券代號
        /// </summary>
        public string SecuritiesID { get; set; }
        /// <summary>
        /// 資料的時間(紀錄至天)
        /// </summary>
        public DateTime Time
        {
            get { return _Time; }
            set { _Time = new DateTime(value.Year, value.Month, value.Day); }
        }
        private DateTime _Time;

        

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
        public int? YieldYear { get; set; }
        /// <summary>
        /// 本益比
        /// </summary>
        public double? PeRatio { get; set; }
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
