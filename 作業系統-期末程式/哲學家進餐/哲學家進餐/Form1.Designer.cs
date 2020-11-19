namespace 哲學家進餐
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.P_chop0 = new System.Windows.Forms.Panel();
            this.P_table = new System.Windows.Forms.Panel();
            this.P_chop4 = new System.Windows.Forms.Panel();
            this.P_chop3 = new System.Windows.Forms.Panel();
            this.P_chop2 = new System.Windows.Forms.Panel();
            this.P_chop1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.P_action = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.P_table.SuspendLayout();
            this.P_action.SuspendLayout();
            this.SuspendLayout();
            // 
            // P_chop0
            // 
            this.P_chop0.BackColor = System.Drawing.Color.Transparent;
            this.P_chop0.BackgroundImage = global::哲學家進餐.Properties.Resources.筷子1;
            this.P_chop0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_chop0.Location = new System.Drawing.Point(296, 221);
            this.P_chop0.Name = "P_chop0";
            this.P_chop0.Size = new System.Drawing.Size(151, 127);
            this.P_chop0.TabIndex = 0;
            // 
            // P_table
            // 
            this.P_table.BackColor = System.Drawing.Color.Transparent;
            this.P_table.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("P_table.BackgroundImage")));
            this.P_table.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_table.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.P_table.Controls.Add(this.P_chop4);
            this.P_table.Controls.Add(this.P_chop0);
            this.P_table.Controls.Add(this.P_chop3);
            this.P_table.Controls.Add(this.P_chop2);
            this.P_table.Controls.Add(this.P_chop1);
            this.P_table.Location = new System.Drawing.Point(21, 22);
            this.P_table.Name = "P_table";
            this.P_table.Size = new System.Drawing.Size(523, 494);
            this.P_table.TabIndex = 2;
            // 
            // P_chop4
            // 
            this.P_chop4.BackColor = System.Drawing.Color.Transparent;
            this.P_chop4.BackgroundImage = global::哲學家進餐.Properties.Resources.筷子0;
            this.P_chop4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_chop4.Location = new System.Drawing.Point(264, 76);
            this.P_chop4.Name = "P_chop4";
            this.P_chop4.Size = new System.Drawing.Size(151, 127);
            this.P_chop4.TabIndex = 4;
            // 
            // P_chop3
            // 
            this.P_chop3.BackColor = System.Drawing.Color.Transparent;
            this.P_chop3.BackgroundImage = global::哲學家進餐.Properties.Resources.筷子2;
            this.P_chop3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_chop3.Location = new System.Drawing.Point(185, 287);
            this.P_chop3.Name = "P_chop3";
            this.P_chop3.Size = new System.Drawing.Size(151, 127);
            this.P_chop3.TabIndex = 3;
            // 
            // P_chop2
            // 
            this.P_chop2.BackColor = System.Drawing.Color.Transparent;
            this.P_chop2.BackgroundImage = global::哲學家進餐.Properties.Resources.筷子3;
            this.P_chop2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_chop2.Location = new System.Drawing.Point(78, 227);
            this.P_chop2.Name = "P_chop2";
            this.P_chop2.Size = new System.Drawing.Size(151, 127);
            this.P_chop2.TabIndex = 2;
            // 
            // P_chop1
            // 
            this.P_chop1.BackColor = System.Drawing.Color.Transparent;
            this.P_chop1.BackgroundImage = global::哲學家進餐.Properties.Resources.筷子4;
            this.P_chop1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.P_chop1.Location = new System.Drawing.Point(107, 94);
            this.P_chop1.Name = "P_chop1";
            this.P_chop1.Size = new System.Drawing.Size(151, 127);
            this.P_chop1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 22);
            this.label1.TabIndex = 3;
            this.label1.Text = "哲學家 0 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "哲學家 1 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "哲學家 2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "哲學家 3 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(577, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 22);
            this.label5.TabIndex = 3;
            this.label5.Text = "哲學家 4 :";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(3, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(400, 31);
            this.label10.TabIndex = 0;
            this.label10.Text = "動作";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(400, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "動作";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(3, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(400, 31);
            this.label8.TabIndex = 0;
            this.label8.Text = "動作";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(400, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "動作";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(400, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "動作";
            // 
            // P_action
            // 
            this.P_action.Controls.Add(this.label6);
            this.P_action.Controls.Add(this.label7);
            this.P_action.Controls.Add(this.label8);
            this.P_action.Controls.Add(this.label9);
            this.P_action.Controls.Add(this.label10);
            this.P_action.ForeColor = System.Drawing.Color.Blue;
            this.P_action.Location = new System.Drawing.Point(696, 26);
            this.P_action.Name = "P_action";
            this.P_action.Size = new System.Drawing.Size(433, 160);
            this.P_action.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Consolas", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(581, 192);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(548, 324);
            this.button1.TabIndex = 5;
            this.button1.Text = "開始";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1169, 542);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.P_action);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.P_table);
            this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "哲學家進餐(9A417018)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.P_table.ResumeLayout(false);
            this.P_action.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel P_chop0;
        private System.Windows.Forms.Panel P_table;
        private System.Windows.Forms.Panel P_chop4;
        private System.Windows.Forms.Panel P_chop3;
        private System.Windows.Forms.Panel P_chop2;
        private System.Windows.Forms.Panel P_chop1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel P_action;
        private System.Windows.Forms.Button button1;
    }
}

