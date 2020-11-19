using System;
using System.Collections.Generic;
using System.Security;
using System.Threading;


class Th
{

    #region 全域變數

    /*執行緒清單*/
    private List<Thread> thread_list = new List<Thread>();

    /*鎖定更改及讀取*/
    private object LOCK = new object();

    /*取得使用者清單*/
    public List<Thread> th_list
    {
        get
        {
            lock ( LOCK )
            {
                return thread_list;
            }
        }
    }

    /*中斷所有執行緒*/
    public string exit
    {
        get => ExitAllThread ( );
    }

    #endregion

    #region 啟動執行緒不用傳參
    public string start ( string ThreadName , ThreadStart Function )
    {
        lock ( LOCK )
        {
            try
            {
                Thread th = new Thread ( Function )
                {
                    Name = ThreadName ,
                    IsBackground = true
                };
                thread_list.Add ( th );
                th.Start ( );
                return "\"" + ThreadName + "\"" + "已執行!!!";
            }
            catch ( Exception )
            {
                return "創建錯誤 : 創建\"" + ThreadName + "\"失敗!!!";
            }
        }
    }
    #endregion

    #region 啟動執行緒傳參
    public string start ( string ThreadName , ParameterizedThreadStart Function , object Value )
    {
        lock ( LOCK )
        {
            try
            {
                Thread th = new Thread ( Function )
                {
                    Name = ThreadName ,
                    IsBackground = true
                };
                thread_list.Add ( th );
                th.Start ( Value );
                return "\"" + ThreadName + "\"" + "已執行!!!";
            }
            catch ( Exception )
            {
                return "創建錯誤 : 創建\"" + ThreadName + "\"失敗!!!";
            }
        }
    }
    #endregion

    #region 等待某執行緒
    public string join ( string WaintThreadName )
    {
        lock ( LOCK )
        {
            try
            {
                foreach ( Thread t in thread_list )
                {
                    if ( t.Name == WaintThreadName )
                    {
                        t.Join ( );
                    }
                }
                return "等待\"" + WaintThreadName + "\"中...";
            }
            catch ( Exception )
            {
                return "等待錯誤 : 等待\"" + WaintThreadName + "\"失敗!!!";
            }
        }
    }
    #endregion

    #region 中止指定執行緒
    public string stop ( string ThreadName )
    {
        lock ( LOCK )
        {
            try
            {
                int remove_num = -1;
                foreach ( Thread t in thread_list )
                {
                    if ( t.Name == ThreadName )
                    {
                        t.Abort ( );
                        t.DisableComObjectEagerCleanup ( );
                        remove_num = thread_list.IndexOf ( t );
                    }
                }
                thread_list.RemoveAt ( remove_num );
                return "\"" + ThreadName + "\"" + "已中止!!!";
            }
            catch ( ArgumentOutOfRangeException )
            {
                return "中止錯誤 : 並未找到\"" + ThreadName + "\"!!!";
            }
            catch ( SecurityException )
            {
                return "中止錯誤 : 安全性問題 !!";
            }
        }
    }
    #endregion

    #region 中斷所有執行緒
    private string ExitAllThread ( )
    {
        foreach ( Thread t in thread_list )
        {
            if ( t.IsAlive )
            {
                t.Abort ( );
                t.DisableComObjectEagerCleanup ( );
            }
        }
        thread_list.Clear ( );
        return "已結束所有執行緒!";
    }
    #endregion

}

