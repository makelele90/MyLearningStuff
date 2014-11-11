using System;
using System.Threading;

namespace ThreadingDemo
{
  public class ThreadSyncIssues
  {

    public void Start(object threadId)
    {
      Console.WriteLine("My name");
      while (true)
        Console.WriteLine("Hello from DefferentMethod: " + Thread.CurrentThread.ManagedThreadId);
    }
  }
}
