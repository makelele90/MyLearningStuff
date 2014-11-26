
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsDemo.Interator_fibonaci
{
  public class FibonacciSquence
  {
    public int NumberOfValues { get; set; }

    public FibonacciSquence(int numberOfValues)
    {
      NumberOfValues = numberOfValues;
    }

    public IEnumerator<int> GetEnumerator()
    {
      throw new System.NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      //return the strongly type enumerator
      return GetEnumerator();
    }
  }
}
