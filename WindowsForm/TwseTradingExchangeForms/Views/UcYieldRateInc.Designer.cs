namespace TwseTradingExchangeForms.Views
{
    partial class UcYieldRateInc
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.TbSID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DtpStartTime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.DtpEndTime = new System.Windows.Forms.DateTimePicker();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.LblYieldRateInc = new System.Windows.Forms.Label();
            this.DgvYieldRateInc = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYieldRateInc)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.DgvYieldRateInc, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(922, 585);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label7);
            this.flowLayoutPanel3.Controls.Add(this.TbSID);
            this.flowLayoutPanel3.Controls.Add(this.label5);
            this.flowLayoutPanel3.Controls.Add(this.DtpStartTime);
            this.flowLayoutPanel3.Controls.Add(this.label6);
            this.flowLayoutPanel3.Controls.Add(this.DtpEndTime);
            this.flowLayoutPanel3.Controls.Add(this.BtnSearch);
            this.flowLayoutPanel3.Controls.Add(this.LblYieldRateInc);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(916, 29);
            this.flowLayoutPanel3.TabIndex = 0;
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
            // TbSID
            // 
            this.TbSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbSID.Location = new System.Drawing.Point(65, 3);
            this.TbSID.Name = "TbSID";
            this.TbSID.Size = new System.Drawing.Size(100, 23);
            this.TbSID.TabIndex = 8;
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
            // DtpStartTime
            // 
            this.DtpStartTime.Location = new System.Drawing.Point(233, 3);
            this.DtpStartTime.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DtpStartTime.Name = "DtpStartTime";
            this.DtpStartTime.Size = new System.Drawing.Size(135, 23);
            this.DtpStartTime.TabIndex = 11;
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
            // DtpEndTime
            // 
            this.DtpEndTime.Location = new System.Drawing.Point(436, 3);
            this.DtpEndTime.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.DtpEndTime.Name = "DtpEndTime";
            this.DtpEndTime.Size = new System.Drawing.Size(135, 23);
            this.DtpEndTime.TabIndex = 14;
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(577, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 15;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.DgvYieldRateInc.Size = new System.Drawing.Size(916, 544);
            this.DgvYieldRateInc.TabIndex = 1;
            // 
            // UcYieldRateInc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcYieldRateInc";
            this.Size = new System.Drawing.Size(922, 585);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvYieldRateInc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TbSID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker DtpStartTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker DtpEndTime;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label LblYieldRateInc;
        private System.Windows.Forms.DataGridView DgvYieldRateInc;
    }
}
