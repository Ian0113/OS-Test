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

namespace Ta學生
{
    public partial class Form1 : Form
    {
        #region 全域

        //自製類別
        Th th = new Th();

        //互斥鎖(只有一個lab)
        private Mutex lab_mutex;

        //號誌(三張椅子)
        private Semaphore chair_semap;

        //椅子上有多少人
        private int chair_count=0;

        //學生人數(預設20)
        private int student_count = 20;

        //亂數範圍 1~v1(預設1000)
        private int v1 = 1000;

        #endregion

        #region Form 設定
        //建構子
        public Form1 ( )
        {
            InitializeComponent ( );
            //忽略跨執行緒存取物件錯誤
            CheckForIllegalCrossThreadCalls = false;
        }

        //當text1上的字串改變時
        private void textBox1_TextChanged ( object sender , EventArgs e )
        {
            //若字數小於等於零  跳過
            if ( textBox1.Text.Length <= 0 )
            {
                return;
            }

            //若不是數字  將字串清空  為零跳過
            if ( int.TryParse ( textBox1.Text , out int k ) )
            {
                if ( k == 0 )
                {
                    return;
                }
                v1 = k;
            }
            else
            {
                textBox1.Text = "";
            }
        }

        //當text3上的字串改變時
        private void textBox3_TextChanged ( object sender , EventArgs e )
        {
            //若字數小於等於零  跳過
            if ( textBox3.Text.Length <= 0 )
            {
                return;
            }

            //若不是數字  將字串清空  為零跳過
            if ( int.TryParse ( textBox3.Text , out int k ) )
            {
                if ( k == 0 )
                {
                    return;
                }
                student_count = k;
            }
            else
            {
                textBox3.Text = "";
            }
        }

        //當button1按下時
        private void button1_Click ( object sender , EventArgs e )
        {
            //將button1和text3鎖住
            textBox3.Enabled = button1.Enabled = false;
            //創建互斥鎖
            lab_mutex = new Mutex ( );
            //創建號誌  總共三個  初始三個
            chair_semap = new Semaphore ( 3 , 3 );

            //創造五隻學生執行緒
            for ( int i = 1 ; i <= student_count ; i++ )
            {
                th.start ( i.ToString ( ) , student_ask );
            }

            //創造TA執行緒
            th.start ( "TA" , ta_slp );
        }

        //當Form1關閉時
        private void Form1_FormClosed ( object sender , FormClosedEventArgs e )
        {
            //關閉所有執行緒
            string s = th.exit;
        }

        #endregion


        #region 私用方法

        //TA執行
        private void ta_slp ( )
        {
            while ( true )
            {
                //若椅子上沒人就睡覺否則醒著
                lb_ta_sta.Text = ( chair_count == 0 ) ? "小睡" : "醒著";
                Thread.Sleep ( 5 );
            }
        }

        //學生問問題
        private void student_ask ( )
        {
            while ( true )
            {
                try
                {
                    //當亂數符合條件式  則發問
                    int slp = int.Parse ( Thread.CurrentThread.Name );
                    while ( !( new Random ( ).Next ( 1 , v1 ) == slp ) )
                    {
                        Thread.Sleep ( slp * 2 + 5 );
                    }

                    //學生想問問題
                    string s = string.Format ( "student{0}" , slp );
                    wait_chair ( s );

                    //更新椅子目前有幾張
                    chair_count = lsb_wait_chair.Items.Count;

                    //等待椅子號誌
                    chair_semap.WaitOne ( );

                    //有椅子坐
                    lsb_wait_chair.Items.Remove ( s );
                    sit_chair ( s );

                    //等待進入實驗室
                    lab ( s , slp );
                }
                catch ( Exception ) { }
            }
        }

        //進入實驗室
        private void lab ( string s , int slp )
        {
            //當沒人在實驗室內
            lab_mutex.WaitOne ( );
            /*-----------臨界區間(實驗室)------------*/
            try
            {
                //進入實驗室  將椅子號誌歸還
                chair_semap.Release ( );
                lsb_chair.Items.Remove ( s );
                //更新GUI上進入實驗室的學生及延遲時間倒數
                lb_ask.Text = s;
                for ( int i = ( 500 + slp * 100 ) ; i >= 0 ; i -= 20 )
                {
                    lb_l.Text = i.ToString ( );
                    Thread.Sleep ( 20 );
                    if ( i == 0 )
                    {
                        Thread.Sleep ( 500 );
                    }
                }
                //倒數完
                lb_l.Text = "?";
                lb_ask.Text = "";
                //更新椅子目前有幾張
                chair_count = lsb_chair.Items.Count;
            }
            catch ( Exception )
            {
                //若有錯誤則直接執行這邊
                lsb_chair.Items.Remove ( s );
                chair_count = lsb_chair.Items.Count;
            }
            /*-----------臨界區間(實驗室)------------*/
            lab_mutex.ReleaseMutex ( );
        }

        //做在椅子上
        private void sit_chair ( string s )
        {
            lsb_chair.Items.Add ( s );
        }

        //沒椅子坐  稍後
        private void wait_chair ( string s )
        {
            lsb_wait_chair.Items.Add ( s );
        }

        #endregion
    }
}
