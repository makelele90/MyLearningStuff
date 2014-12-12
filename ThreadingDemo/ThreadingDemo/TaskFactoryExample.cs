using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace ThreadingDemo
{
  public class TaskFactoryExample
  {
    public static void Start()
    {
      //Task factory allow to share common configuration among multiple tasks.
      var parent = new Task(() =>
        {
          var cts = new CancellationTokenSource();

          var tf = new TaskFactory(cts.Token, TaskCreationOptions.AttachedToParent,
                                   TaskContinuationOptions.ExecuteSynchronously, TaskScheduler.Default);

          var childTasks = new[]
            {
              tf.StartNew(() => Sum(cts.Token, 200)),
              tf.StartNew(()=>Sum(cts.Token,100)),
              tf.StartNew(()=>Sum(cts.Token,int.MaxValue))
            };

          foreach (var child in childTasks)
            child.ContinueWith((t) => cts.Cancel(), TaskContinuationOptions.NotOnFaulted);

          tf.ContinueWhenAll(childTasks
                             ,
                             complatedTasks =>
                             complatedTasks.Where(cot => cot.Status == TaskStatus.RanToCompletion).Max(t => t.Result),
                             CancellationToken.None)
            .ContinueWith(t => Console.WriteLine("The maximum is: " + t.Result),
                          TaskContinuationOptions.ExecuteSynchronously);



        });

      //when the parent is done executing
      //we want to show any unhandled exception
      parent.ContinueWith(p =>
        {
          // we put all this text in a StringBuilder and call Console.WriteLine just once
          // because this task could execute concurrently with the task above & I don't
          // want the tasks' output interspersed
          var sb = new StringBuilder("The following exception(s) occurred:" + Environment.NewLine);

          foreach (var ex in p.Exception.Flatten().InnerExceptions)
          {
            sb.Append("   " + ex.GetType().ToString());

            Console.WriteLine(sb.ToString());
          }

        },TaskContinuationOptions.OnlyOnFaulted);

      parent.Start();
    }

    private static int Sum(CancellationToken ct, int n)
    {
      int sum = 0;
      for (; n > 0; n--)
      {

        
       
          ct.ThrowIfCancellationRequested();
        
        checked
        {
          sum += n;
        }
        
      }

      return sum;
    }
  }
}
