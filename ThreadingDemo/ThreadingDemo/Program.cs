
using System;
using System.Threading;
using System.Runtime.Remoting.Messaging;

namespace ThreadingDemo
{
  class Program
  {
    static void Main()
    {
      
      //ThreadExecutionContext.Start();

     // CooperativeCancelation.Start();

      //TasksExample.Start();

      TaskContinue.Start();
      Console.Read();
    }

  }
}
