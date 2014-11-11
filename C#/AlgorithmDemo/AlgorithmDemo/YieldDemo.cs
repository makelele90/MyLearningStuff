using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmDemo
{
  public class YieldDemo
  {
    static readonly Random Random=new Random();

    class GetDataClass:IEnumerable<int>,IEnumerator<int>
    {
      public int Count;
      private int _item;
      private int _current;
      private int _state;
      public IEnumerator<int> GetEnumerator()
      {
        return this;
      }

      IEnumerator IEnumerable.GetEnumerator()
      {
        return GetEnumerator();
      }
      public int Current
      {
        get { return _current; }
      }

      object IEnumerator.Current
      {
        get { return Current; }
      }
      public bool MoveNext()
      {
        switch (_state)
        {
          case 0:
            _item = 0;
            goto case 1;
          case 1:
            _state = 1;
            if (!(_item < Count))
              return false;
            _current = Random.Next();
            _state = 2;
            return true;
          case 2:
            _item++;
            goto case 1;

        }

        return false;
      }
      public void Dispose()
      {
        
      }
      public void Reset()
      {
        throw new System.NotImplementedException();
      }
    }
    public static IEnumerable<int> GetData(int count)
    {
      var ret = new GetDataClass();
      ret.Count = count;

      return ret;
    } 
  }
}
