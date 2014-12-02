using System;
using System.Threading;
namespace ThreadingDemo
{
  public class CooperativeCancelation
  {
    public static void Start()
    {
      //create a cancellation token source that can be used
      //to cancel a thread opereration
      var cts1 = new CancellationTokenSource();

      //create a linked token
      //make sure it cancel after 4 second
      var cts2 = new CancellationTokenSource();


      //will be cancel if any of token is canceled
      var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cts1.Token, cts2.Token);
      //This method will be called when the token is cancelled
      cts1.Token.Register(() => Console.WriteLine("Cancel 1"));
      cts2.Token.Register(() => Console.WriteLine("Cancel 2"));

      linkedCts.Token.Register(() => Console.WriteLine("Linked token cancelled"));
      //we can also pass CancellationToken.None if we don't want the operation to be 
      //canceled by external code
      ThreadPool.QueueUserWorkItem(o => Count(linkedCts.Token, 1000));

      Console.WriteLine("Press <Enter> to cancel the operation");
      Console.ReadLine();

      cts1.Cancel();
      Console.WriteLine("cts1 canceled={0}, cts2 canceled={1}, linkedCts canceled={2}",
cts1.IsCancellationRequested, cts2.IsCancellationRequested,
linkedCts.IsCancellationRequested);
      Console.ReadLine();
    }

    private static void Count(CancellationToken token, int countTo)
    {
      
      for (var count = 0; count < countTo; count++)
      {
        if (token.IsCancellationRequested)
        {
          Console.WriteLine("Count is cancelled");
          break;
        }

        Console.WriteLine(count);
        Thread.Sleep(200);
      }
      Console.WriteLine("Count is done");
    }

  }
}
