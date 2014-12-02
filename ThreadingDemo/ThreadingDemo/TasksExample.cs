
using System;
using System.Threading.Tasks;
using System.Threading;
namespace ThreadingDemo
{
  public class TasksExample
  {
    public static void Start()
    {
      new Task(ComputerBoundOp,8).Start();

      //Task.Factory.StartNew(ComputerBoundOp, 10);

      var task = new Task<int>(n => WaitForTaskToComplete((int)n), 100);
      task.Start();

      //task.Wait();
      // You can get the result (the Result property internally calls Wait)
      Console.WriteLine("The Sum is: " + task.Result); // An Int32 value
    }

    private static void ComputerBoundOp(object id)
    {
      Console.WriteLine("Runing the task {0}",id);
    }

    private static int WaitForTaskToComplete(int n)
    {
      
      int sum = 0;
      for (; n>0; n--)
      {
       
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
