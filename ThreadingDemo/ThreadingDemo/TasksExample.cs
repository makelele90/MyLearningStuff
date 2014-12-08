
using System;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo
{
  public class TasksExample
  {
    public static void Start()
    {

      
        //create a cancelation token source
      var cts = new CancellationTokenSource();

      new Task(ComputerBoundOp,8).Start();

      //Task.Factory.StartNew(ComputerBoundOp, 10);

      var task = new Task<int>(() => WaitForTaskToComplete(cts.Token,10000) );
      task.Start();
      
      cts.Cancel();
      
      // You can get the result (the Result property internally calls Wait)
      try
      {
        task.Wait();
        Console.WriteLine("The Sum is: " + task.Result); // An Int32 value
      }
      catch (AggregateException x)
      {
        
       x.Handle(e=>e is OperationCanceledException);

        Console.WriteLine("Sum was canceled");
      }
     
    }

    private static void ComputerBoundOp(object id)
    {
      Console.WriteLine("Runing the task {0}",id);
    }

    private static int WaitForTaskToComplete(CancellationToken token,int n)
    {
      
      int sum = 0;
      for (; n>0; n--)
      {
       
        token.ThrowIfCancellationRequested();
        checked
        {
          sum += n;
        }
        Thread.Sleep(200);
      }

      return sum;
    }
  }
}
