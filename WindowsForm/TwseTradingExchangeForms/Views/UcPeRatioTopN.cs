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
    public partial class UcPeRatioTopN : UserControl
    {
        public UcPeRatioTopN()
        {
            InitializeComponent();
            Dtp.Value = DateTime.Now;
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            DateTime dt = Dtp.Value.ConvertToYmd();
            int n = Convert.ToInt32(Nud.Value);
            Dgv.DataSource = func.GetPeRatioTopN(dt, n);
        }
    }
}
