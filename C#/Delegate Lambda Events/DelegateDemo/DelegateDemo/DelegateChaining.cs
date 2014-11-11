using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
  class DelegateChaining
  {
    private delegate void MeDelegate();
    private Action<string> del;
    public DelegateChaining()
    {
      del += Foo;
      del += Goo;
      del += Sue;

      del += Foo;

     
    }
    public void Start()
    {
      del("francis");
    }
    private void Foo(string from)
    {
      Console.WriteLine("Foo() "+from);
    }
    private void Goo(string from)
    {
      Console.WriteLine("Goo() "+from);
    }
    private void Sue(string from)
    {
      Console.WriteLine("Sue() "+from);
    }
  }
}
