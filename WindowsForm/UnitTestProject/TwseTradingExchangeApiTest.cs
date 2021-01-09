using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwseTradingExchangeForms.WebApi.DAO;
namespace UnitTestProject
{
    [TestClass]
    public class TwseTradingExchangeApiTest
    {
        [TestMethod]
        public void TestShouldGetData()
        {
            TwseTradingExchangeApiDAO dao = new TwseTradingExchangeApiDAO();
            DateTime dt = new DateTime(2020, 1, 2);
            var data = dao.GetTwseTradingExchange(dt).ToList();
            Assert.AreEqual(941, data.Count());
        }

        [TestMethod]
        public void TestShouldNotGetData()
        {
            TwseTradingExchangeApiDAO dao = new TwseTradingExchangeApiDAO();
            DateTime dt = new DateTime(2020, 1, 1);
            var data = dao.GetTwseTradingExchange(dt).ToList();
            Assert.AreEqual(0, data.Count());
        }
    }
}
