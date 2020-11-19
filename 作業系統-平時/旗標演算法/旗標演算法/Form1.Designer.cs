namespace 旗標演算法
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flag0 = new System.Windows.Forms.Label();
            this.flag1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_flag0 = new System.Windows.Forms.Button();
            this.btn_flag2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flag0 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flag1 :";
            // 
            // flag0
            // 
            this.flag0.AutoSize = true;
            this.flag0.Location = new System.Drawing.Point(142, 44);
            this.flag0.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.flag0.Name = "flag0";
            this.flag0.Size = new System.Drawing.Size(22, 24);
            this.flag0.TabIndex = 0;
            this.flag0.Text = " ";
            // 
            // flag1
            // 
            this.flag1.AutoSize = true;
            this.flag1.Location = new System.Drawing.Point(142, 68);
            this.flag1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.flag1.Name = "flag1";
            this.flag1.Size = new System.Drawing.Size(22, 24);
            this.flag1.TabIndex = 0;
            this.flag1.Text = " ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 214);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(219, 24);
            this.label7.TabIndex = 0;
            this.label7.Text = "Flag0執行中次數 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(264, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = " ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 238);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(219, 24);
            this.label9.TabIndex = 0;
            this.label9.Text = "Flag1執行中次數 :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 238);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = " ";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.Location = new System.Drawing.Point(142, 143);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(22, 24);
            this.lb_count.TabIndex = 3;
            this.lb_count.Text = " ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(78, 348);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(85, 32);
            this.textBox1.TabIndex = 4;
            this.textBox1.Text = "500";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "延遲";
            // 
            // btn_flag0
            // 
            this.btn_flag0.Location = new System.Drawing.Point(232, 34);
            this.btn_flag0.Name = "btn_flag0";
            this.btn_flag0.Size = new System.Drawing.Size(138, 34);
            this.btn_flag0.TabIndex = 6;
            this.btn_flag0.Text = "更變flag0";
            this.btn_flag0.UseVisualStyleBackColor = true;
            this.btn_flag0.Click += new System.EventHandler(this.btn_flag0_Click);
            // 
            // btn_flag2
            // 
            this.btn_flag2.Location = new System.Drawing.Point(232, 68);
            this.btn_flag2.Name = "btn_flag2";
            this.btn_flag2.Size = new System.Drawing.Size(138, 34);
            this.btn_flag2.TabIndex = 6;
            this.btn_flag2.Text = "更變flag1";
            this.btn_flag2.UseVisualStyleBackColor = true;
            this.btn_flag2.Click += new System.EventHandler(this.btn_flag2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 380);
            this.Controls.Add(this.btn_flag2);
            this.Controls.Add(this.btn_flag0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.flag1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.flag0);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "旗標演算法(9A417018)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label flag0;
        private System.Windows.Forms.Label flag1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_flag0;
        private System.Windows.Forms.Button btn_flag2;
    }
}

