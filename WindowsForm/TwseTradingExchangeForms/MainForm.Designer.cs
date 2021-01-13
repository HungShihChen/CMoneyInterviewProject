namespace TwseTradingExchangeForms
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ucRecentDay1 = new TwseTradingExchangeForms.Views.UcRecentDay();
            this.ucPeRatioTopN1 = new TwseTradingExchangeForms.Views.UcPeRatioTopN();
            this.ucYieldRateInc1 = new TwseTradingExchangeForms.Views.UcYieldRateInc();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 589);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ucRecentDay1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(827, 560);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "最近n天的資料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ucPeRatioTopN1);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(827, 560);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "當天本益比前n名";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ucYieldRateInc1);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(827, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "殖利率 為嚴格遞增的最長天數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ucRecentDay1
            // 
            this.ucRecentDay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucRecentDay1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucRecentDay1.Location = new System.Drawing.Point(3, 4);
            this.ucRecentDay1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucRecentDay1.Name = "ucRecentDay1";
            this.ucRecentDay1.Size = new System.Drawing.Size(821, 552);
            this.ucRecentDay1.TabIndex = 0;
            // 
            // ucPeRatioTopN1
            // 
            this.ucPeRatioTopN1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPeRatioTopN1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucPeRatioTopN1.Location = new System.Drawing.Point(3, 4);
            this.ucPeRatioTopN1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucPeRatioTopN1.Name = "ucPeRatioTopN1";
            this.ucPeRatioTopN1.Size = new System.Drawing.Size(821, 552);
            this.ucPeRatioTopN1.TabIndex = 0;
            // 
            // ucYieldRateInc1
            // 
            this.ucYieldRateInc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucYieldRateInc1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ucYieldRateInc1.Location = new System.Drawing.Point(3, 4);
            this.ucYieldRateInc1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucYieldRateInc1.Name = "ucYieldRateInc1";
            this.ucYieldRateInc1.Size = new System.Drawing.Size(821, 552);
            this.ucYieldRateInc1.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 589);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "TwseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwseForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private Views.UcRecentDay ucRecentDay1;
        private Views.UcPeRatioTopN ucPeRatioTopN1;
        private Views.UcYieldRateInc ucYieldRateInc1;
    }
}

