using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
  static class FirstLinqExtensionMethod
  {
    public static IEnumerable<T> Where<T>(this IEnumerable<T> source,Func<T,bool> predicate)
    {
      foreach (var item in source)
       if (predicate(item)) yield return item;
    }

    public static IEnumerable<R> Select<T,R>(this IEnumerable<T> source, Func<T,R> transform)
    {
      foreach (var item in source)
        yield return transform(item);
	
    }
  }
}
