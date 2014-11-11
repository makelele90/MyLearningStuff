using System;
using System.Collections.Generic;

namespace DelegateDemo
{
  class Program
  {
   // delegate void MeDelegate();
    delegate bool MeDelegate(int n);
    static void Main(string[] args)
    {
     /*  var dc = new DelegateChaining();
      dc.Start(); */

     /* var dce = new DelegateChainingAndException();

      dce.Start(); */

     /* var amLambda = new AnonymousMethodVsLambdaExpression();
      amLambda.Start(); */

     /* var closure =new CSharpClosure();
      closure.Start(); */


      /* var del = new EventVsDelegate();
      var car1 = new Car(del);
      var car2 = new Car(del);
      var car3 = new Car(del);
      Console.WriteLine();
      Console.WriteLine();
      var car4 = new Car(del);
      var car5 = new Car(del);
      var car6 = new Car(del);

      del.TheTrainIsComming(); */


      var del =new ImplementEventAddAndRemove();

      del.Mooing += () => Console.WriteLine("moooing 1");

      del.Mooing += () => Console.WriteLine("moooing 2");

      del.Mooing += () => Console.WriteLine("moooing 3");

      del.Mooing += () => Console.WriteLine("moooing 4"); 

      del.Moo();
      #region DELETEGATE SIMPLE

      /* var del = new MeDelegate(Foo);
      MeDelegate del = Foo;
      del();
      del.Invoke();

      InvokeDelegate(Foo);
      InvokeDelegate(new MeDelegate(Goo)); */

      #endregion

      #region WHY DELEGATE ARE USEFUL
      
     /* var numbers = new[] {1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 13, 14, 15};
      var result = RunNumberThroughTheGaunglet(numbers,n=>n >10 );
      
      foreach (var r in result)
      {
        Console.WriteLine(r);
      } */
      #endregion
      Console.Read();
    }

    #region DELETEGATE SIMPLE
   /* static void InvokeDelegate(MeDelegate deler)
    {
      deler();
    }
    static void Foo()
    {

      Console.WriteLine("Foo()");
    }
    static void Goo()
    {

      Console.WriteLine("Goo()");
    }
    * */
    #endregion
    /*
    static bool LessThanFive(int n)
    {
      return n < 5;
    }
    static bool LessThanTen(int n)
    {
      return n < 10;
    }
    static bool GreaterThanEleven(int n)
    {
      return n > 11;
    }
     */
    static IEnumerable<int> RunNumberThroughTheGaunglet(IEnumerable<int> numbers,MeDelegate gaunglet)
    {
      foreach (var number in numbers)
      {
        if (gaunglet(number)) yield return number;

      }
    }
     
    
  }
}
