﻿using System;
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
    public partial class TwseForm : Form
    {
        public static TwseTradingExchangeFunc func;
        public TwseForm()
        {
            InitializeComponent();
            func = new TwseTradingExchangeFunc();
            DtpPeRatioTopN.Value = DtpYieldRateIncEt.Value = DateTime.Now;
            DtpYieldRateIncSt.Value = DateTime.Now.AddDays(-7);
        }

        private void ButtonSearchRecentDay_Click(object sender, EventArgs e)
        {
            string id = TbRecentDaySID.Text;
            int day = Convert.ToInt32(NudRecentDay.Value);
            DateTime et = DateTime.Now.ConvertToYmd();
            DateTime st = et.AddDays(-Convert.ToInt32(NudRecentDay.Maximum) * 2);

            func.UpdateData(st, et);
            var data = func.GetData(id, st, et);
            DgvRecentDay.DataSource = data.Take(day).ToList();
        }

        private void BtnSearchPeRatioTopN_Click(object sender, EventArgs e)
        {
            DateTime dt = DtpPeRatioTopN.Value.ConvertToYmd();
            int n = Convert.ToInt32(NudPeRatioTopN.Value);
            func.UpdateData(dt, dt);
            DgvPeRatioTopN.DataSource = func.GetPeRatioTopN(dt, n);
        }

        private void BtnSearchYieldRateInc_Click(object sender, EventArgs e)
        {
            string id = TbYieldRateInc.Text;
            DateTime st = DtpYieldRateIncSt.Value.ConvertToYmd();
            DateTime et = DtpYieldRateIncEt.Value.ConvertToYmd();
            func.UpdateData(st, et);
            var data = func.GetYieldRateMaxIncreasingTimeRange(id, st, et);
            LblYieldRateInc.Text = "最長天數: " + data.Count;
            DgvYieldRateInc.DataSource = data;
        }

        private void _ShowBWBusyMsg()
        {
            MessageBox.Show("資料更新中，請稍後");
        }

        private void TwseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            func.SaveData();
        }
    }
}