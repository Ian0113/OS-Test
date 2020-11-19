namespace 綜合演算法
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
            this.lb_flag0 = new System.Windows.Forms.Label();
            this.lb_flag1 = new System.Windows.Forms.Label();
            this.btn_flag0 = new System.Windows.Forms.Button();
            this.btn_flag1 = new System.Windows.Forms.Button();
            this.lb_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_flag2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_flag2 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lb_turn = new System.Windows.Forms.Label();
            this.btn_turn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.p0_count = new System.Windows.Forms.Label();
            this.p1_count = new System.Windows.Forms.Label();
            this.p2_count = new System.Windows.Forms.Label();
            this.btn_autot = new System.Windows.Forms.Button();
            this.auto_flag = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flag0 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Flag1 :";
            // 
            // lb_flag0
            // 
            this.lb_flag0.AutoSize = true;
            this.lb_flag0.Location = new System.Drawing.Point(161, 267);
            this.lb_flag0.Name = "lb_flag0";
            this.lb_flag0.Size = new System.Drawing.Size(58, 24);
            this.lb_flag0.TabIndex = 1;
            this.lb_flag0.Text = "flag";
            // 
            // lb_flag1
            // 
            this.lb_flag1.AutoSize = true;
            this.lb_flag1.Location = new System.Drawing.Point(161, 306);
            this.lb_flag1.Name = "lb_flag1";
            this.lb_flag1.Size = new System.Drawing.Size(58, 24);
            this.lb_flag1.TabIndex = 1;
            this.lb_flag1.Text = "flag";
            // 
            // btn_flag0
            // 
            this.btn_flag0.Location = new System.Drawing.Point(240, 263);
            this.btn_flag0.Name = "btn_flag0";
            this.btn_flag0.Size = new System.Drawing.Size(126, 33);
            this.btn_flag0.TabIndex = 2;
            this.btn_flag0.Text = "改變flag0";
            this.btn_flag0.UseVisualStyleBackColor = true;
            this.btn_flag0.Click += new System.EventHandler(this.btn_flag0_Click);
            // 
            // btn_flag1
            // 
            this.btn_flag1.Location = new System.Drawing.Point(240, 302);
            this.btn_flag1.Name = "btn_flag1";
            this.btn_flag1.Size = new System.Drawing.Size(126, 33);
            this.btn_flag1.TabIndex = 2;
            this.btn_flag1.Text = "改變flag1";
            this.btn_flag1.UseVisualStyleBackColor = true;
            this.btn_flag1.Click += new System.EventHandler(this.btn_flag1_Click);
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.ForeColor = System.Drawing.Color.Blue;
            this.lb_count.Location = new System.Drawing.Point(392, 545);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(70, 24);
            this.lb_count.TabIndex = 3;
            this.lb_count.Text = "count";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = ",";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(22, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = ",";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 345);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 24);
            this.label6.TabIndex = 0;
            this.label6.Text = "Flag2 :";
            // 
            // lb_flag2
            // 
            this.lb_flag2.AutoSize = true;
            this.lb_flag2.Location = new System.Drawing.Point(161, 345);
            this.lb_flag2.Name = "lb_flag2";
            this.lb_flag2.Size = new System.Drawing.Size(58, 24);
            this.lb_flag2.TabIndex = 1;
            this.lb_flag2.Text = "flag";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(22, 24);
            this.label8.TabIndex = 1;
            this.label8.Text = "2";
            // 
            // btn_flag2
            // 
            this.btn_flag2.Location = new System.Drawing.Point(240, 341);
            this.btn_flag2.Name = "btn_flag2";
            this.btn_flag2.Size = new System.Drawing.Size(126, 33);
            this.btn_flag2.TabIndex = 2;
            this.btn_flag2.Text = "改變flag2";
            this.btn_flag2.UseVisualStyleBackColor = true;
            this.btn_flag2.Click += new System.EventHandler(this.btn_flag2_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 345);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(22, 24);
            this.label9.TabIndex = 4;
            this.label9.Text = ",";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 24);
            this.label7.TabIndex = 1;
            this.label7.Text = "1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(22, 24);
            this.label10.TabIndex = 1;
            this.label10.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(82, 24);
            this.label11.TabIndex = 5;
            this.label11.Text = "turn :";
            // 
            // lb_turn
            // 
            this.lb_turn.AutoSize = true;
            this.lb_turn.Location = new System.Drawing.Point(123, 438);
            this.lb_turn.Name = "lb_turn";
            this.lb_turn.Size = new System.Drawing.Size(58, 24);
            this.lb_turn.TabIndex = 5;
            this.lb_turn.Text = "turn";
            // 
            // btn_turn
            // 
            this.btn_turn.Location = new System.Drawing.Point(240, 434);
            this.btn_turn.Name = "btn_turn";
            this.btn_turn.Size = new System.Drawing.Size(126, 33);
            this.btn_turn.TabIndex = 2;
            this.btn_turn.Text = "改變turn";
            this.btn_turn.UseVisualStyleBackColor = true;
            this.btn_turn.Click += new System.EventHandler(this.btn_turn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(164, 485);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 32);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "500";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(20, 488);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(130, 24);
            this.label12.TabIndex = 5;
            this.label12.Text = "延遲(ms) :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "次數 :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 306);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 24);
            this.label13.TabIndex = 0;
            this.label13.Text = "次數 :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(372, 345);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 24);
            this.label14.TabIndex = 0;
            this.label14.Text = "次數 :";
            // 
            // p0_count
            // 
            this.p0_count.AutoSize = true;
            this.p0_count.Location = new System.Drawing.Point(457, 267);
            this.p0_count.Name = "p0_count";
            this.p0_count.Size = new System.Drawing.Size(94, 24);
            this.p0_count.TabIndex = 0;
            this.p0_count.Text = "p_count";
            // 
            // p1_count
            // 
            this.p1_count.AutoSize = true;
            this.p1_count.Location = new System.Drawing.Point(457, 306);
            this.p1_count.Name = "p1_count";
            this.p1_count.Size = new System.Drawing.Size(94, 24);
            this.p1_count.TabIndex = 0;
            this.p1_count.Text = "p_count";
            // 
            // p2_count
            // 
            this.p2_count.AutoSize = true;
            this.p2_count.Location = new System.Drawing.Point(457, 345);
            this.p2_count.Name = "p2_count";
            this.p2_count.Size = new System.Drawing.Size(94, 24);
            this.p2_count.TabIndex = 0;
            this.p2_count.Text = "p_count";
            // 
            // btn_autot
            // 
            this.btn_autot.Location = new System.Drawing.Point(372, 434);
            this.btn_autot.Name = "btn_autot";
            this.btn_autot.Size = new System.Drawing.Size(126, 33);
            this.btn_autot.TabIndex = 2;
            this.btn_autot.Text = "自動turn";
            this.btn_autot.UseVisualStyleBackColor = true;
            this.btn_autot.Click += new System.EventHandler(this.btn_autot_Click);
            // 
            // auto_flag
            // 
            this.auto_flag.Location = new System.Drawing.Point(240, 380);
            this.auto_flag.Name = "auto_flag";
            this.auto_flag.Size = new System.Drawing.Size(126, 33);
            this.auto_flag.TabIndex = 2;
            this.auto_flag.Text = "自動flag";
            this.auto_flag.UseVisualStyleBackColor = true;
            this.auto_flag.Click += new System.EventHandler(this.auto_flag_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.Blue;
            this.label15.Location = new System.Drawing.Point(64, 545);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(250, 24);
            this.label15.TabIndex = 3;
            this.label15.Text = "三隻執行緒共用變數 :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Black;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.White;
            this.richTextBox1.Location = new System.Drawing.Point(12, 10);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(539, 247);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "說明 : \n\nFlag0=true =>count+=1+(0~500)-(0~500)\n\nFlag1=true =>count+=10+(0~500)-(0~5" +
    "00)\n\nFlag2=true =>count+=100+(0~500)-(0~500)\n\np.s.可更改延遲";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 592);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lb_turn);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.lb_count);
            this.Controls.Add(this.auto_flag);
            this.Controls.Add(this.btn_autot);
            this.Controls.Add(this.btn_turn);
            this.Controls.Add(this.btn_flag2);
            this.Controls.Add(this.btn_flag1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_flag0);
            this.Controls.Add(this.lb_flag2);
            this.Controls.Add(this.lb_flag1);
            this.Controls.Add(this.p2_count);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lb_flag0);
            this.Controls.Add(this.p1_count);
            this.Controls.Add(this.p0_count);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "綜合演算法(9A417018)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_flag0;
        private System.Windows.Forms.Label lb_flag1;
        private System.Windows.Forms.Button btn_flag0;
        private System.Windows.Forms.Button btn_flag1;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_flag2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_flag2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lb_turn;
        private System.Windows.Forms.Button btn_turn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label p0_count;
        private System.Windows.Forms.Label p1_count;
        private System.Windows.Forms.Label p2_count;
        private System.Windows.Forms.Button btn_autot;
        private System.Windows.Forms.Button auto_flag;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

