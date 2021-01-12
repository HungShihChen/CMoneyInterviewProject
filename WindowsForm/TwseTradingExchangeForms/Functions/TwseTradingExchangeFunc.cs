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
        private static TwseTradingExchangeDAO dao = new TwseTradingExchangeDAO();

        public List<TwseTradingExchangeModelData> GetRecentDay(string securitisID, DateTime time, int day)
        {
            var data = new List<TwseTradingExchangeModelData>();
            for (int i = 0; data.Count < day; i++)
            {
                var dt = time.AddDays(-i);
                dao.UpdateData(dt, dt);
                var d = dao.GetData(securitisID, dt, dt);
                if (d.Count > 0)
                    data.AddRange(d);
            }
            return data.OrderByDescending(x => x.Time).ToList();
        }

        /// <summary>
        /// 指定特定日期 顯示當天本益比前n名
        /// </summary>
        /// <param name="time"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public List<TwseTradingExchangeModelData> GetPeRatioTopN(DateTime time, int n)
        {
            dao.UpdateData(time, time);
            var data = dao.GetData(time, time);
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
            dao.UpdateData(st, et);
            var data = dao.GetData(securitisID, st, et).OrderBy(x => x.Time).ToList();
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


        

        public void UpdateData(DateTime st, DateTime et)
        {
            dao.UpdateData(st, et);
        }

        public void SaveData()
        {
            dao.SaveData();
        }

        public void DeleteData()
        {
            dao.DeleteData();
        }
    }
}
