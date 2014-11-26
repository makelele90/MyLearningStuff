using System;
using System.ServiceModel;
using WcfImplimentation.DLL;

namespace WcfDemo
{
  class Program
  {
    static void Main()
    {
      //hosting the service
      var host = new ServiceHost(typeof(ArithmeticService));

      host.Open();

      Console.WriteLine("Type a key to terminated");
      Console.ReadKey();
      host.Close();
    }
  }
}
