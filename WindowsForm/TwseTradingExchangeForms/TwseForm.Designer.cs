namespace TwseTradingExchangeForms
{
    partial class TwseForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.TbRecentDaySID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NudRecentDay = new System.Windows.Forms.NumericUpDown();
            this.BtnSearchRecentDay = new System.Windows.Forms.Button();
            this.DgvRecentDay = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSearchPeRatioTopN = new System.Windows.Forms.Button();
            this.DgvPeRatioTopN = new System.Windows.Forms.DataGridView();
            this.DtpPeRatioTopN = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.NudPeRatioTopN = new System.Windows.Forms.NumericUpDown();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.DgvYieldRateInc = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.TbYieldRateInc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpYieldRateIncSt = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpYieldRateIncEt = new System.Windows.Forms.DateTimePicker();
            this.BtnSearchYieldRateInc = new System.Windows.Forms.Button();
            this.LblYieldRateInc = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRecentDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecentDay)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeRatioTopN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeRatioTopN)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYieldRateInc)).BeginInit();
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
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
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
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
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
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(827, 560);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "殖利率 為嚴格遞增的最長天數";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvRecentDay, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(821, 552);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TbRecentDaySID);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.NudRecentDay);
            this.flowLayoutPanel1.Controls.Add(this.BtnSearchRecentDay);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(815, 29);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // TbRecentDaySID
            // 
            this.TbRecentDaySID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbRecentDaySID.Location = new System.Drawing.Point(65, 3);
            this.TbRecentDaySID.Name = "TbRecentDaySID";
            this.TbRecentDaySID.Size = new System.Drawing.Size(100, 23);
            this.TbRecentDaySID.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "證券代號";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(171, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "天數";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NudRecentDay
            // 
            this.NudRecentDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NudRecentDay.Location = new System.Drawing.Point(209, 3);
            this.NudRecentDay.Name = "NudRecentDay";
            this.NudRecentDay.Size = new System.Drawing.Size(120, 23);
            this.NudRecentDay.TabIndex = 3;
            this.NudRecentDay.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // BtnSearchRecentDay
            // 
            this.BtnSearchRecentDay.Location = new System.Drawing.Point(335, 3);
            this.BtnSearchRecentDay.Name = "BtnSearchRecentDay";
            this.BtnSearchRecentDay.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchRecentDay.TabIndex = 4;
            this.BtnSearchRecentDay.Text = "搜尋";
            this.BtnSearchRecentDay.UseVisualStyleBackColor = true;
            this.BtnSearchRecentDay.Click += new System.EventHandler(this.ButtonSearchRecentDay_Click);
            // 
            // DgvRecentDay
            // 
            this.DgvRecentDay.AllowUserToAddRows = false;
            this.DgvRecentDay.AllowUserToDeleteRows = false;
            this.DgvRecentDay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvRecentDay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvRecentDay.Location = new System.Drawing.Point(3, 38);
            this.DgvRecentDay.Name = "DgvRecentDay";
            this.DgvRecentDay.ReadOnly = true;
            this.DgvRecentDay.RowTemplate.Height = 24;
            this.DgvRecentDay.Size = new System.Drawing.Size(815, 511);
            this.DgvRecentDay.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.DgvPeRatioTopN, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(821, 552);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.DtpPeRatioTopN);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.NudPeRatioTopN);
            this.flowLayoutPanel2.Controls.Add(this.BtnSearchPeRatioTopN);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(815, 29);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 29);
            this.label3.TabIndex = 1;
            this.label3.Text = "日期";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnSearchPeRatioTopN
            // 
            this.BtnSearchPeRatioTopN.Location = new System.Drawing.Point(345, 3);
            this.BtnSearchPeRatioTopN.Name = "BtnSearchPeRatioTopN";
            this.BtnSearchPeRatioTopN.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchPeRatioTopN.TabIndex = 4;
            this.BtnSearchPeRatioTopN.Text = "搜尋";
            this.BtnSearchPeRatioTopN.UseVisualStyleBackColor = true;
            this.BtnSearchPeRatioTopN.Click += new System.EventHandler(this.BtnSearchPeRatioTopN_Click);
            // 
            // DgvPeRatioTopN
            // 
            this.DgvPeRatioTopN.AllowUserToAddRows = false;
            this.DgvPeRatioTopN.AllowUserToDeleteRows = false;
            this.DgvPeRatioTopN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPeRatioTopN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvPeRatioTopN.Location = new System.Drawing.Point(3, 38);
            this.DgvPeRatioTopN.Name = "DgvPeRatioTopN";
            this.DgvPeRatioTopN.ReadOnly = true;
            this.DgvPeRatioTopN.RowTemplate.Height = 24;
            this.DgvPeRatioTopN.Size = new System.Drawing.Size(815, 511);
            this.DgvPeRatioTopN.TabIndex = 1;
            // 
            // DtpPeRatioTopN
            // 
            this.DtpPeRatioTopN.Location = new System.Drawing.Point(41, 3);
            this.DtpPeRatioTopN.Name = "DtpPeRatioTopN";
            this.DtpPeRatioTopN.Size = new System.Drawing.Size(135, 23);
            this.DtpPeRatioTopN.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(182, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Top";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NudPeRatioTopN
            // 
            this.NudPeRatioTopN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NudPeRatioTopN.Location = new System.Drawing.Point(219, 3);
            this.NudPeRatioTopN.Name = "NudPeRatioTopN";
            this.NudPeRatioTopN.Size = new System.Drawing.Size(120, 23);
            this.NudPeRatioTopN.TabIndex = 7;
            this.NudPeRatioTopN.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DgvYieldRateInc, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(821, 552);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.TbYieldRateInc);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.DtpYieldRateIncSt);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.DtpYieldRateIncEt);
            this.flowLayoutPanel3.Controls.Add(this.BtnSearchYieldRateInc);
            this.flowLayoutPanel3.Controls.Add(this.LblYieldRateInc);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(815, 29);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // DgvYieldRateInc
            // 
            this.DgvYieldRateInc.AllowUserToAddRows = false;
            this.DgvYieldRateInc.AllowUserToDeleteRows = false;
            this.DgvYieldRateInc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvYieldRateInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvYieldRateInc.Location = new System.Drawing.Point(3, 38);
            this.DgvYieldRateInc.Name = "DgvYieldRateInc";
            this.DgvYieldRateInc.ReadOnly = true;
            this.DgvYieldRateInc.RowTemplate.Height = 24;
            this.DgvYieldRateInc.Size = new System.Drawing.Size(815, 511);
            this.DgvYieldRateInc.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "證券代號";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TbYieldRateInc
            // 
            this.TbYieldRateInc.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbYieldRateInc.Location = new System.Drawing.Point(65, 3);
            this.TbYieldRateInc.Name = "TbYieldRateInc";
            this.TbYieldRateInc.Size = new System.Drawing.Size(100, 23);
            this.TbYieldRateInc.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(171, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 29);
            this.label5.TabIndex = 10;
            this.label5.Text = "開始日期";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpYieldRateIncSt
            // 
            this.DtpYieldRateIncSt.Location = new System.Drawing.Point(233, 3);
            this.DtpYieldRateIncSt.Name = "DtpYieldRateIncSt";
            this.DtpYieldRateIncSt.Size = new System.Drawing.Size(135, 23);
            this.DtpYieldRateIncSt.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(374, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "結束日期";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // DtpYieldRateIncEt
            // 
            this.DtpYieldRateIncEt.Location = new System.Drawing.Point(436, 3);
            this.DtpYieldRateIncEt.Name = "DtpYieldRateIncEt";
            this.DtpYieldRateIncEt.Size = new System.Drawing.Size(135, 23);
            this.DtpYieldRateIncEt.TabIndex = 14;
            // 
            // BtnSearchYieldRateInc
            // 
            this.BtnSearchYieldRateInc.Location = new System.Drawing.Point(577, 3);
            this.BtnSearchYieldRateInc.Name = "BtnSearchYieldRateInc";
            this.BtnSearchYieldRateInc.Size = new System.Drawing.Size(75, 23);
            this.BtnSearchYieldRateInc.TabIndex = 15;
            this.BtnSearchYieldRateInc.Text = "搜尋";
            this.BtnSearchYieldRateInc.UseVisualStyleBackColor = true;
            this.BtnSearchYieldRateInc.Click += new System.EventHandler(this.BtnSearchYieldRateInc_Click);
            // 
            // LblYieldRateInc
            // 
            this.LblYieldRateInc.AutoSize = true;
            this.LblYieldRateInc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblYieldRateInc.Location = new System.Drawing.Point(658, 0);
            this.LblYieldRateInc.Name = "LblYieldRateInc";
            this.LblYieldRateInc.Size = new System.Drawing.Size(0, 29);
            this.LblYieldRateInc.TabIndex = 16;
            this.LblYieldRateInc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TwseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 589);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TwseForm";
            this.Text = "TwseForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TwseForm_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudRecentDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecentDay)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPeRatioTopN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NudPeRatioTopN)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYieldRateInc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbRecentDaySID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudRecentDay;
        private System.Windows.Forms.Button BtnSearchRecentDay;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DgvRecentDay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DtpPeRatioTopN;
        private System.Windows.Forms.Button BtnSearchPeRatioTopN;
        private System.Windows.Forms.DataGridView DgvPeRatioTopN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NudPeRatioTopN;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbYieldRateInc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpYieldRateIncSt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpYieldRateIncEt;
        private System.Windows.Forms.Button BtnSearchYieldRateInc;
        private System.Windows.Forms.DataGridView DgvYieldRateInc;
        private System.Windows.Forms.Label LblYieldRateInc;
    }
}

