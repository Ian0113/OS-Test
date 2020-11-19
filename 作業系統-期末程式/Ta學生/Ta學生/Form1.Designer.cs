namespace Ta學生
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
            this.lsb_chair = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_l = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_ask = new System.Windows.Forms.Label();
            this.lb_ta_sta = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lsb_wait_chair = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsb_chair
            // 
            this.lsb_chair.ForeColor = System.Drawing.Color.Blue;
            this.lsb_chair.FormattingEnabled = true;
            this.lsb_chair.ItemHeight = 22;
            this.lsb_chair.Location = new System.Drawing.Point(17, 32);
            this.lsb_chair.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lsb_chair.Name = "lsb_chair";
            this.lsb_chair.Size = new System.Drawing.Size(147, 180);
            this.lsb_chair.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lsb_chair);
            this.groupBox1.Location = new System.Drawing.Point(286, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 220);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "椅子";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_l);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lb_ask);
            this.groupBox2.Controls.Add(this.lb_ta_sta);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(33, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(247, 220);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "研究室";
            // 
            // lb_l
            // 
            this.lb_l.AutoSize = true;
            this.lb_l.ForeColor = System.Drawing.Color.Blue;
            this.lb_l.Location = new System.Drawing.Point(113, 160);
            this.lb_l.Name = "lb_l";
            this.lb_l.Size = new System.Drawing.Size(20, 22);
            this.lb_l.TabIndex = 4;
            this.lb_l.Text = "?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 22);
            this.label8.TabIndex = 3;
            this.label8.Text = "倒數 :";
            // 
            // lb_ask
            // 
            this.lb_ask.AutoSize = true;
            this.lb_ask.ForeColor = System.Drawing.Color.Blue;
            this.lb_ask.Location = new System.Drawing.Point(113, 110);
            this.lb_ask.Name = "lb_ask";
            this.lb_ask.Size = new System.Drawing.Size(20, 22);
            this.lb_ask.TabIndex = 2;
            this.lb_ask.Text = " ";
            // 
            // lb_ta_sta
            // 
            this.lb_ta_sta.AutoSize = true;
            this.lb_ta_sta.ForeColor = System.Drawing.Color.Blue;
            this.lb_ta_sta.Location = new System.Drawing.Point(113, 55);
            this.lb_ta_sta.Name = "lb_ta_sta";
            this.lb_ta_sta.Size = new System.Drawing.Size(20, 22);
            this.lb_ta_sta.TabIndex = 2;
            this.lb_ta_sta.Text = " ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Student :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "TA :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lsb_wait_chair);
            this.groupBox3.Location = new System.Drawing.Point(473, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(181, 220);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "稍後";
            // 
            // lsb_wait_chair
            // 
            this.lsb_wait_chair.ForeColor = System.Drawing.Color.Blue;
            this.lsb_wait_chair.FormattingEnabled = true;
            this.lsb_wait_chair.ItemHeight = 22;
            this.lsb_wait_chair.Location = new System.Drawing.Point(17, 32);
            this.lsb_wait_chair.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.lsb_wait_chair.Name = "lsb_wait_chair";
            this.lsb_wait_chair.Size = new System.Drawing.Size(147, 180);
            this.lsb_wait_chair.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(374, 258);
            this.textBox1.MaxLength = 4;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(63, 30);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "1000";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 261);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "問問題的機率 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(443, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 22);
            this.label4.TabIndex = 6;
            this.label4.Text = ")";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 261);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = " == 學生編號";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(170, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Random.Next( 1 ,";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(82, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "學生人數 :";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(202, 313);
            this.textBox3.MaxLength = 2;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(63, 30);
            this.textBox3.TabIndex = 4;
            this.textBox3.Text = "20";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(277, 310);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 35);
            this.button1.TabIndex = 10;
            this.button1.Text = "開始執行";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "TA與學生(9A417018)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsb_chair;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_ask;
        private System.Windows.Forms.Label lb_ta_sta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lsb_wait_chair;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_l;
        private System.Windows.Forms.Label label8;
    }
}

