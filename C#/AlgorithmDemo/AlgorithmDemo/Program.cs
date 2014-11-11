
using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmDemo
{
  class Program
  {
    static void Main()
    {
      var a = Enumerable.Range(1, 99999);

      var binarySearch = a.ToList().BinarySearch(8838);

      Console.WriteLine(binarySearch);

      var list = new List<int>() {1, 20, -1, -4, 9};

      list.Sort((x,y)=> x.CompareTo(y));

      list.ForEach(Console.WriteLine);
      Console.Read();
    }
  }
}
