using System;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;

namespace ExpressionTreeDemo
{
  public class MeContext:DbContext
  {
    public MeContext()
      : base("BlogEngine")
    {
      
    }

   public DbSet<Person> People { get; set; }
  }
  class Program
  {
    static void Main()
    {
     /* //The expression will generate a collection of objects
      Expression<Func<int, bool>> exp = x => x > 6;
      var binExpress = (BinaryExpression) exp.Body;

      //This is what the compiler generated for us
      Expression<Func<int, bool>> expression;
      ParameterExpression expression3;
      ParameterExpression[] expressionArray;
      expression = Expression.Lambda<Func<int, bool>>(Expression.GreaterThan(expression3 = Expression.Parameter(typeof(int), "x"), Expression.Constant((int)6, typeof(int))), new ParameterExpression[] { expression3 });


      Console.WriteLine(binExpress.Left);
      Console.WriteLine(binExpress.Right);
      Console.WriteLine(binExpress.NodeType);
      */

      /*
      //Func<int, bool> test = i => i > 5;
      Console.WriteLine("--------------------------------------------------");
      var contExpress=  Expression.Constant(5, typeof (int));
      Console.WriteLine(contExpress.NodeType);
      Console.WriteLine(contExpress.Type);
      Console.WriteLine(contExpress.Value);

      Console.WriteLine("--------------------------------------------------");
      var intExpress = Expression.Parameter(typeof (int), "x");
      Console.WriteLine(intExpress.NodeType);
      Console.WriteLine(intExpress.Type);
      Console.WriteLine(intExpress.Name);
      //An Expression return a value


      var greaterExpress = Expression.GreaterThan(intExpress, contExpress);
      Console.WriteLine("--------------------------------------------------");
      Console.WriteLine(greaterExpress.NodeType);
      Console.WriteLine(greaterExpress.Left);
      Console.WriteLine(greaterExpress.Right);
     
     // 3 > 5 ===> False (value) */
    /*  Func<int, bool> test = i => i > 5;

      var contExpress=  Expression.Constant(5, typeof (int));
      var intExpress = Expression.Parameter(typeof (int), "x");
       var greaterExpress = Expression.GreaterThan(intExpress, contExpress);

       Expression<Func<int, bool>> lambda = Expression.Lambda<Func<int, bool>>(greaterExpress, intExpress);

      var meDel= lambda.Compile();

    Console.WriteLine(meDel(3));
    Console.WriteLine(meDel(8)); */


      var plumber = new MeContext();

      foreach (var p in plumber.People.Where(p=>p.Age>20))
      {
        Console.WriteLine(p.FirstName);
      }

      Console.Read();


    }
  }
}
