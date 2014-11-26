using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using BusinessLogic.BLL;

namespace PlayingWithReflection
{
  [SuppressMessage]
  class Program
  {
    static void Main(string[] args)
    {
      var factory = new EmailSenderFactory();

      IEmailSender sender = factory.GetSender();

      //sender.Send();

      var config = factory.GetConfig();



      var collection = new CustomCollection<int> {1, 2, 3};

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
