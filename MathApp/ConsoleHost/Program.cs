
using System;
using System.ServiceModel;
using Calculation.DLL;

namespace ConsoleHost
{
  class Program
  {
    static void Main()
    {
      //host service
      var host = new ServiceHost(typeof(MathService));
      
      host.Open();

      Console.WriteLine("Type any key to exit........");

      Console.ReadKey();
      host.Close();
    }
  }
}
