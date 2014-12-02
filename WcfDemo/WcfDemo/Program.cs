using System;
using System.ServiceModel;
using WcfImplimentation.DLL;

namespace WcfDemo
{
  class Program
  {
    static void Main()
    {
      var service = new MathService.ArithmeticServiceClient();

      Console.WriteLine(service.Add(2,5));

      Console.ReadLine();
    }
  }
}
