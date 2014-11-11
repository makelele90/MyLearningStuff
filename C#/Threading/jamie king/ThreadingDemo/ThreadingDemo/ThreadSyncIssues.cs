
using System;
using System.Threading;
namespace ThreadingDemo
{
  public class ThreadSyncIssues
  {
    public static int Count = 0;
    static object _baton= new object();
    public static void IncrementCount()
    {
      while (true)
      {
        lock (_baton)
        {
          int temp = Count;
          Thread.Sleep(1000);
          Count = temp + 1;
          Console.WriteLine("Thread ID: {0} Incremented count to: {1}", Thread.CurrentThread.ManagedThreadId,
            Count);
        }
       


        Thread.Sleep(1000);
      }
    

    }
  }

  

}
//NB: Every thread has its own allocated stack