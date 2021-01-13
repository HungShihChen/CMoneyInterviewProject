using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwseTradingExchangeForms.Data.ModelData;
using TwseTradingExchangeForms.Ext;
using TwseTradingExchangeForms.Functions;

namespace TwseTradingExchangeForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        private void _ShowBWBusyMsg()
        {
            MessageBox.Show("資料更新中，請稍後");
        }

        private void TwseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            TwseTradingExchangeFunc func = new TwseTradingExchangeFunc();
            func.SaveData();
        }
    }
}
