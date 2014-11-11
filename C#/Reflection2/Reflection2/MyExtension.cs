using System;
using System.Collections.Generic;
using System.Linq;

namespace Reflection2
{
  public static  class MyExtension
  {
    public static T[] Common<T>(this T[] firstCollection, T[] secondCollection)
    {
      return firstCollection.Where(item => secondCollection.ToList().BinarySearch(item) > -1).ToArray();
    }
  }
}
