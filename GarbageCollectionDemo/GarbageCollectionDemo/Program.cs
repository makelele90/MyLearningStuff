using System;

namespace GarbageCollectionDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      var cus = new Customer();

      Console.WriteLine("----------Starting-----------------------------");

    //  cus = null;
      cus.Dispose();
     // GC.Collect();

      Console.Read();
    }
  }
}
