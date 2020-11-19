using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 生產者與消費者_我認為最佳_
{
    class Producer
    {
        Company com;
        public Producer ( Company com )
        {
            this.com = com;
        }

        public void Start ( int Tatol_Thread , int Sleep_Range )
        {
            //開啟生產者執行緒
            for ( int i = 0 ; i < Tatol_Thread ; i++ )
            {
                Console.WriteLine ( com.th.start ( string.Format ( "Producer{0,2}" , i ) , com.SetItem , Sleep_Range ) );
            }
        }

    }
}
