using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwseTradingExchangeForms.Data.DAO;

namespace UnitTestProject
{
    [TestClass]
    public class TwseTradingExchangeDaoTest
    {
        private static TwseTradingExchangeDAO dao = new TwseTradingExchangeDAO();
        [TestMethod]
        public void TestGetData()
        {
            var data = dao.GetData(new DateTime(2021, 1, 8), new DateTime(2021, 1, 8));
            Assert.AreEqual(942, data.Count);
        }

        [TestMethod]
        public void TestGetDataWithID()
        {
            var data = dao.GetData("1102", new DateTime(2021, 1, 8), new DateTime(2021, 1, 10));
            Assert.AreEqual(1, data.Count);
        }
    }
}
