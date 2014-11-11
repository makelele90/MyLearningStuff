using System.Collections;
using System.Collections.Generic;

namespace SOLID_Demo
{
  public class MayBe<T>:IEnumerable<T>
  {
    private readonly IEnumerable<T> _values;
 
    public MayBe()
    {
      _values=new T[0];
    }

    public MayBe(T value)
    {
      _values=new T[]{value};
    }
    public IEnumerator<T> GetEnumerator()
    {
      return _values.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
