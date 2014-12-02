
using System;
using Castle.DynamicProxy;

namespace AOPClient
{
  public class LoggingInterceptor:IInterceptor
  {
    public void Intercept(IInvocation invocation)
    {
      
      try
      {
        Console.WriteLine("Logging on start");
        invocation.Proceed();
        Console.WriteLine("Logging on success");
      }
      catch (Exception e)
      {
        Console.WriteLine("Exception has occured");
        throw;
      }
      finally
      {
        Console.WriteLine("Logging on exit");
      }
    }
  }
}
