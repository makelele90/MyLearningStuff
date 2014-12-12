using System;
using System.Threading.Tasks;

namespace ThreadingDemo
{
  public class PrallelDemo
  {
    public static void Start()
    {
      Parallel.Invoke(Method1, Method2,Method3);
    }

    private static void Method1()
    {
      Console.WriteLine("Method 1 executing");
    }
    private static void Method2()
    {
      Console.WriteLine("Method 2 executing");
    }
    private static void Method3()
    {
      Console.WriteLine("Method 3 executing");
    }
  }
}
