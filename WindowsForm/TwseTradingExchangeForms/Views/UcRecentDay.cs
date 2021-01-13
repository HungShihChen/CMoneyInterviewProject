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
    public partial class UcRecentDay : UserControl
    {
        public UcRecentDay()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            string id = TbSID.Text;
            int day = Convert.ToInt32(NudDay.Value);
            DgvRecentDay.DataSource = func.GetRecentDay(id, DateTime.Now.ConvertToYmd(), day);
        }
    }
}
