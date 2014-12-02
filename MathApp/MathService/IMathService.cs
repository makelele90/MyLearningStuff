
using System.ServiceModel;

namespace Calculation.DLL
{
  [ServiceContract]
  public interface IMathService
  {
    [OperationContract]
    int Add(int number1, int number2);
    [OperationContract]
    int Multiply(int number1, int number2);
  }
}
