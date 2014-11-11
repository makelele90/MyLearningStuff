using System;
using System.IO;

namespace DelegateDemo
{
  class CompilerClosureImplementaion
  {

    public void Start()
    {
      Action a = GiveMeAction();

      a();
    }

    private Action GiveMeAction()
    {
      int i = 0;

      return () => i++;
    }
  }
}
