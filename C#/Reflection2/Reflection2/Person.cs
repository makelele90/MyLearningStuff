
using System;

namespace Reflection2
{
  [PersonDecoratorAttribute]
  public class Person : IPerson
  {
    [Formatter("{firstname}")]
    public string FirstName { get; set; }

    [Formatter("{lastname}")]
    public string LastName { get; set; }

    [Formatter("{age}")]
    public int Age { get; set; }

    public string Message { get; set; }

    public void SayHello()
    {
      Console.WriteLine("hello word");
    }
  }
}

public interface IPerson
{
  void SayHello();
}