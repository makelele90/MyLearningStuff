using System;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace ThreadingDemo
{
  public class ThreadExecutionContext
  {
    public static void Start()
    {
      //Passing around in the flow of execution context from one thread
      //to another one

      CallContext.LogicalSetData("Name", "Francis");

      //do something with the threadpool thread
      ThreadPool.QueueUserWorkItem(state => Console.WriteLine("Name={0}", CallContext.LogicalGetData("Name")));


      //Now suppress the flowing of main thread excustion context 
      ExecutionContext.SuppressFlow();

      //queue another threadpool thread
      ThreadPool.QueueUserWorkItem(state => Console.WriteLine("Name={0}", CallContext.LogicalGetData("Name")));

      //restore the main thread execution context
      ExecutionContext.RestoreFlow();

      ThreadPool.QueueUserWorkItem(state => Console.WriteLine("Name={0}", CallContext.LogicalGetData("Name")));
    }
  }
}
