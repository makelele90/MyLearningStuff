using System;
using System.Collections.Generic;

namespace ProjectEurlerDemo
{
  public  class FibonaccNumbers
  {
    public static void Start()
    {
      var fiboNumber = new List<int>(){1,2};
      int pointer = 0;

      while (fiboNumber[pointer+1]<4000000)
      {
        fiboNumber.Add(fiboNumber[pointer] + fiboNumber[pointer+1]);

        pointer++;
      }
      double sum = 0;

      fiboNumber.ForEach(el =>
        {
          if (el%2 == 0) sum += el;
        });


      Console.WriteLine(sum);
      
    }
  }
}
