using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 旗標演算法
{
    public partial class Form1 : Form
    {
        #region 全域變數

        //旗標陣列
        bool[] flag = new bool [ 2 ] { false , false };

        //設定P0 P1在陣列位置
        const byte P0 = 0;
        const byte P1 = 1;

        //儲存P0 P1所做次數
        uint p0_count = 0;
        uint p1_count = 0;

        //建立執行緒 模擬行程
        Thread th0 ,th1;

        P0 p0box = new P0 ( );

        //累家數值
        uint count=0;

        //延遲時間
        int dly = 500;
        #endregion

        #region Form初始設定
        public Form1 ( )
        {
            InitializeComponent ( );
        }
        private void Form1_FormClosed ( object sender , FormClosedEventArgs e )
        {
            th0.Abort ( );
            th1.Abort ( );
        }
        #endregion

        private void Form1_Load ( object sender , EventArgs e )
        {
            //忽略跨執行緒錯誤
            CheckForIllegalCrossThreadCalls = false;
            th0 = new Thread ( P0_box ) { IsBackground = true };
            th1 = new Thread ( P1_box ) { IsBackground = true };
            th0.Start ( );
            th1.Start ( );
            p0box.Show ( );
            p0box.Update ( );
        }
        private void textBox1_TextChanged ( object sender , EventArgs e )
        {
            if ( textBox1.Text.Length > 0 )
            {
                dly = int.Parse ( textBox1.Text );
            }
        }

        private void btn_flag0_Click ( object sender , EventArgs e )
        {
            //更變P0的旗標
            flag [ P0 ] = !flag [ P0 ];
            flag0.Text = flag [ P0 ].ToString ( );
        }

        private void btn_flag2_Click ( object sender , EventArgs e )
        {
            //更變P1的旗標
            flag [ P1 ] = !flag [ P1 ];
            flag1.Text = flag [ P1 ].ToString ( );
        }

        private void P0_box ( )
        {
            while ( true )
            {
                try
                {
                    while ( flag [ P1 ] )
                    {
                        //數值每次+10
                        count += 10;
                        //故意設計運算長時間
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count += i;
                            //if ( i % 10 == 0 )
                            //    Thread.Sleep ( 1 );
                        }
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count -= i;
                            //if ( i % 10 == 0 )
                            //    Thread.Sleep ( 1 );
                        }
                        lb_count.Text = count.ToString ( );
                        //計算次數
                        p1_count %= 65000;
                        p1_count += 1;
                        label10.Text = p1_count.ToString ( );
                        Thread.Sleep ( dly );
                    }

                }
                catch ( Exception ) { }
                //減輕系統負擔
                Thread.Sleep ( dly );
            }
        }

        private void P1_box ( )
        {
            while ( true )
            {
                try
                {
                    while ( flag [ P0 ] )
                    {
                        //數值每次+1
                        count += 1;
                        //故意設計運算長時間
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count += i;
                            //if ( i % 10 == 0 )
                            //    Thread.Sleep ( 1 );
                        }
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count -= i;
                            //if ( i % 10 == 0 )
                            //    Thread.Sleep ( 1 );
                        }
                        lb_count.Text = count.ToString ( );
                        //計算次數
                        p0_count %= 65000;
                        p0_count += 1;
                        label8.Text = p0_count.ToString ( );
                        Thread.Sleep ( dly );
                    }
                }
                catch ( Exception ) { }
                //減輕系統負擔
                Thread.Sleep ( dly );
            }
        }
    }
}
