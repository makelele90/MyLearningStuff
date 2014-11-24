using System;

namespace DesignPatternsDemo
{
  class Program
  {
    static void Main()
    {
      var subject = new Subject();

      //subscriber
      var sub1 = new Subscriber();
      var sub2 = new Subscriber();

      sub1.Subscribe(subject);
      sub2.Subscribe(subject);

      subject.SendMessage(new Payload());

      subject.EndTransmission();

      Console.Read();
    }
  }
}
