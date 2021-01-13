using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwseTradingExchangeForms.Functions;
using TwseTradingExchangeForms.Ext;

namespace TwseTradingExchangeForms.Views
{
    public partial class UcYieldRateInc : UserControl
    {
        public UcYieldRateInc()
        {
            InitializeComponent();
            DtpEndTime.Value = DateTime.Now;
            DtpStartTime.Value = DateTime.Now.AddDays(-7);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            string id = TbSID.Text;
            DateTime st = DtpStartTime.Value.ConvertToYmd();
            DateTime et = DtpEndTime.Value.ConvertToYmd();
            if (st > et)
            {
                MessageBox.Show("開始時間不可大於結束時間");
                return;
            }
            var data = func.GetYieldRateMaxIncreasingTimeRange(id, st, et);
            LblYieldRateInc.Text = "最長天數: " + data.Count;
            DgvYieldRateInc.DataSource = data;
        }
    }
}
