using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 銀行家演算法
{
    public partial class Form1 : Form
    {
        #region 全域變數

        //需求量陣列
        private int [ ] Aneed_arr = new int [ 5 ];
        private int [ ] Bneed_arr = new int [ 5 ];
        private int [ ] Cneed_arr = new int [ 5 ];

        //A,B,C總量
        private int Atotal, Btotal, Ctotal;

        //初始安全性陣列
        private int [ ] initSafe_arr;

        #endregion

        #region Form設定
        //建構子
        public Form1 ( )
        {
            InitializeComponent ( );
        }
        //當開始按鈕按下時
        private void btn_start_Click ( object sender , EventArgs e )
        {
            int tatol_safe;
            int tatol_need = 0;
            //清除console
            rtxt_console.Text = "";

            //A , B , C need arr
            Aneed_arr = GetNeedArr ( P_Amax , P_Aallo , P_Aneed , txt_Aavainit , out Atotal );
            Bneed_arr = GetNeedArr ( P_Bmax , P_Ballo , P_Bneed , txt_Bavainit , out Btotal );
            Cneed_arr = GetNeedArr ( P_Cmax , P_Callo , P_Cneed , txt_Cavainit , out Ctotal );

            //A , B , C total
            Atotal += int.Parse ( txt_Aavainit.Text );
            Btotal += int.Parse ( txt_Bavainit.Text );
            Ctotal += int.Parse ( txt_Cavainit.Text );
            #region 檢查
            //是否有超出系統總量
            for ( int i = 0 ; i < 5 ; i++ )
            {
                tatol_need = Aneed_arr [ i ] + Bneed_arr [ i ] + Cneed_arr [ i ];
            }
            for ( int i = 0 ; i < 5 ; i++ )
            {
                TextBox Amax = ( TextBox ) P_Amax.Controls [ i ];
                TextBox Bmax = ( TextBox ) P_Bmax.Controls [ i ];
                TextBox Cmax = ( TextBox ) P_Cmax.Controls [ i ];
                if ( int.Parse ( Amax.Text ) > Atotal | int.Parse ( Bmax.Text ) > Btotal | int.Parse ( Cmax.Text ) > Ctotal )
                {
                    for ( int j = 0 ; j < 5 ; j++ )
                    {
                        initSafe_arr [ j ] = -9;
                    }
                    MsgWar ( string.Format ( "P{0}的Max超出系統所有量" , i ) );
                }
            }
            if ( tatol_need != 0 )
            {
                //取得初始安全陣列
                initSafe_arr = GetSafeArr ( int.Parse ( txt_Aavainit.Text ) , int.Parse ( txt_Bavainit.Text ) , int.Parse ( txt_Cavainit.Text ) , initSafe_arr );

                tatol_safe = chk ( initSafe_arr );
                if ( tatol_safe == 0 )
                {
                    MsgNone ( string.Format ( "不安全序列" ) );
                }
                else
                {
                    MsgNone ( string.Format ( "總共有{0}種安全序列" , tatol_safe ) );
                }
            }
            else
            {
                MsgNone ( string.Format ( "無需求" ) );
            }
            #endregion

            Size = new System.Drawing.Size ( 1733 , 552 );
            btn_lockvalue.Enabled = true;
        }
        //當鎖定按鈕按下時
        private void btn_lockvalue_Click ( object sender , EventArgs e )
        {
            //重置initsafe_arr
            initSafe_arr = new int [ 5 ] { 0 , 0 , 0 , 0 , 0 };
            btn_lockvalue.Enabled = false;
            Size = new System.Drawing.Size ( 882 , 552 );
        }
        //當鎖定按鈕的Enabled屬性變化時
        private void btn_lockvalue_EnabledChanged ( object sender , EventArgs e )
        {
            if ( btn_lockvalue.Enabled )
            {
                //解鎖數值
                G_Allocation.Enabled = G_Max.Enabled = G_Avaliable.Enabled = true;


                //關閉按鈕
                G_changeAllo.Enabled = btn_start.Enabled = btn_changeallo.Enabled = false;
            }
            else
            {
                //鎖定數值
                btn_lockvalue.Enabled = G_Allocation.Enabled = G_Max.Enabled = G_Avaliable.Enabled = false;

                //開啟按鈕
                G_changeAllo.Enabled = btn_start.Enabled = btn_changeallo.Enabled = true;
            }
        }
        //當更改Allocation按鈕按下時
        private void btn_changeallo_Click ( object sender , EventArgs e )
        {
            try
            {
                int chose = int.Parse ( txt_p.Text );
                int Adef_ava = int.Parse ( txt_Aavainit.Text );
                int Bdef_ava = int.Parse ( txt_Bavainit.Text );
                int Cdef_ava = int.Parse ( txt_Cavainit.Text );
                int Aned = int.Parse ( txt_changeAllo.Text ) - int.Parse ( ( ( TextBox ) P_Aallo.Controls [ chose ] ).Text );
                int Bned = int.Parse ( txt_changeBllo.Text ) - int.Parse ( ( ( TextBox ) P_Ballo.Controls [ chose ] ).Text );
                int Cned = int.Parse ( txt_changeCllo.Text ) - int.Parse ( ( ( TextBox ) P_Callo.Controls [ chose ] ).Text );
                if ( Aned <= Adef_ava & Bned <= Bdef_ava & Cned <= Cdef_ava )
                {
                    DialogResult myResult = MessageBox.Show ( "是否要更改內容?" , "更改現在持有量" , MessageBoxButtons.YesNo , MessageBoxIcon.Question );
                    if ( myResult == DialogResult.Yes )
                    {
                        int tatol_safe;
                        string Aallo = ( ( TextBox ) P_Aallo.Controls [ chose ] ).Text;
                        string Ballo = ( ( TextBox ) P_Ballo.Controls [ chose ] ).Text;
                        string Callo = ( ( TextBox ) P_Callo.Controls [ chose ] ).Text;
                        string Aava = txt_Aavainit.Text;
                        string Bava = txt_Bavainit.Text;
                        string Cava = txt_Cavainit.Text;
                        ( ( TextBox ) P_Aallo.Controls [ chose ] ).Text = txt_changeAllo.Text;
                        ( ( TextBox ) P_Ballo.Controls [ chose ] ).Text = txt_changeBllo.Text;
                        ( ( TextBox ) P_Callo.Controls [ chose ] ).Text = txt_changeCllo.Text;
                        txt_Aavainit.Text = ( int.Parse ( txt_Aavainit.Text ) - Aned ).ToString ( );
                        txt_Bavainit.Text = ( int.Parse ( txt_Bavainit.Text ) - Bned ).ToString ( );
                        txt_Cavainit.Text = ( int.Parse ( txt_Cavainit.Text ) - Cned ).ToString ( );
                        //A , B , C need arr
                        Aneed_arr = GetNeedArr ( P_Amax , P_Aallo , P_Aneed , txt_Aavainit , out Atotal );
                        Bneed_arr = GetNeedArr ( P_Bmax , P_Ballo , P_Bneed , txt_Bavainit , out Btotal );
                        Cneed_arr = GetNeedArr ( P_Cmax , P_Callo , P_Cneed , txt_Cavainit , out Ctotal );

                        //A , B , C total
                        Atotal += int.Parse ( txt_Aavainit.Text );
                        Btotal += int.Parse ( txt_Bavainit.Text );
                        Ctotal += int.Parse ( txt_Cavainit.Text );

                        //取得初始安全陣列
                        initSafe_arr = GetSafeArr ( int.Parse ( txt_Aavainit.Text ) , int.Parse ( txt_Bavainit.Text ) , int.Parse ( txt_Cavainit.Text ) , initSafe_arr );

                        tatol_safe = chk ( initSafe_arr );

                        if ( tatol_safe > 0 )
                        {
                            MessageBox.Show ( "更改成功!" , "更改現在持有量" );
                        }
                        else
                        {
                            myResult = MessageBox.Show ( "將產生死劫無法更改" , "更改現在持有量" );
                            ( ( TextBox ) P_Aallo.Controls [ chose ] ).Text = Aallo;
                            ( ( TextBox ) P_Ballo.Controls [ chose ] ).Text = Ballo;
                            ( ( TextBox ) P_Callo.Controls [ chose ] ).Text = Callo;
                            txt_Aavainit.Text = Aava;
                            txt_Bavainit.Text = Bava;
                            txt_Cavainit.Text = Cava;
                            //A , B , C need arr
                            Aneed_arr = GetNeedArr ( P_Amax , P_Aallo , P_Aneed , txt_Aavainit , out Atotal );
                            Bneed_arr = GetNeedArr ( P_Bmax , P_Ballo , P_Bneed , txt_Bavainit , out Btotal );
                            Cneed_arr = GetNeedArr ( P_Cmax , P_Callo , P_Cneed , txt_Cavainit , out Ctotal );

                            //A , B , C total
                            Atotal += int.Parse ( txt_Aavainit.Text );
                            Btotal += int.Parse ( txt_Bavainit.Text );
                            Ctotal += int.Parse ( txt_Cavainit.Text );

                            //取得初始安全陣列
                            initSafe_arr = GetSafeArr ( int.Parse ( txt_Aavainit.Text ) , int.Parse ( txt_Bavainit.Text ) , int.Parse ( txt_Cavainit.Text ) , initSafe_arr );
                        }
                    }
                    else if ( myResult == DialogResult.No )
                    {
                    }
                }
                else
                {
                    MessageBox.Show ( "無法修改" , "更改現在持有量" );
                }
            }
            catch ( Exception )
            {
                MessageBox.Show ( "輸入的數值有誤" , "錯誤" );
            }
        }
        //當textbox(任意一個)上面的數值改變時
        private void textBox_TextChanged ( object sender , EventArgs e )
        {
            TextBox t = sender as TextBox;
            try
            {
                int.Parse ( t.Text );
            }
            catch ( Exception )
            {
                t.Text = "";
            }
        }
        #endregion

        #region 私用方法
        //算出所有結果
        private int chk ( int [ ] initSafeArr )
        {
            //五個潮狀for 5-4-3-2-1
            //每次執行for 先複製上層的ava+safe陣列

            int count = 0;
            int [ ] SafeArr1 = ( int [ ] ) initSafeArr.Clone ( );
            int A_ava1 = int.Parse ( txt_Aavainit.Text );
            int B_ava1 = int.Parse ( txt_Bavainit.Text );
            int C_ava1 = int.Parse ( txt_Cavainit.Text );
            for ( int i = 0 ; i < 5 ; i++ )
            {
                if ( SafeArr1 [ i ] > 0 )
                {
                    int [ ] SafeArr2 = ( int [ ] ) SafeArr1.Clone ( );
                    SafeArr2 [ i ] = -1;
                    int A_ava2 = A_ava1 + int.Parse ( ( ( TextBox ) P_Aallo.Controls [ i ] ).Text );
                    int B_ava2 = B_ava1 + int.Parse ( ( ( TextBox ) P_Ballo.Controls [ i ] ).Text );
                    int C_ava2 = C_ava1 + int.Parse ( ( ( TextBox ) P_Callo.Controls [ i ] ).Text );
                    SafeArr2 = GetSafeArr ( A_ava2 , B_ava2 , C_ava2 , SafeArr2 );
                    for ( int j = 0 ; j < 5 ; j++ )
                    {
                        if ( SafeArr2 [ j ] > 0 )
                        {
                            int [ ] SafeArr3 = ( int [ ] ) SafeArr2.Clone ( );
                            SafeArr3 [ j ] = -1;
                            int A_ava3 = A_ava2 + int.Parse ( ( ( TextBox ) P_Aallo.Controls [ j ] ).Text );
                            int B_ava3 = B_ava2 + int.Parse ( ( ( TextBox ) P_Ballo.Controls [ j ] ).Text );
                            int C_ava3 = C_ava2 + int.Parse ( ( ( TextBox ) P_Callo.Controls [ j ] ).Text );
                            SafeArr3 = GetSafeArr ( A_ava3 , B_ava3 , C_ava3 , SafeArr3 );
                            for ( int k = 0 ; k < 5 ; k++ )
                            {
                                if ( SafeArr3 [ k ] > 0 )
                                {
                                    int [ ] SafeArr4 = ( int [ ] ) SafeArr3.Clone ( );
                                    SafeArr4 [ k ] = -1;
                                    int A_ava4 = A_ava3 + int.Parse ( ( ( TextBox ) P_Aallo.Controls [ k ] ).Text );
                                    int B_ava4 = B_ava3 + int.Parse ( ( ( TextBox ) P_Ballo.Controls [ k ] ).Text );
                                    int C_ava4 = C_ava3 + int.Parse ( ( ( TextBox ) P_Callo.Controls [ k ] ).Text );
                                    SafeArr4 = GetSafeArr ( A_ava4 , B_ava4 , C_ava4 , SafeArr4 );
                                    for ( int l = 0 ; l < 5 ; l++ )
                                    {
                                        if ( SafeArr4 [ l ] > 0 )
                                        {
                                            int [ ] SafeArr5 = ( int [ ] ) SafeArr4.Clone ( );
                                            SafeArr5 [ l ] = -1;
                                            int A_ava5 = A_ava4 + int.Parse ( ( ( TextBox ) P_Aallo.Controls [ l ] ).Text );
                                            int B_ava5 = B_ava4 + int.Parse ( ( ( TextBox ) P_Ballo.Controls [ l ] ).Text );
                                            int C_ava5 = C_ava4 + int.Parse ( ( ( TextBox ) P_Callo.Controls [ l ] ).Text );
                                            SafeArr5 = GetSafeArr ( A_ava5 , B_ava5 , C_ava5 , SafeArr5 );
                                            for ( int m = 0 ; m < 5 ; m++ )
                                            {
                                                if ( SafeArr5 [ m ] > 0 )
                                                {
                                                    int A_ava6 = A_ava5 + int.Parse ( ( ( TextBox ) P_Aallo.Controls [ m ] ).Text );
                                                    int B_ava6 = B_ava5 + int.Parse ( ( ( TextBox ) P_Ballo.Controls [ m ] ).Text );
                                                    int C_ava6 = C_ava5 + int.Parse ( ( ( TextBox ) P_Callo.Controls [ m ] ).Text );
                                                    string s1, s2, s3, s4, s5;
                                                    count += 1;
                                                    s1 = string.Format ( "P{0}[{1,4},{2,4},{3,4}]" , i , A_ava2 , B_ava2 , C_ava2 );
                                                    s2 = string.Format ( "P{0}[{1,4},{2,4},{3,4}]" , j , A_ava3 , B_ava3 , C_ava3 );
                                                    s3 = string.Format ( "P{0}[{1,4},{2,4},{3,4}]" , k , A_ava4 , B_ava4 , C_ava4 );
                                                    s4 = string.Format ( "P{0}[{1,4},{2,4},{3,4}]" , l , A_ava5 , B_ava5 , C_ava5 );
                                                    s5 = string.Format ( "P{0}[{1,4},{2,4},{3,4}]" , m , A_ava6 , B_ava6 , C_ava6 );
                                                    MsgNone ( string.Format ( "解答{0,2}" , count ) );
                                                    MsgAns ( string.Format ( "{0}=>{1}=>{2}=>{3}=>{4}" , s1 , s2 , s3 , s4 , s5 ) );
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return count;
        }
        //取得NeedArr及Total
        private int [ ] GetNeedArr ( Panel Max , Panel Allocation , Panel Need , TextBox txt_ava , out int total )
        {
            //GUI清空需求量
            Need.Controls.Clear ( );
            int [ ] NeedArr = new int [ 5 ];
            int t = 0;
            for ( int i = 0 ; i < 5 ; i++ )
            {
                //取得max和allocation的textbox
                TextBox max = ( TextBox ) Max.Controls [ i ];
                TextBox allocation = ( TextBox ) Allocation.Controls [ i ];
                //若max或allocation未輸入 自動補0
                max.Text = max.Text.Length == 0 ? 0.ToString ( ) : max.Text;
                allocation.Text = allocation.Text.Length == 0 ? 0.ToString ( ) : allocation.Text;
                t += int.Parse ( allocation.Text );
                //計算need
                int need_value = int.Parse ( max.Text ) - int.Parse ( allocation.Text );
                //若需求量小於零 自動改為0
                need_value = need_value < 0 ? 0 : need_value;
                //放入arr
                NeedArr [ i ] = need_value;
                //need顯示
                Label lb_need = new Label ( );
                lb_need.Size = new System.Drawing.Size ( 50 , 33 );
                lb_need.TextAlign = ContentAlignment.MiddleCenter;
                lb_need.Text = need_value.ToString ( );
                txt_ava.Text = txt_ava.Text.Length == 0 ? 0.ToString ( ) : txt_ava.Text;
                lb_need.BackColor = int.Parse ( txt_ava.Text ) < need_value ? Color.Red : lb_need.BackColor;
                Need.Controls.Add ( lb_need );
            }
            total = t;
            return NeedArr;
        }
        //取得SafeArr
        private int [ ] GetSafeArr ( int A_available , int B_available , int C_available , int [ ] LastSafeArr )
        {
            int [ ] Safe_arr = new int [ 5 ];
            for ( int i = 0 ; i < 5 ; i++ )
            {
                if ( Aneed_arr [ i ] <= A_available & Bneed_arr [ i ] <= B_available & Cneed_arr [ i ] <= C_available )
                {
                    if ( LastSafeArr [ i ] < 0 )
                    {
                        //若為負數則已經做過 或不能做
                        Safe_arr [ i ] = LastSafeArr [ i ];
                    }
                    else
                    {
                        //設定1為有需求且滿足安全性
                        Safe_arr [ i ] = 1;
                    }
                }
                else
                {
                    if ( LastSafeArr [ i ] < 0 )
                    {
                        //若為負數則已經做過 或不能做
                        Safe_arr [ i ] = LastSafeArr [ i ];
                    }
                    else
                    {
                        //設定0為有需求且不滿足安全性
                        Safe_arr [ i ] = 0;
                    }
                }
            }
            return Safe_arr;
        }
        //Msg
        private void MsgWar ( string s )
        {
            rtxt_console.Text += "!!!!!---警告---!!!!!\t" + s + "\n";
        }
        private void MsgNone ( string s )
        {
            rtxt_console.Text += s + '\n';
        }
        private void MsgAns ( string s )
        {
            rtxt_console.Text += "-------------" + s + "\n\n";
        }
        #endregion
    }
}
