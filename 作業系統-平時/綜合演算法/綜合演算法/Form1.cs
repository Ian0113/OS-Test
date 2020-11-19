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

namespace 綜合演算法
{
    public partial class Form1 : Form
    {

        #region 全域變數

        //turn共用變數
        int turn = 0;

        //p0,1,2常數
        const int P0 = 0;
        const int P1 = 1;
        const int P2 = 2;

        //flag共用陣列
        bool[] flag = new bool[3]{ false,false,false };

        //計算p0,1,2執行次數
        uint p0_cnt = 0;
        uint p1_cnt = 0;
        uint p2_cnt = 0;

        //共用計數值
        uint count = 0;

        //延遲
        int dly = 500;

        //執行緒th0,1,2
        Thread th0,th1,th2,auto_turn;

        //是否自動切換flag
        bool auto_flag_sw = false;

        //是否自動切換turn
        bool auto_turn_sw = false;
        #endregion


        public Form1 ( )
        {
            InitializeComponent ( );
        }

        private void Form1_Load ( object sender , EventArgs e )
        {
            //允許跨執行緒存取變數
            CheckForIllegalCrossThreadCalls = false;
            //GUI初始化
            lb_flag0.Text = flag [ P0 ].ToString ( );
            lb_flag1.Text = flag [ P1 ].ToString ( );
            lb_flag2.Text = flag [ P2 ].ToString ( );
            lb_count.Text = count.ToString ( );
            lb_turn.Text = turn.ToString ( );
            p0_count.Text = p0_cnt.ToString ( );
            p1_count.Text = p1_cnt.ToString ( );
            p2_count.Text = p2_cnt.ToString ( );
            //執行緒建立及執行
            th0 = new Thread ( p0 );
            th1 = new Thread ( p1 );
            th2 = new Thread ( p2 );
            auto_turn = new Thread ( at );
            th0.Start ( );
            th1.Start ( );
            th2.Start ( );
            auto_turn.Start ( );
        }

        private void Form1_FormClosed ( object sender , FormClosedEventArgs e )
        {
            th0.Abort ( );
            th1.Abort ( );
            th2.Abort ( );
            auto_turn.Abort ( );
        }

        private void btn_flag0_Click ( object sender , EventArgs e )
        {
            flag [ P0 ] = !flag [ P0 ];
            lb_flag0.Text = flag [ P0 ].ToString ( );
        }

        private void btn_flag1_Click ( object sender , EventArgs e )
        {
            flag [ P1 ] = !flag [ P1 ];
            lb_flag1.Text = flag [ P1 ].ToString ( );
        }

        private void btn_flag2_Click ( object sender , EventArgs e )
        {
            flag [ P2 ] = !flag [ P2 ];
            lb_flag2.Text = flag [ P2 ].ToString ( );
        }

        private void btn_turn_Click ( object sender , EventArgs e )
        {
            turn += 1;
            turn %= 3;
            lb_turn.Text = turn.ToString ( );
        }

        private void btn_autot_Click ( object sender , EventArgs e )
        {
            btn_turn.Enabled = auto_turn_sw;
            auto_turn_sw = !auto_turn_sw;
            turn = -1;
            lb_turn.Text = turn.ToString ( );
        }

        private void auto_flag_Click ( object sender , EventArgs e )
        {
            btn_flag0.Enabled = btn_flag1.Enabled = btn_flag2.Enabled = auto_flag_sw;
            auto_flag_sw = !auto_flag_sw;
        }

        private void textBox1_TextChanged ( object sender , EventArgs e )
        {
            
            if ( textBox1.Text.Length > 0 )
            {
                int.TryParse ( textBox1.Text , out dly );
            }
        }

        private void p0 ( )
        {
            while ( true )
            {
                try
                {
                    if ( auto_flag_sw )
                    {
                        flag [ P0 ] = true;
                        lb_flag0.Text = flag [ P0 ].ToString ( );
                    }
                    while ( flag [ P0 ] & turn == P0 )
                    {
                        Thread.Sleep ( dly );
                        p0_cnt += 1;
                        p0_count.Text = p0_cnt.ToString ( );
                        count += 1;
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count += i;
                        }
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count -= i;
                        }
                        lb_count.Text = count.ToString ( );
                        if ( auto_flag_sw )
                        {
                            flag [ P0 ] = false;
                            lb_flag0.Text = flag [ P0 ].ToString ( );
                            break;
                        }
                    }
                }
                catch ( Exception ) { }
                //減輕系統負擔
                Thread.Sleep ( 5 );
            }
        }

        private void p1 ( )
        {
            while ( true )
            {
                try
                {
                    if ( auto_flag_sw )
                    {
                        flag [ P1 ] = true;
                        lb_flag1.Text = flag [ P1 ].ToString ( );
                    }
                    while ( flag [ P1 ] & turn == P1 )
                    {
                        Thread.Sleep ( dly );
                        p1_cnt += 1;
                        p1_count.Text = p1_cnt.ToString ( );
                        count += 10;
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count += i;
                        }
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count -= i;
                        }
                        lb_count.Text = count.ToString ( );
                        if ( auto_flag_sw )
                        {
                            flag [ P1 ] = false;
                            lb_flag1.Text = flag [ P1 ].ToString ( );
                            break;
                        }
                    }
                }
                catch ( Exception ) { }
                //減輕系統負擔
                Thread.Sleep ( 5 );
            }
        }

        private void p2 ( )
        {
            while ( true )
            {
                try
                {
                    if ( auto_flag_sw )
                    {
                        flag [ P2 ] = true;
                        lb_flag2.Text = flag [ P2 ].ToString ( );
                    }
                    while ( flag [ P2 ] & turn == P2 )
                    {
                        Thread.Sleep ( dly );
                        p2_cnt += 1;
                        p2_count.Text = p2_cnt.ToString ( );
                        count += 100;
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count += i;
                        }
                        for ( uint i = 0 ; i < 500 ; i++ )
                        {
                            count -= i;
                        }
                        lb_count.Text = count.ToString ( );
                        if ( auto_flag_sw )
                        {
                            flag [ P2 ] = false;
                            lb_flag2.Text = flag [ P2 ].ToString ( );
                            break;
                        }
                    }
                }
                catch ( Exception ) { }
                //減輕系統負擔
                Thread.Sleep ( 5 );
            }
        }

        private void at ( )
        {
            while ( true )
            {
                if ( auto_turn_sw )
                {
                    Thread.Sleep ( dly );
                    turn += 1;
                    turn %= 3;
                    lb_turn.Text = turn.ToString ( );
                }
                //減輕系統負擔
                Thread.Sleep ( 5 );
            }
        }

    }
}
