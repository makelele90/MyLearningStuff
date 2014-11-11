
using System;
using System.Reflection;
using System.Linq;

namespace AttributeAndReflectionDemo
{

  public class TestAttribute : Attribute
  {
    
  }

  public class TestMethodAttribute : Attribute
  {
    
  }
  [TestAttribute]
  public class MyTestSuite
  {
    [TestMethod]
    public void Test1()
    {
      Console.WriteLine("Test 1");
    }
    [TestMethod]
    public void Test2()
    {
      Console.WriteLine("Test 2");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
      #region Basic test framework

      var types = Assembly.GetExecutingAssembly().GetTypes()
        .Where(t => t.GetCustomAttributes(false).Any(ca=>ca is TestAttribute));

      foreach (var type in types)
      {
        var testMethods =
          type.GetMethods().Where(m => m.GetCustomAttributes(false).Any(ca => ca is TestMethodAttribute));

        foreach (var testMethod in testMethods)
        {
          object instance = Activator.CreateInstance(type);

          testMethod.Invoke(instance, new object[] {});
        }
      }
      #endregion

      Console.Read();
    }
  }
}
