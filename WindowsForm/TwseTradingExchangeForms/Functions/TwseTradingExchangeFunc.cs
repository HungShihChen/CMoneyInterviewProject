using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwseTradingExchangeForms.Data.DAO;
using TwseTradingExchangeForms.Data.ModelData;

namespace TwseTradingExchangeForms.Functions
{
    public class TwseTradingExchangeFunc
    {
        private static TwseTradingExchangeDAO dao;
        private static Dictionary<int, List<TwseTradingExchangeModelData>> _YearDataDic;

        public TwseTradingExchangeFunc()
        {
            dao = new TwseTradingExchangeDAO();
            _YearDataDic = dao.InitData();
        }

        /// <summary>
        /// 依照證券代號 搜尋最近n天的資料
        /// </summary>
        /// <param name="securitisID"></param>
        /// <param name="day"></param>
        /// <returns></returns>
        public List<TwseTradingExchangeModelData> GetRecentDayData(string securitisID, DateTime st, DateTime et)
        {
            return GetData(st, et).Where(x => x.SecuritiesID == securitisID).ToList();
        }

        /// <summary>
        /// 指定特定日期 顯示當天本益比前n名
        /// </summary>
        /// <param name="time"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<TwseTradingExchangeModelData> GetPeRatioTopN(DateTime time, int n)
        {
            var data = GetData(time, time);
            return data.OrderByDescending(x => x.PeRatio).Take(n).ToList();
        }

        /// <summary>
        /// 指定日期範圍、證券代號 顯示這段時間內殖利率 為嚴格遞增的最長天數並顯示開始、結束日期
        /// </summary>
        /// <param name="securitisID"></param>
        /// <param name="st"></param>
        /// <param name="et"></param>
        /// <returns></returns>
        public List<TwseTradingExchangeModelData> GetYieldRateMaxIncreasingTimeRange(string securitisID, DateTime st, DateTime et)
        {
            var data = GetRecentDayData(securitisID, st, et).OrderBy(x => x.Time).ToList();
            int[] dp = new int[data.Count + 1];
            dp[0] = 1;
            for (int i = 1; i < data.Count(); i++)
            {
                if (data[i].YieldRate > data[i - 1].YieldRate)
                    dp[i] = dp[i - 1] + 1;
                else
                    dp[i] = 1;
            }
            int maxDay = dp.Max();
            int maxIndex = dp.ToList().IndexOf(maxDay);
            int minIndex = maxIndex - maxDay + 1;
            var retData = data.GetRange(minIndex, maxDay).ToList();
            return retData;
        }


        public List<TwseTradingExchangeModelData> GetData(DateTime st, DateTime et)
        {
            List<TwseTradingExchangeModelData> data = new List<TwseTradingExchangeModelData>();
            for (int y = st.Year; y <= et.Year; y++)
            {
                if(_YearDataDic.ContainsKey(y))
                    data.AddRange(_YearDataDic[y].Where(x => x.Time >= st && x.Time <= et));
            }
            return data;
        }

        public void UpdateData(DateTime st, DateTime et)
        {
            dao.UpdateData(_YearDataDic, st, et);
        }

        public void SaveData()
        {
            dao.SaveData(_YearDataDic);
        }

        public void DeleteData()
        {
            dao.DeleteData();
        }
    }
}
