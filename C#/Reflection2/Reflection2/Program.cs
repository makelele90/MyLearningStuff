using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using System;
namespace Reflection2
{
  class Program
  {
    private static event Action<IExceptionEventArg> ExceptionListener;
    static void Main(string[] args)
    {
      
     
      const int  PATOU = 0;

      var assembly = Assembly.GetExecutingAssembly();

      //var testClasses = assembly.GetTypes()
      //                          .Where(x => x.GetCustomAttributes(false).Any(ca => ca is TestFixtureAttribute));


      //foreach (var testClass in testClasses)
      //{
      //  var testMethods = testClass.GetMethods().Where(m => m.GetCustomAttributes(false).Any(cm => cm is TestAttribute));

      //  var classObj = Activator.CreateInstance(testClass);

      //  foreach (var testMethod in testMethods)
      //  {
      //    testMethod.Invoke(classObj,null);
      //  }
      //}

      //var person = new Person() {FirstName = "francis",LastName = "Tchatchoua",Age = 12};

      //var tagetPerson = new Person(){Message =  "Welecome {firstname} {lastname} is it true you are {age}"};

      //var decorators = person.GetType().GetCustomAttributes(false).Where(ca => ca is PersonDecoratorAttribute);

      //foreach (var decorator in decorators)
      //{
      //   ((PersonDecoratorAttribute)decorator).Prepare(person,tagetPerson);
      //}
      //  Console.WriteLine(tagetPerson.Message);
      //#endregion

      //Person myPerson = null;
      //var handler = new ExceptionLogger();
      //ExceptionListener += handler.LogException;


      //if (myPerson==null)
      //  ExceptionListener(new DefaultExceptionEventArg() { Message = "Person object is null" });
        
        
        
        
        
      //  //ExceptionListener(new DefaultExceptionEventArg(){Message = "crazy mate"});  
      //   // ExceptionListener.BeginInvoke(new DefaultExceptionEventArg() {Message = "crazy mate"},
      //     // ExecutionComplete, new MyAsyncState("Async sucess"));

      var stopwatch=new Stopwatch();

      stopwatch.Start();
      var array1 = new[] { 7, 8, 9, 10, 892, 0, 4, 5, 6, 1, 2, 3};

      var array2 = new[] { 13, 14, 154,12, 17, 892, 16, 11, 12, 17, 892 };
      var array3 = new[] {20,21,25,26,18,19,892,22,23,24};


      Array.Sort(array1);
      Array.Sort(array2);
      Array.Sort(array3);

      var result = array1.Common(array2).Common(array3);

      stopwatch.Stop();
      foreach (var i in result)
      {
        Console.WriteLine(i);
      }
      Console.WriteLine("time elepase: {0}",stopwatch.Elapsed);
      Console.Read();
    }

    


    static void ExecutionComplete(IAsyncResult result)
    {

      Console.WriteLine("-------execution complete-------------: Async State: {0}",((MyAsyncState)result.AsyncState).StateMessage);
    }
  }

  


}
