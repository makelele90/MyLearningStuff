using System;

namespace Reflection2
{
  public class ExceptionLogger
  {
    public void LogException(IExceptionEventArg arg)
    {
      Console.WriteLine(arg.Message);
    }
  }
}
