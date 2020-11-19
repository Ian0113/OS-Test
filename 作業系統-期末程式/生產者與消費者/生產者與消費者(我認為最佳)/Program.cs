using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 生產者與消費者_我認為最佳_
{
    class Program
    {
        static void Main ( string [ ] args )
        {
            //計時器
            Stopwatch time = new Stopwatch ( );
            //使用者輸入 buffer大小  producer執行緒數目  consumer執行緒數目
            int inp_buffer, inp_producer, inp_consumer;
            //使用者輸入 producer放入產品前延遲範圍1~range  consumer購買產品前延遲範圍1~range
            int producer_sleep_range, consumer_sleep_range;
            //使用者輸入 執行完畢延遲多久時間
            int dly;
            Console.Write ( "請輸入buffer大小 : " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out inp_buffer ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "請輸入buffer大小 : " );
            }
            Console.Write ( "請輸入生產者執行緒個數 : " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out inp_producer ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "請輸入生產者執行緒個數 : " );
            }
            Console.Write ( "請輸入生產者執行緒隨機睡眠亂數範圍(ms) 1 ~ " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out producer_sleep_range ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "請輸入生產者執行緒隨機睡眠亂數範圍(ms) 1 ~ " );
            }
            Console.Write ( "請輸入消費者執行緒個數 : " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out inp_consumer ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "請輸入消費者執行緒個數 : " );
            }
            Console.Write ( "請輸入消費者執行緒隨機睡眠亂數範圍(ms) 1 ~ " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out consumer_sleep_range ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "請輸入消費者執行緒隨機睡眠亂數範圍(ms) 1 ~ " );
            }
            Console.Write ( "執行完畢睡眠時間(ms) : " );
            while ( ( !int.TryParse ( Console.ReadLine ( ) , out dly ) ) )
            {
                Console.WriteLine ( "\n請輸入\"數字\"\n" );
                Console.Write ( "執行完畢睡眠時間(ms) : " );
            }
            //一間公司
            Company com = new Company ( inp_buffer );
            //生產者在公司內生產東西
            Consumer consumer = new Consumer ( com );
            //消費者在公司內買東西
            Producer producer = new Producer ( com );
            //開始計時(計算執行時間)
            time.Start ( );
            producer.Start ( inp_producer , producer_sleep_range );
            consumer.Start ( inp_consumer , consumer_sleep_range );
            //結束計時(計算執行時間)
            time.Stop ( );
            Console.WriteLine ( "\n\n花費時間:{0}ms\n" , time.Elapsed.TotalMilliseconds );
            //公司內無消費者 關閉
            com.Close ( );
            //準備結束
            Thread.Sleep ( 200 );
            Console.WriteLine ( "\n\n學生 : 9A417018 何浩宸" );
            Console.WriteLine ( "\n執行完畢,延遲{0}ms" , dly );
            Thread.Sleep ( dly );
        }
    }
}
