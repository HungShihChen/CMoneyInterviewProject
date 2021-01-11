using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwseTradingExchangeForms.Functions;

namespace UnitTestProject
{
    [TestClass]
    public class TwseTradingExchangeFuncTest
    {
        private static TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
        [TestMethod]
        public void TestGetRecentDayHasData()
        {
            var data = func.GetData("1102", new DateTime(2021, 1, 6), new DateTime(2021, 1, 8));
            Assert.AreEqual(3, data.Count);
            Assert.AreEqual(10.18, data[0].PeRatio);
        }

        [TestMethod]
        public void TestGetRecentDayNoData()
        {
            var data = func.GetData("1102", new DateTime(2021, 1, 2), new DateTime(2021, 1, 3));
            Assert.AreEqual(0, data.Count);
        }

        [TestMethod]
        public void TestGetPeRatioTopN()
        {
            var data = func.GetPeRatioTopN(new DateTime(2021, 1, 8), 3);
            Assert.AreEqual(3, data.Count);
            Assert.AreEqual(5100, data[0].PeRatio);
            Assert.AreEqual(1970, data[1].PeRatio);
            Assert.AreEqual(1230.00, data[2].PeRatio);
        }

        [TestMethod]
        public void TestGetYieldRateMaxIncreasingTimeRange()
        {
            var data = func.GetYieldRateMaxIncreasingTimeRange("1102", new DateTime(2021, 1, 1), new DateTime(2021, 1, 10));
            Assert.AreEqual(2, data.Count);
            Assert.AreEqual(6, data[0].Time.Day);
        }
    }
}
