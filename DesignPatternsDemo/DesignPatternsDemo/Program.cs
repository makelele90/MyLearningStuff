using System;
using DesignPatternsDemo.Interator_fibonaci;

namespace DesignPatternsDemo
{
  class Program
  {
    static void Main()
    {
     /*  var subject = new Subject();

      //subscriber
      var sub1 = new Subscriber();
      var sub2 = new Subscriber();

      sub1.Subscribe(subject);
      sub2.Subscribe(subject);

      subject.SendMessage(new Payload(){Message = "kill me"});

      subject.EndTransmission(); */


      var sequence = new FibonacciSquence(10);

      foreach (var item in sequence)
      {
        Console.WriteLine(item);
      }

      Console.Read();
    }
  }
}
