
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsDemo.Interator_fibonaci
{
  public class FibonnacciEnumerator:IEnumerator<int>
  {
    private int _numberOfValues;
    private int _currentPosition;
    private int _previousTotal;
    private int _currentTotal;

    public FibonnacciEnumerator(int numberOfValues)
    {
      _numberOfValues = numberOfValues;
    }

    public int Current
    {
      get { return _currentTotal; }
    }
    object IEnumerator.Current
    {
      get { return Current; }
    }
    public bool MoveNext()
    {
      if (_currentPosition==0)
      {
        _currentTotal = 1;
      }
      else
      {
        int newTotal = _previousTotal + _currentTotal;
        _pre
      }
    }
    public void Reset()
    {
     
    }
    public void Dispose()
    {
      
    }
  }
}
