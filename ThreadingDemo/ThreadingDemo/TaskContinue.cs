using System;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingDemo
{
  public class TaskContinue
  {
    public static void Start()
    {
     
      var cs = new CancellationTokenSource();
      var task = new Task<int>(() => Sum(CancellationToken.None, 10));


      task.ContinueWith((ctask) => Console.WriteLine("sum result {0}", ctask.Result), TaskContinuationOptions.OnlyOnRanToCompletion)
          .ContinueWith((ctask) => PrintMessage(),TaskContinuationOptions.PreferFairness)
          .ContinueWith(ctask => Console.WriteLine("Sum threw: " + ctask.Exception.InnerException),TaskContinuationOptions.OnlyOnFaulted)
          .ContinueWith(cask => Console.WriteLine("Sum was canceled"),TaskContinuationOptions.OnlyOnCanceled);

      task.Start();


      var parent = new Task<Int32[]>(() =>
      {
        var results = new Int32[3]; // Create an array for the results
        // This tasks creates and starts 3 child tasks
        new Task(() => results[0] = Sum(CancellationToken.None,10), TaskCreationOptions.AttachedToParent).Start();
        new Task(() => results[1] = Sum(CancellationToken.None,20), TaskCreationOptions.AttachedToParent).Start();
        new Task(() => results[2] = Sum(CancellationToken.None,100), TaskCreationOptions.AttachedToParent).Start();
        // Returns a reference to the array (even though the elements may not be initialized yet)
        return results;
      });
      // When the parent and its children have run to completion, display the results
      var cwt = parent.ContinueWith(
      parentTask => Array.ForEach(parentTask.Result, Console.WriteLine));

      //starting the parent task will automatically start its children
      parent.Start();
    }
    private static int Sum(CancellationToken ct,int n)
    {
      int sum = 0;
      for (; n > 0; n--)
      {

        ct.ThrowIfCancellationRequested();
        checked
        {
          sum += n;
        }
        Thread.Sleep(200);
      }

      return sum;
    }

    private static void PrintMessage()
    {
      Console.WriteLine("Boy this task is completed");
    }
  }

  

  
}
