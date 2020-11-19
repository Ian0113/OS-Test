using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FIFO演算法
{
    public partial class Form1 : Form
    {

        private List<char> field = new List<char>(3);

        public Form1 ( )
        {
            InitializeComponent ( );
        }

        private void Form1_Load ( object sender , EventArgs e )
        {
        }

        private void rtxb_msg_TextChanged ( object sender , EventArgs e )
        {
            btn_inp.Enabled = rtxb_msg.Text.Length > 0 & ( rbtn_best.Checked | rbtn_fifo.Checked | rbtn_lru.Checked );
        }

        private void rbtn_CheckedChanged ( object sender , EventArgs e )
        {
            btn_inp.Enabled = rtxb_msg.Text.Length > 0 & ( rbtn_best.Checked | rbtn_fifo.Checked | rbtn_lru.Checked );
        }

        private void btn_clean_Click ( object sender , EventArgs e )
        {
            rbtn_best.Checked = rbtn_fifo.Checked = rbtn_lru.Checked = btn_inp.Enabled = false;
            lb_talfail.Text = lb_talhit.Text = lb_thisfail.Text = lb_thishit.Text = "0";
            dt.Rows.Clear ( );
            field.Clear ( );
        }

        private void btn_rtxb_clean_Click ( object sender , EventArgs e )
        {
            rtxb_msg.Text = "";
        }

        private void btn_inp_Click ( object sender , EventArgs e )
        {
            List<char> field = this.field;
            update_table ( ' ' , field , "?" );
            if ( rbtn_fifo.Checked )
            {
                fifo ( );
            }
            else if ( rbtn_best.Checked )
            {
                best ( );
            }
            else if ( rbtn_lru.Checked )
            {
                lru ( );
            }
        }

        private void fifo ( )
        {
            string s = rtxb_msg.Text;
            List<char> c = s.ToList ( );
            int hit = 0, fail = 0;
            foreach ( var item in c )
            {
                List<char> field;
                if ( item != ' ' )
                {
                    if ( this.field.Contains ( item ) )
                    {
                        field = this.field;
                        update_table ( item , field , "hit" );
                        hit += 1;
                    }
                    else
                    {
                        if ( this.field.Count == 3 )
                        {
                            this.field.RemoveAt ( 0 );
                        }
                        this.field.Add ( item );
                        field = this.field;
                        update_table ( item , field , "Fail" );
                        fail += 1;
                    }
                }
            }
            lb_talhit.Text = ( int.Parse ( lb_talhit.Text ) + hit ).ToString ( );
            lb_talfail.Text = ( int.Parse ( lb_talfail.Text ) + fail ).ToString ( );
            lb_thishit.Text = hit.ToString ( );
            lb_thisfail.Text = fail.ToString ( );
        }

        private void best ( )
        {
            string s = rtxb_msg.Text;
            List<char> c = s.ToList ( );
            int hit = 0, fail = 0;
            List<char> field;

            for ( int i = 0 ; i < c.Count ; i++ )
            {
                if ( c [ i ] != ' ' )
                {
                    if ( this.field.Contains ( c [ i ] ) )
                    {
                        field = this.field;
                        update_table ( c [ i ] , field , "hit" );
                        hit += 1;
                    }
                    else
                    {
                        if ( this.field.Count == 3 )
                        {
                            List<int> tmp;

                            List<List<int>> math_tal = new List<List<int>> ( );

                            for ( int j = 0 ; j < this.field.Count ; j++ )
                            {
                                int count = 0;
                                for ( int k = i + 1 ; k < c.Count ; k++ )
                                {
                                    count++;
                                    if ( this.field [ j ] == c [ k ] )
                                    {
                                        math_tal.Add ( new List<int> ( ) { count , c [ k ] } );
                                        break;
                                    }
                                }
                            }

                            if ( math_tal.Count < 3 )
                            {
                                for ( int j = 0 ; j < this.field.Count ; j++ )
                                {
                                    int count = 0;
                                    for ( int k = i + 1 ; k < c.Count ; k++ )
                                    {
                                        if ( this.field [ j ] == c [ k ] )
                                        {
                                            count += 1;
                                            break;
                                        }
                                    }
                                    if ( count == 0 )
                                    {
                                        this.field.RemoveAt ( j );
                                        break;
                                    }
                                }
                            }
                            else
                            {

                                for ( int j = 0 ; j < math_tal.Count ; j++ )
                                {
                                    for ( int k = 0 ; k < math_tal.Count ; k++ )
                                    {
                                        if ( math_tal [ j ] [ 0 ] > math_tal [ k ] [ 0 ] )
                                        {
                                            tmp = math_tal [ j ];
                                            math_tal [ j ] = math_tal [ k ];
                                            math_tal [ k ] = tmp;
                                        }
                                    }
                                }

                                this.field.Remove ( ( char ) math_tal [ 0 ] [ 1 ] );
                            }
                        }
                        this.field.Add ( c [ i ] );

                        field = this.field;
                        update_table ( c [ i ] , field , "Fail" );
                        fail += 1;
                    }
                }
            }
            lb_talhit.Text = ( int.Parse ( lb_talhit.Text ) + hit ).ToString ( );
            lb_talfail.Text = ( int.Parse ( lb_talfail.Text ) + fail ).ToString ( );
            lb_thishit.Text = hit.ToString ( );
            lb_thisfail.Text = fail.ToString ( );
        }

        private void lru ( )
        {
            string s = rtxb_msg.Text;
            List<char> c = s.ToList ( );
            int hit = 0, fail = 0;

            foreach ( var item in c )
            {
                List<char> field;
                if ( item != ' ' )
                {
                    if ( this.field.Contains ( item ) )
                    {
                        this.field.Remove ( item );
                        this.field.Add ( item );
                        field = this.field;
                        update_table ( item , field , "hit" );
                        hit += 1;
                    }
                    else
                    {
                        if ( this.field.Count == 3 )
                        {
                            this.field.RemoveAt ( 0 );
                        }
                        this.field.Add ( item );
                        field = this.field;
                        update_table ( item , field , "Fail" );
                        fail += 1;
                    }
                }
            }


            lb_talhit.Text = ( int.Parse ( lb_talhit.Text ) + hit ).ToString ( );
            lb_talfail.Text = ( int.Parse ( lb_talfail.Text ) + fail ).ToString ( );
            lb_thishit.Text = hit.ToString ( );
            lb_thisfail.Text = fail.ToString ( );
        }

        private void update_table ( char ch , List<char> c , string s )
        {
            if ( c.Count == 0 )
            {
                dt.Rows.Add ( ' ' , ' ' , ' ' , s , string.Format ( "<--{0}" , ch ) );
            }
            else if ( c.Count == 1 )
            {
                dt.Rows.Add ( c [ 0 ] , ' ' , ' ' , s , string.Format ( "<--{0}" , ch ) );
            }
            else if ( c.Count == 2 )
            {
                dt.Rows.Add ( c [ 0 ] , c [ 1 ] , ' ' , s , string.Format ( "<--{0}" , ch ) );
            }
            else
            {
                dt.Rows.Add ( c [ 0 ] , c [ 1 ] , c [ 2 ] , s , string.Format ( "<--{0}" , ch ) );
            }
        }

    }
}
