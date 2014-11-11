using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;

namespace ThreadingDemo
{
  public class DivideAndConquer
  {
    static readonly byte[] Values=new byte[500000000];
    private static long[] _portionsResults;
    private static int _portionSize;
    static void GenerateInts()
    {
      var rand = new Random();
      Console.WriteLine("Generating values.....");
      for (int i = 0; i < Values.Length; i++)
      {
        Values[i] =(byte)rand.Next(10);
      }
    }

    static void SumYourPortion(object portionNumber)
    {
      long sum = 0;
      var portionNumberAsInt = (int) portionNumber;
      var baseIndex = portionNumberAsInt*_portionSize;

      for (int i = baseIndex;i < baseIndex + _portionSize; i++)
      {
        sum += Values[i];
      }

      _portionsResults[portionNumberAsInt] = sum;

      
    }
    
    public static void SumValues()
    {
      _portionsResults=new long[Environment.ProcessorCount];
      _portionSize = Values.Length/Environment.ProcessorCount;
      var watch = new Stopwatch();
      GenerateInts();
      Console.WriteLine("Summing.....");

      watch.Start();
      long total = Values.Aggregate<byte, long>(0, (current, t) => current + t);
      watch.Stop();
      Console.WriteLine("Total value: {0}",total);
      Console.WriteLine("Time to sum {0}",watch.Elapsed);

      watch.Reset();
      watch.Start();
      var threads = new Thread[Environment.ProcessorCount];
      for (var i = 0; i < Environment.ProcessorCount; i++)
      {
        threads[i] = new Thread(SumYourPortion);

        threads[i].Start(i);
      }

      for (var i = 0; i < Environment.ProcessorCount; i++)
      {
        threads[i].Join();
      }

      long sum2 = 0;
      for (var i = 0; i < Environment.ProcessorCount; i++)
      {
        sum2 += _portionsResults[i];
      }
      watch.Stop();
      Console.WriteLine("Total value2: {0}", sum2);
      Console.WriteLine("Time to sum {0}", watch.Elapsed);
    }
  }
}
