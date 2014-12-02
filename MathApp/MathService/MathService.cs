using System;
using System.ServiceModel;
using System.Threading;

namespace Calculation.DLL
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
  public class MathService : IMathService
  {
    [OperationBehavior(TransactionScopeRequired = true)]
    public int Add(int number1, int number2)
    {
      var t = Thread.CurrentPrincipal;
      Console.WriteLine("identity name {0}",t.Identity.Name);
      Console.WriteLine("is authenticated {0}",t.Identity.IsAuthenticated);
      return number1 + number2;
    }

    public int Multiply(int number1, int number2)
    {
      return number1*number2;
    }
  }
}