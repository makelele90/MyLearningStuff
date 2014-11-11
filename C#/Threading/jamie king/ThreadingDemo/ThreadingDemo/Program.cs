using System;
using System.Threading;
namespace ThreadingDemo
{
  public class Program
  {
    static void Main()
    {
      //for (int i = 0; i < Environment.ProcessorCount; i++)
      //{
      //  var thread = new Thread(SayHello);
      // // thread.IsBackground = true;
      //  thread.Start(i);
        
      //}

      //var thread1 = new Thread(ThreadSyncIssues.IncrementCount);
      //Thread.Sleep(500);
      //var thread2 = new Thread(ThreadSyncIssues.IncrementCount);

      //thread1.Start();
      //thread2.Start();

      //for (int i = 0; i < 5; i++)
      //{
      //  new Thread(ThreadSyncSolution.UseRestroomStall).Start();
      //}
      //Console.WriteLine("leaving mean thread");

      DivideAndConquer.SumValues();
      Console.Read();
    }
    public static void SayHello(object id)
    {
      while (true)

        Console.WriteLine("Hello from thread {0}", Thread.CurrentThread.ManagedThreadId);


    }
  }
}

//Foreground thread will continue to execute even when the main thread has already finish with its job.
//Background thread will stop executing as soon as main thread finish its execution.
//----thread.IsBackground = true; <turn the thread into a background thread