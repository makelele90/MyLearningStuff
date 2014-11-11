using System;
using System.Threading;

namespace ThreadingDemo
{
  public class ThreadSyncSolution
  {
    static readonly object Baton=new object();
    static Random _rand=new Random();
    public static void UseRestroomStall()
    {

     
      Console.WriteLine("{0} Trying to obtain the bathroom stall...",Thread.CurrentThread.ManagedThreadId);
      lock (Baton)
      {
        Console.WriteLine("{0} Obtained lock doing my stuffs....", Thread.CurrentThread.ManagedThreadId);

        Thread.Sleep(_rand.Next(2000));

        Console.WriteLine("{0} leaving the stall.....", Thread.CurrentThread.ManagedThreadId);
      }

      Console.WriteLine("{0} is leaving the restaurant", Thread.CurrentThread.ManagedThreadId);
    }
  }
}
