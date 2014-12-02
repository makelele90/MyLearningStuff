
using System;
using ConsoleClient.UI.CalculationService;

namespace ConsoleClient.UI
{
  class Program
  {
    static void Main(string[] args)
    {
      var service = new MathServiceClient();

      var addResult = service.Add(9, 2);
      var mulResult = service.Multiply(6, 2);

      Console.WriteLine("9 + 2={0}",addResult);
      Console.WriteLine("6 * 2 ={0}",mulResult);

      Console.Read();
    }
  }
}
