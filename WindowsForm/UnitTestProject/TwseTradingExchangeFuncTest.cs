using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwseTradingExchangeForms.Functions;

namespace UnitTestProject
{
    [TestClass]
    public class TwseTradingExchangeFuncTest
    {
        [TestMethod]
        public void TestGetRecentDayHasData()
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            var data = func.GetRecentDayData("1102", new DateTime(2020, 1, 8), new DateTime(2020, 1, 10));
            Assert.AreEqual(3, data.Count);
            Assert.AreEqual(10.69, data[0].PeRatio);
            //func.DeleteData();
        }

        [TestMethod]
        public void TestGetRecentDayNoData()
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            var data = func.GetRecentDayData("1102", new DateTime(2020, 1, 4), new DateTime(2020, 1, 5));
            Assert.AreEqual(0, data.Count);
            //func.DeleteData();
        }

        [TestMethod]
        public void TestGetPeRatioTopN()
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            var data = func.GetPeRatioTopN(new DateTime(2020, 1, 8), 3);
            Assert.AreEqual(3, data.Count);
            Assert.AreEqual(2005.00, data[0].PeRatio);
            Assert.AreEqual(1013.33, data[1].PeRatio);
            Assert.AreEqual(865.00, data[2].PeRatio);
            //func.DeleteData();
        }

        [TestMethod]
        public void TestGetYieldRateMaxIncreasingTimeRange()
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            var data = func.GetYieldRateMaxIncreasingTimeRange("1102", new DateTime(2020, 1, 7), new DateTime(2020, 1, 10));
            Assert.AreEqual(2, data.Count);
            Assert.AreEqual(9, data[0].Time.Day);
        }
    }
}
