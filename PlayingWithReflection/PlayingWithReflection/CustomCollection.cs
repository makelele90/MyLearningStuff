using System.Collections;
using System.Collections.Generic;

namespace PlayingWithReflection
{
  public class CustomCollection<T>:IEnumerable<T>
  {
    private readonly List<T> _data;

    public T this[int index]
    {
      get { return _data[index]; }
    }
    public CustomCollection()
    {
      _data=new List<T>();
    }
    public void Add(T item)
    {
      _data.Add(item);
    }
    public void Remove(T item)
    {
      _data.Remove(item);
    }
    public IEnumerator<T> GetEnumerator()
    {
      return _data.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return GetEnumerator();
    }
  }
}
