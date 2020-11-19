using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 生產者與消費者_我認為最佳_
{
    class Consumer
    {
        Company com;
        public Consumer ( Company com )
        {
            this.com = com;
        }

        public void Start ( int Tatol_Thread , int Sleep_Range )
        {
            //開啟消費者執行緒
            for ( int i = 0 ; i < Tatol_Thread ; i++ )
            {
                Console.WriteLine ( com.th.start ( string.Format ( "Consumer{0,2}" , i ) , com.GetItem , Sleep_Range ) );
            }
            //等待消費者執行緒完成
            for ( int i = 0 ; i < Tatol_Thread ; i++ )
            {
                com.th.join ( string.Format ( "Consumer{0,2}" , i ) );
            }
        }
    }
}
