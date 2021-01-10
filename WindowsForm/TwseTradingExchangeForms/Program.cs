using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwseTradingExchangeForms.Functions;

namespace TwseTradingExchangeForms
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            func.UpdateData(new DateTime(2020, 1, 1), new DateTime(2020, 1, 10));
            func.SaveData();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
