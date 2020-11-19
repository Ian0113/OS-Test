using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 生產者與消費者_我認為最佳_
{
    class Company
    {
        #region 全域

        //自制執行緒類別
        public Th th = new Th();

        //存取buffer 共用鎖
        private object BUFFER_LOCK = new object();

        //存取 避免亂數重複 共用鎖
        private object random_LOCK = new object();

        //buffer大小
        private int buffer_size;

        //buffer
        private Queue<int> buffer = new Queue<int> ();

        //限制寫入號誌
        private Semaphore write_semaphore;

        //限制讀取號誌
        private Semaphore read_semaphore;

        //產生寫入buffer的物件
        private int write_item = 0;

        //random seed 防止同時間產生相同亂數 須要給不同的seed
        private int ran_seed = 0;

        //寫入開關
        private bool while_sw = true;

        #endregion

        //建構子 傳入buffer大小
        public Company ( int buffer_size )
        {
            //設定buffer大小
            this.buffer_size = buffer_size;

            //設定寫入號誌為buffer_size個  可用的號誌有buffer_size個
            this.write_semaphore = new Semaphore ( buffer_size , buffer_size );

            //設定讀取號誌為buffer_size個  可用的號誌有0個
            this.read_semaphore = new Semaphore ( 0 , buffer_size );
        }

        #region 公用方法

        //關閉company
        public void Close ( )
        {
            while_sw = false;
            Console.WriteLine ( th.exit );
        }

        //放入產品
        public void SetItem ( object random_range )
        {
            while ( while_sw )
            {
                write_semaphore.WaitOne ( );

                //延遲dly毫秒
                int dly = random ( ( int ) random_range );
                Console.WriteLine ( string.Format ( "---------------------------------------------------{0}隨機睡眠{1}(ms)" , Thread.CurrentThread.Name , dly ) );
                Thread.Sleep ( dly );

                //將write_item放入buffer 之後 +1 取餘
                Add_Buffer_Item ( );

                //反還一個讀取號誌
                read_semaphore.Release ( );
            }
        }

        //購買商品
        public void GetItem ( object random_range )
        {
            read_semaphore.WaitOne ( );

            //延遲dly毫秒
            int dly = random ( ( int ) random_range );
            Console.WriteLine ( string.Format ( "---------------------------------------------------{0}隨機睡眠{1}(ms)" , Thread.CurrentThread.Name , dly ) );
            Thread.Sleep ( dly );

            //將buffer 首位item移除  並輸出至remove_item
            Remove_Buffer_Item ( );

            //反還一個寫入號誌
            write_semaphore.Release ( );
        }

        #endregion

        #region 私用方法

        //將 item放入buffer
        private void Add_Buffer_Item ( )
        {
            Monitor.Enter ( BUFFER_LOCK );
            /*-----------臨界區--------*/
            
            //新增item
            buffer.Enqueue ( write_item );
            Console.WriteLine ( string.Format ( "{0} 放入產品 {1}" , Thread.CurrentThread.Name , write_item ) );
            write_item = ( write_item + 1 ) % buffer_size;

            /*-----------臨界區--------*/
            Monitor.Exit ( BUFFER_LOCK );
        }

        //將 item移出buffer
        private void Remove_Buffer_Item ( )
        {
            Monitor.Enter ( BUFFER_LOCK );
            /*-----------臨界區--------*/

            //移除item
            Console.WriteLine ( string.Format ( "------------------------{0} 購買商品 {1}" , Thread.CurrentThread.Name , buffer.Dequeue ( ) ) );

            /*-----------臨界區--------*/
            Monitor.Exit ( BUFFER_LOCK );
        }

        //隨機亂數
        private int random ( int slp )
        {
            /*亂數函式 產生1~slp的亂數
            第一次之後進來的拿上一個產生的變數當種子*/
            Monitor.Enter ( random_LOCK );
            ran_seed = new Random ( ran_seed ).Next ( 1 , slp );
            Monitor.Exit ( random_LOCK );
            return ran_seed;
        }

        #endregion
    }
}
