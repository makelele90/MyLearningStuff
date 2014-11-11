using System;

namespace DelegateDemo
{
  class AnonymousMethodVsLambdaExpression
  {
    public void Start()
    {
      
      //Func<int, bool> func = delegate(int x) { return x < 5; };
      Func<int, bool> func = x => x < 5;
      Console.WriteLine(func(3));
      Console.WriteLine(func(6));
    }
  }
}
