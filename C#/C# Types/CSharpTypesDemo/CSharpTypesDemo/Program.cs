using System;
using System.Collections;
using System.Collections.Generic;

struct MyStruct
{
  public int age;
  public int kids;

  public void calculate(){}
}

class Cow
{
  static int numberOfInstances;
  private int id;

  public Cow()
  {
    ++numberOfInstances;
  }
}
public class Base
{
  private int baseValue;
}

public class DerivedType:Base
{
  private float derivedValue;
}

public class Car
{
  public int MileAge { get; set; }
}

public class Scotter
{
  public int MileAge { get; set; }

  public static implicit operator Car(Scotter scotter)
  {
    return new Car() {MileAge = scotter.MileAge};
  }
  public static explicit operator Scotter(Car car)
  {
    return new Scotter() { MileAge = car.MileAge };
  }
}
namespace CSharpTypesDemo
{
  class Program
  {
    static void Main(string[] args)
    {
      #region Boxed Values are immutable
      /* int i = 5;
      object o = i;

      i = 25;
      Console.WriteLine(i);
      Console.WriteLine(o);
      var p = (int)o;
      p++;



      var sMyStruct = new MyStruct();


      sMyStruct.calculate(); */
      #endregion

      #region Get type information basic reflection
      //object o = 5;

      //Type t = o.GetType();

      //Console.WriteLine(t.Name);
      //Console.WriteLine(t.Namespace);
      //Console.WriteLine(t.AssemblyQualifiedName);
      #endregion

      #region Casting between types

      //Base baseType = new Base();

      //DerivedType derivedType = new DerivedType();

      //derivedType = (DerivedType)baseType;


      #endregion

      #region Casting 

      //int i = 5;

      //float f = i;

      //i = (int)f;
      #endregion

      #region Type conversion Operator

      Scotter scotter = new Scotter();


      //Car car = scotter;

      //Scotter sc = (Scotter)car;

      #endregion

      #region Playing with static variables

      var betsey = new Cow();
      var georgy = new Cow();
      var pat = new Cow();
      #endregion


      
      var p1 = new Person("francis", 29);
      var p2 = new Person("nounou", 27);
      var p3 = new Person("Didier", 32);

      var list = new List<Person>();
      list.Add(p1);
      list.Add(p2);
      list.Add(p3);

      list.Sort();

      foreach (var person in list)
      {
        Console.WriteLine(person.Name);
      }

      var p = p1 + p2;

     
      Console.WriteLine(p1.GetHashCode());
      Console.WriteLine("new adde p age {0}",p.Age);


      //The statement below is possible because of the out key word. This is covariance
      //New to .NET 4.0
      IEnumerable<Employee> employees = new List<Employee>();

      //Normal usage of out below
      var total = 0;

      Sum(2, 3, out total);
      Console.WriteLine("total {0}",total);

      //passing by reference
      int value=3;

      ChangeMyValue(ref value);
      //value is now 39
      Console.WriteLine("New value passed by ref {0}",value);





      var classA = new ClassA();

      Console.ReadKey();
    }

    public static void Sum(int a,int b,out int result)
    {
      result = a + b;
    }

    public static void ChangeMyValue(ref int value)
    {

      value = 39;
    }
  }


}
