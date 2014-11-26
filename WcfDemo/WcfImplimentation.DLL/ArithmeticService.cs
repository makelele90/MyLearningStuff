using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfContract.DLL;

namespace WcfImplimentation.DLL
{
  [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
  public class ArithmeticService : IArithmeticService
  {
    [OperationBehavior(TransactionScopeRequired = true)]
    public int Add(int number1, int number2)
    {
      return number1 + number2;
    }
  }
}
