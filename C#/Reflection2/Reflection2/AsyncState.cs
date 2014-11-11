using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection2
{
  public class MyAsyncState
  {
    public MyAsyncState(string message)
    {
      StateMessage = message;
    }
    public string StateMessage { get; private set; }
  }
}
