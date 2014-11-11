using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
  class CSharpClosure
  {

    public void Start()
    {
     /* int i = 0;

      Action a = () => i++;

      a();
      a();
      a();
      Console.WriteLine(i); */

      Action a = GiveMeAction();
      a();
      a();
      a();
    }

    private Action GiveMeAction()
    {
      Action ret = null;

      int i = 0;

      ret += () =>
      {
        Console.WriteLine("First method "+ i++);
      };

      ret += () =>
      {
        Console.WriteLine("second method " + i++);
      };

      return ret;
    }
  }
}
