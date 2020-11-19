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

namespace 交替演算法
{
    public partial class Form1 : Form
    {
        #region 全域變數
        //顯示題是視窗
        Form2 f2 = new Form2 ( );
        //共用turn 來做交替
        bool turn = true;
        //b2 . b3 常態變數
        const bool b2 = false;
        const bool b3 = true;
        //th2 . th3 執行緒
        Thread th2 ;
        Thread th3;
        //累加數值
        uint count = 0;
        //暫停按鈕
        bool sw = false;
        //延遲
        int dly = 500;
        #endregion

        #region form基礎設定
        public Form1 ( )
        {
            InitializeComponent ( );
        }
        private void Form1_FormClosed ( object sender , FormClosedEventArgs e )
        {
            th2.Abort ( );
            th3.Abort ( );
            f2.Close ( );
        }
        #endregion

        private void Form1_Load ( object sender , EventArgs e )
        {
            //忽略跨執行緒處理的錯誤(允許跨執行緒存取變數)
            CheckForIllegalCrossThreadCalls = false;
            label2.Text = label3.Text = label4.Text = "";

            //建立及啟用執行緒
            th2 = new Thread ( box2 ) { IsBackground = true };
            th3 = new Thread ( box3 ) { IsBackground = true };
            th2.Start ( );
            th3.Start ( );
        }

        private void btn_sw_Click ( object sender , EventArgs e )
        {
            if ( !f2.Visible )
            {
                f2.Visible = true;
                f2.Update ( );
            }
            sw = !sw;
        }
        private void textBox1_TextChanged ( object sender , EventArgs e )
        {
            if ( textBox1.Text.Length > 0 )
            {
                dly = int.Parse ( textBox1.Text );
            }
        }

        private void box2 ( )
        {
            uint box_count = 0;
            while ( true )
            {
                if ( sw )
                {
                    try
                    {
                        while ( turn != b2 )
                        {
                            box_count += 1;
                            label7.Text = box_count.ToString ( );
                            //數值加10
                            count += 10;
                            //故意設計長運算時間
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
                            //限制範圍再0~59999(避免溢出)
                            count %= 60000;
                            //更新數值顯示再gui上
                            label2.Text = count.ToString ( );
                            //顯示目前進如更改數值的為b2
                            label3.Text = "b2 可更改數值";
                            turn = b2;
                            label4.Text = string.Format ( "turn:{0}" , turn );
                        }
                    }
                    catch ( Exception ) { }
                }
                Thread.Sleep ( dly );
            }
        }

        private void box3 ( )
        {
            uint box_count = 0;
            while ( true )
            {
                if ( sw )
                {
                    try
                    {
                        while ( turn != b3 )
                        {
                            box_count += 1;
                            label8.Text = box_count.ToString ( );
                            //數值加1
                            count += 1;
                            //故意設計長運算時間
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
                            //限制範圍再0~59999(避免溢出)
                            count %= 60000;
                            //更新數值顯示再gui上
                            label2.Text = count.ToString ( );
                            //顯示目前進如更改數值的為b3
                            label3.Text = "b3 可更改數值";
                            turn = b3;
                            label4.Text = string.Format ( "turn:{0}" , turn );
                        }
                    }
                    catch ( Exception ) { }
                }
                Thread.Sleep ( dly );
            }
        }

        
    }
}
