namespace FIFO演算法
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose ( );
            }
            base.Dispose ( disposing );
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent ( )
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_rtxb_clean = new System.Windows.Forms.Button();
            this.rbtn_lru = new System.Windows.Forms.RadioButton();
            this.rbtn_best = new System.Windows.Forms.RadioButton();
            this.rbtn_fifo = new System.Windows.Forms.RadioButton();
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_inp = new System.Windows.Forms.Button();
            this.rtxb_msg = new System.Windows.Forms.RichTextBox();
            this.dt = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_talfail = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_talhit = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lb_thisfail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_thishit = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.page0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.page2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rtxb_clean);
            this.groupBox1.Controls.Add(this.rbtn_lru);
            this.groupBox1.Controls.Add(this.rbtn_best);
            this.groupBox1.Controls.Add(this.rbtn_fifo);
            this.groupBox1.Controls.Add(this.btn_clean);
            this.groupBox1.Controls.Add(this.btn_inp);
            this.groupBox1.Controls.Add(this.rtxb_msg);
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 316);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "替換分頁";
            // 
            // btn_rtxb_clean
            // 
            this.btn_rtxb_clean.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rtxb_clean.Location = new System.Drawing.Point(255, 212);
            this.btn_rtxb_clean.Name = "btn_rtxb_clean";
            this.btn_rtxb_clean.Size = new System.Drawing.Size(57, 27);
            this.btn_rtxb_clean.TabIndex = 3;
            this.btn_rtxb_clean.Text = "清除";
            this.btn_rtxb_clean.UseVisualStyleBackColor = true;
            this.btn_rtxb_clean.Click += new System.EventHandler(this.btn_rtxb_clean_Click);
            // 
            // rbtn_lru
            // 
            this.rbtn_lru.AutoSize = true;
            this.rbtn_lru.ForeColor = System.Drawing.Color.Blue;
            this.rbtn_lru.Location = new System.Drawing.Point(26, 98);
            this.rbtn_lru.Name = "rbtn_lru";
            this.rbtn_lru.Size = new System.Drawing.Size(251, 28);
            this.rbtn_lru.TabIndex = 2;
            this.rbtn_lru.TabStop = true;
            this.rbtn_lru.Text = "LRU 分頁替換演算法";
            this.rbtn_lru.UseVisualStyleBackColor = true;
            this.rbtn_lru.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtn_best
            // 
            this.rbtn_best.AutoSize = true;
            this.rbtn_best.ForeColor = System.Drawing.Color.Blue;
            this.rbtn_best.Location = new System.Drawing.Point(26, 64);
            this.rbtn_best.Name = "rbtn_best";
            this.rbtn_best.Size = new System.Drawing.Size(253, 28);
            this.rbtn_best.TabIndex = 2;
            this.rbtn_best.TabStop = true;
            this.rbtn_best.Text = "最佳分頁替換演算法";
            this.rbtn_best.UseVisualStyleBackColor = true;
            this.rbtn_best.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // rbtn_fifo
            // 
            this.rbtn_fifo.AutoSize = true;
            this.rbtn_fifo.ForeColor = System.Drawing.Color.Blue;
            this.rbtn_fifo.Location = new System.Drawing.Point(26, 31);
            this.rbtn_fifo.Name = "rbtn_fifo";
            this.rbtn_fifo.Size = new System.Drawing.Size(251, 28);
            this.rbtn_fifo.TabIndex = 2;
            this.rbtn_fifo.TabStop = true;
            this.rbtn_fifo.Text = "FIFO分頁替換演算法";
            this.rbtn_fifo.UseVisualStyleBackColor = true;
            this.rbtn_fifo.CheckedChanged += new System.EventHandler(this.rbtn_CheckedChanged);
            // 
            // btn_clean
            // 
            this.btn_clean.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clean.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_clean.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btn_clean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_clean.Location = new System.Drawing.Point(158, 242);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(155, 70);
            this.btn_clean.TabIndex = 0;
            this.btn_clean.Text = "清除";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_inp
            // 
            this.btn_inp.Enabled = false;
            this.btn_inp.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.btn_inp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_inp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_inp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_inp.ForeColor = System.Drawing.Color.Lime;
            this.btn_inp.Location = new System.Drawing.Point(3, 242);
            this.btn_inp.Name = "btn_inp";
            this.btn_inp.Size = new System.Drawing.Size(155, 70);
            this.btn_inp.TabIndex = 0;
            this.btn_inp.Text = "替換";
            this.btn_inp.UseVisualStyleBackColor = true;
            this.btn_inp.Click += new System.EventHandler(this.btn_inp_Click);
            // 
            // rtxb_msg
            // 
            this.rtxb_msg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxb_msg.BackColor = System.Drawing.Color.Black;
            this.rtxb_msg.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxb_msg.ForeColor = System.Drawing.Color.Silver;
            this.rtxb_msg.Location = new System.Drawing.Point(3, 147);
            this.rtxb_msg.MaxLength = 50;
            this.rtxb_msg.Name = "rtxb_msg";
            this.rtxb_msg.Size = new System.Drawing.Size(310, 93);
            this.rtxb_msg.TabIndex = 1;
            this.rtxb_msg.Text = "";
            this.rtxb_msg.TextChanged += new System.EventHandler(this.rtxb_msg_TextChanged);
            // 
            // dt
            // 
            this.dt.AllowUserToAddRows = false;
            this.dt.AllowUserToDeleteRows = false;
            this.dt.AllowUserToResizeColumns = false;
            this.dt.AllowUserToResizeRows = false;
            this.dt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dt.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dt.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.page0,
            this.page1,
            this.page2,
            this.hit,
            this.inp});
            this.dt.Cursor = System.Windows.Forms.Cursors.Cross;
            this.dt.EnableHeadersVisualStyles = false;
            this.dt.Location = new System.Drawing.Point(338, 11);
            this.dt.Name = "dt";
            this.dt.ReadOnly = true;
            this.dt.RowTemplate.Height = 24;
            this.dt.Size = new System.Drawing.Size(484, 569);
            this.dt.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(12, 339);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(315, 241);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hit / Fail";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lb_talfail);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.lb_talhit);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(17, 137);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 98);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "總共";
            // 
            // lb_talfail
            // 
            this.lb_talfail.AutoSize = true;
            this.lb_talfail.ForeColor = System.Drawing.Color.Red;
            this.lb_talfail.Location = new System.Drawing.Point(159, 58);
            this.lb_talfail.Name = "lb_talfail";
            this.lb_talfail.Size = new System.Drawing.Size(22, 24);
            this.lb_talfail.TabIndex = 0;
            this.lb_talfail.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(71, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Fail :";
            // 
            // lb_talhit
            // 
            this.lb_talhit.AutoSize = true;
            this.lb_talhit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_talhit.Location = new System.Drawing.Point(159, 34);
            this.lb_talhit.Name = "lb_talhit";
            this.lb_talhit.Size = new System.Drawing.Size(22, 24);
            this.lb_talhit.TabIndex = 0;
            this.lb_talhit.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label6.Location = new System.Drawing.Point(71, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Hit  :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lb_thisfail);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.lb_thishit);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(17, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 98);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "這次執行";
            // 
            // lb_thisfail
            // 
            this.lb_thisfail.AutoSize = true;
            this.lb_thisfail.ForeColor = System.Drawing.Color.Red;
            this.lb_thisfail.Location = new System.Drawing.Point(159, 59);
            this.lb_thisfail.Name = "lb_thisfail";
            this.lb_thisfail.Size = new System.Drawing.Size(22, 24);
            this.lb_thisfail.TabIndex = 0;
            this.lb_thisfail.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(71, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Fail :";
            // 
            // lb_thishit
            // 
            this.lb_thishit.AutoSize = true;
            this.lb_thishit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_thishit.Location = new System.Drawing.Point(159, 35);
            this.lb_thishit.Name = "lb_thishit";
            this.lb_thishit.Size = new System.Drawing.Size(22, 24);
            this.lb_thishit.TabIndex = 0;
            this.lb_thishit.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(71, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hit  :";
            // 
            // page0
            // 
            this.page0.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.page0.HeaderText = "page0";
            this.page0.Name = "page0";
            this.page0.ReadOnly = true;
            this.page0.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.page0.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.page0.ToolTipText = "1";
            this.page0.Width = 80;
            // 
            // page1
            // 
            this.page1.HeaderText = "page1";
            this.page1.Name = "page1";
            this.page1.ReadOnly = true;
            this.page1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.page1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.page1.Width = 80;
            // 
            // page2
            // 
            this.page2.HeaderText = "page2";
            this.page2.Name = "page2";
            this.page2.ReadOnly = true;
            this.page2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.page2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.page2.Width = 80;
            // 
            // hit
            // 
            this.hit.HeaderText = "Hit/Fail";
            this.hit.Name = "hit";
            this.hit.ReadOnly = true;
            this.hit.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.hit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.hit.Width = 120;
            // 
            // inp
            // 
            this.inp.HeaderText = "inp";
            this.inp.Name = "inp";
            this.inp.ReadOnly = true;
            this.inp.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.inp.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inp.Width = 80;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 596);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dt);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(850, 631);
            this.MinimumSize = new System.Drawing.Size(850, 631);
            this.Name = "Form1";
            this.Text = "三個分頁替換演算法(9A417018)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dt)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox rtxb_msg;
        private System.Windows.Forms.DataGridView dt;
        private System.Windows.Forms.Button btn_inp;
        private System.Windows.Forms.RadioButton rbtn_lru;
        private System.Windows.Forms.RadioButton rbtn_best;
        private System.Windows.Forms.RadioButton rbtn_fifo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_thisfail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_thishit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lb_talfail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_talhit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_rtxb_clean;
        private System.Windows.Forms.DataGridViewTextBoxColumn page0;
        private System.Windows.Forms.DataGridViewTextBoxColumn page1;
        private System.Windows.Forms.DataGridViewTextBoxColumn page2;
        private System.Windows.Forms.DataGridViewTextBoxColumn hit;
        private System.Windows.Forms.DataGridViewTextBoxColumn inp;
    }
}

