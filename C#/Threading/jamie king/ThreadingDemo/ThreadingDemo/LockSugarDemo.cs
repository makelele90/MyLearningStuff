

using System;
using System.Threading;

namespace ThreadingDemo
{
 
  public class LockSugarDemo
  {
    static object baton = new object();

    public static void Sugar()
    {
      lock (baton)
      {
      }

      //Translation below
      var lockTaken = false;
      Monitor.Enter(baton, ref lockTaken);
      try
      {
        Console.WriteLine("Got the batton");
      }
      finally
      {
        if (lockTaken)
          Monitor.Exit(baton);
      }
    }
  }
}
