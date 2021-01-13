namespace TwseTradingExchangeForms.Views
{
    partial class UcRecentDay
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.TbSID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NudDay = new System.Windows.Forms.NumericUpDown();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.DgvRecentDay = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecentDay)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DgvRecentDay, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(958, 483);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.TbSID);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.NudDay);
            this.flowLayoutPanel1.Controls.Add(this.BtnSearch);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(952, 29);
            this.flowLayoutPanel1.TabIndex = 0;
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
            // TbSID
            // 
            this.TbSID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TbSID.Location = new System.Drawing.Point(65, 3);
            this.TbSID.Name = "TbSID";
            this.TbSID.Size = new System.Drawing.Size(100, 23);
            this.TbSID.TabIndex = 0;
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
            // NudDay
            // 
            this.NudDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NudDay.Location = new System.Drawing.Point(209, 3);
            this.NudDay.Name = "NudDay";
            this.NudDay.Size = new System.Drawing.Size(120, 23);
            this.NudDay.TabIndex = 3;
            this.NudDay.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(335, 3);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(75, 23);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "搜尋";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
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
            this.DgvRecentDay.Size = new System.Drawing.Size(952, 442);
            this.DgvRecentDay.TabIndex = 1;
            // 
            // UcRecentDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UcRecentDay";
            this.Size = new System.Drawing.Size(958, 483);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NudDay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvRecentDay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbSID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NudDay;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.DataGridView DgvRecentDay;
    }
}
