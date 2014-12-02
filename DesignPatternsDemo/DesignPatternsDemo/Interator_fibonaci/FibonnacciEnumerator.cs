
using System;
using System.Collections;
using System.Collections.Generic;

namespace DesignPatternsDemo.Interator_fibonaci
{
  public class FibonnacciEnumerator:IEnumerator<double>
  {
    private readonly double _numberOfValues;
    private int _currentPosition;
    private int _previousTotal;
    private int _currentTotal;

    public FibonnacciEnumerator(double numberOfValues)
    {
      _numberOfValues = numberOfValues;
    }

    public double Current
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

        _previousTotal = _currentTotal;
        _currentTotal = newTotal;


      }

      _currentPosition++;

      return _currentPosition <= _numberOfValues;
    }
    public void Reset()
    {
      _currentPosition = 0;
      _previousTotal = 0;
      _currentTotal = 0;
    }
    public void Dispose()
    {
      GC.SuppressFinalize(this);
    }
  }
}
