using System;

namespace ThreadingDemo
{
  public class HelloThreading
  {

    public static void SayHello(object id)
    {
      while (true)
      
        Console.WriteLine("Hello from thread {0}",id);
      
      
    }
  }
}
