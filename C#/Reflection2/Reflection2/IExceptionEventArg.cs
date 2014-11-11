using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection2
{
  public interface IExceptionEventArg
  {
    string Message { get; set; }
  }

  public class DefaultExceptionEventArg:IExceptionEventArg
  {
    public string Message { get; set; }
  }
}
