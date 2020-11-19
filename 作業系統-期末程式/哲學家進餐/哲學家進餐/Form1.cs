using System;
using System.Threading;
using System.Windows.Forms;

namespace 哲學家進餐
{
    public partial class Form1 : Form
    {
        #region 全域變數
        //自製
        private Th th = new Th ( );

        //筷子物件共有5隻(2.5雙)
        private object chop0 = new object();
        private object chop1 = new object();
        private object chop2 = new object();
        private object chop3 = new object();
        private object chop4 = new object();

        //檢查筷子的人同時間只有一個(避免有人拿到一隻筷子)
        private object checkpair_LOCK = new object();

        //隨機亂數延遲
        private static int dly = 0;

        //由於同一時間取得隨機亂數會相同 因此限定同一時間只有一人
        private object dly_LOCK = dly;
        #endregion

        #region Form設定

        //建構子
        public Form1 ( )
        {
            InitializeComponent ( );
            CheckForIllegalCrossThreadCalls = false;
        }
        //當開始按鈕按下時
        private void button1_Click ( object sender , EventArgs e )
        {
            //鎖定開始按鈕
            button1.Enabled = false;
            //創造5隻哲學家執行緒
            for ( int i = 0 ; i < 5 ; i++ )
            {
                th.start ( i.ToString ( ) , Philosopher );
            }
        }
        //當Form1被關閉時
        private void Form1_FormClosed ( object sender , FormClosedEventArgs e )
        {
            //關閉所有執行緒
            button1.Text = th.exit;
        }

        #endregion

        #region 私用方法

        //哲學家執行
        private void Philosopher ( )
        {
            int Philosopher_Num = int.Parse ( Thread.CurrentThread.Name );
            while ( true )
            {
                WhoAreU ( Philosopher_Num );
            }
        }

        //利用執行緒編號來判斷左右邊的筷子
        private void WhoAreU ( int Philosopher_Num )
        {
            //利用執行緒編號來判斷左右邊的筷子
            switch ( Philosopher_Num )
            {
                case 0:
                {
                    DoSomething ( Philosopher_Num , chop0 , chop1 );
                }
                break;
                case 1:
                {
                    DoSomething ( Philosopher_Num , chop1 , chop2 );
                }
                break;
                case 2:
                {
                    DoSomething ( Philosopher_Num , chop2 , chop3 );
                }
                break;
                case 3:
                {
                    DoSomething ( Philosopher_Num , chop3 , chop4 );
                }
                break;
                case 4:
                {
                    DoSomething ( Philosopher_Num , chop4 , chop0 );
                }
                break;
            }
        }

        //利用執行緒號碼及左右邊的筷子 開始做事
        private void DoSomething ( int Philosopher_Num , object chop_right , object chop_left )
        {

            //思考
            StartThinking ( Philosopher_Num , GetDly ( 10000 ) );

            //等待有一雙筷子
            WaitPair ( Philosopher_Num , chop_right , chop_left );

            //吃飯中
            StartEatting ( Philosopher_Num , chop_right , chop_left , GetDly ( 10000 ) );

        }

        //等待筷子為一雙
        private void WaitPair ( int Philosopher_Num , object chop_right , object chop_left )
        {
            bool pair = true;

            //計算等待多少毫秒
            int count = 0;

            //當筷子符合一雙時停止
            while ( pair )
            {
                //同時只允許一人   確認筷子是否有一雙
                //進入臨界區
                Monitor.Enter ( checkpair_LOCK );

                //--------------------臨界區-------------------//
                if ( Monitor.TryEnter ( chop_right ) )
                {
                    if ( Monitor.TryEnter ( chop_left ) )
                    {
                        ( ( Panel ) P_table.Controls [ Philosopher_Num ] ).Visible = false;
                        ( ( Panel ) P_table.Controls [ ( Philosopher_Num + 1 ) % 5 ] ).Visible = false;
                        Update ( );
                        pair = false;
                    }
                    else
                    {
                        Monitor.Exit ( chop_right );
                        try
                        {
                            ( ( Label ) P_action.Controls [ Philosopher_Num ] ).Text = string.Format ( "想吃飯-------->{0}ms" , count += 10 );
                        }
                        catch ( Exception ) { }
                        pair = true;
                    }
                }
                else
                {
                    try
                    {
                        ( ( Label ) P_action.Controls [ Philosopher_Num ] ).Text = string.Format ( "想吃飯-------->{0}ms" , count += 10 );
                    }
                    catch ( Exception ) { }
                    pair = true;
                }
                //--------------------臨界區-------------------//

                //離開臨界區
                Monitor.Exit ( checkpair_LOCK );
                Thread.Sleep ( 10 );
            }
        }

        //開始吃飯
        private void StartEatting ( int Philosopher_Num , object chop_right , object chop_left , int dly )
        {
            //--------------------臨界區-------------------//
            //吃飯中...為了顯示用迴圈跑delay
            while ( dly > 10 )
            {
                try
                {
                    ( ( Label ) P_action.Controls [ Philosopher_Num ] ).Text = string.Format ( "吃飯中----------------->{0}ms" , dly -= 10 );
                }
                catch ( Exception ) { }
                Thread.Sleep ( 10 );
            }
            ( ( Panel ) P_table.Controls [ Philosopher_Num ] ).Visible = true;
            ( ( Panel ) P_table.Controls [ ( Philosopher_Num + 1 ) % 5 ] ).Visible = true;
            Update ( );
            //--------------------臨界區-------------------//
            Monitor.Exit ( chop_right );
            Monitor.Exit ( chop_left );
        }

        //開始思考
        private void StartThinking ( int Philosopher_Num , int dly )
        {
            //思考中...為了顯示用迴圈跑delay
            while ( dly > 10 )
            {
                try
                {
                    ( ( Label ) P_action.Controls [ Philosopher_Num ] ).Text = string.Format ( "思考中-->{0}ms" , dly -= 10 );
                }
                catch ( Exception ) { }
                Thread.Sleep ( 10 );
            }
        }

        //亂數延遲
        private int GetDly ( int range )
        {
            //限制同時只有一隻執行緒取得亂數(延遲時間ms)
            Monitor.Enter ( dly_LOCK );
            dly = new Random ( dly ).Next ( 1 , range );
            Monitor.Exit ( dly_LOCK );
            return dly;
        }

        #endregion

    }
}
