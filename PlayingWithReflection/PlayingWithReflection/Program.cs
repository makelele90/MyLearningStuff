using System;
using System.Collections.Generic;
using BusinessLogic.BLL;

namespace PlayingWithReflection
{
  class Program
  {
    static void Main(string[] args)
    {
      var factory = new EmailSenderFactory();

      IEmailSender sender = factory.GetSender();

      //sender.Send();

      var config = factory.GetConfig();



      var collection = new CustomCollection<int>();

      collection.Add(1);
      collection.Add(2);
      collection.Add(3);
      Console.WriteLine(collection[0]);
      foreach (var i in collection)
      {
        Console.WriteLine(i);
      }
      Console.Read();


    }


    private static IEnumerable<int> GetInt()
    {
      yield return 1;
      yield return 2;
    }
  }
}
