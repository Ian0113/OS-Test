using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace 麵包演算法
{
    class Program
    {
        static object LOCK = new object();
        static object random_LOCK = new object();
        static Th th = new Th ( );
        static int th_count;
        static Queue<int> Thread_count = new Queue<int> ( );
        static int buy_count = 0;
        static int dly = random ( 500 );
        static void Main ( string [ ] args )
        {
            Console.Write ( "請輸入顧客數量 : " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out th_count ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "請輸入顧客數量 : " );
            }
            for ( int i = 0 ; i < th_count ; i++ )
            {
                Thread_count.Enqueue ( i );
            }
            for ( int i = 0 ; i < th_count ; i++ )
            {
                Console.WriteLine ( th.start ( string.Format ( "thread{0,2}" , i ) , TakeIDCard ) );
            }
            for ( int i = 0 ; i < th_count ; i++ )
            {
                th.join ( string.Format ( "thread{0,2}" , i ) );
            }
            Console.Write ( "\n學生 : 9A417018 何浩宸" );
            Console.Write ( "\n按任意鍵結束........." );
            Console.ReadKey ( );
        }

        static void TakeIDCard ( )
        {
            Thread.Sleep ( random ( 150 ) );
            Monitor.Enter ( LOCK );
            int num = Thread_count.Dequeue ( );
            Console.WriteLine ( "____________________________{0} : ({1})號" , Thread.CurrentThread.Name , num );
            Monitor.Exit ( LOCK );
            Buy ( num );
        }

        static void Buy ( int num )
        {
            while ( buy_count != num )
            {
                Thread.Sleep ( 5 );
            }
            Console.WriteLine ( "_________________________________________________{0}歸還號碼牌({1})...結束 " , Thread.CurrentThread.Name , num );
            buy_count += 1;
        }

        static int random ( int rangeg )
        {
            Monitor.Enter ( random_LOCK );
            dly = new Random ( dly ).Next ( 1 , rangeg );
            Monitor.Exit ( random_LOCK );
            return dly;
        }
    }
}
