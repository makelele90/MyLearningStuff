using System;

namespace SOLID_Demo
{
  class Program
  {
    static void Main(string[] args)
    {
      var maybe = new MayBe<int>(8);

      foreach (var i in maybe)
      {
        Console.WriteLine("value:"+i);
      }

      string a = "";
      string b = "";

      a.Equals(b);
      Console.Read();
    }
  }
}
