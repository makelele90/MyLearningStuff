
using System.ServiceModel;

namespace WcfContract.DLL
{
  [ServiceContract]
  public interface IArithmeticService
  {
    [OperationContract]
    int Add(int number1, int number2);
  }
}
