
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsDemo.Interator_fibonaci
{
  public class FibonacciSquence : IEnumerable<double>
  {
    private int NumberOfValues { get; set; }

    public FibonacciSquence(int numberOfValues)
    {
      NumberOfValues = numberOfValues;
    }

    public IEnumerator<double> GetEnumerator()
    {
      //First approach using IEnumerator
      // return new FibonnacciEnumerator(NumberOfValues);
      var currentTotal = 0;
      var previousTotal = 0;

      for (var i = 0; i < NumberOfValues; i++)
      {
        if (i==0)
        {
          currentTotal = 1;
        }
        else
        {
          int newTotal = previousTotal + currentTotal;

          previousTotal = currentTotal;
          currentTotal = newTotal;
        }
        


        yield return currentTotal;

      }


    }


    IEnumerator IEnumerable.GetEnumerator()
    {
      //return the strongly type enumerator
      return GetEnumerator();
    }
  }
}
