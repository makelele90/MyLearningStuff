using System;
using System.Collections.Generic;

namespace LinqDemo
{
  public class Person
  {
    private int _hello;

    public  void SayHello()
    {
      _hello++;
      Console.WriteLine("hello "+_hello);
    }
  }

  public static class MyExtention
  {
    public static void Scream(this Person p)
    {
      Console.WriteLine("screaming!!!!!!!!!!!!!!!!!!!!!");
    }
  }
  class Program
  {
    static void Main(string[] args)
    {
     
      /*  var person = new Person();

        person.SayHello(); person.SayHello(); person.SayHello();

        person.Scream(); */


    /*  var lt=new LinqTranslation();
      lt.Start();

      var letClause = new LetClauseInDeep();

      letClause.Star(); */

      var joins = new Joins();

      joins.Start();

      foreach (var s in args)
      {
        
      }

      Console.Read();
    }
  }
}
