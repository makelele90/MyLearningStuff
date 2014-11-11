using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSharpTypesDemo
{
  class Person:IComparable<Person>
  {
    const int ME = 10000;

    private readonly int MTAT = 100000;
    private static int _pat = 23;
    public Person(string name,int age)
    {
      Name = name;
      Age = age;
    }

    public string Name { get; set; }
    public int Age { get; set; }

    public int CompareTo(Person other)
    {
      return Age.CompareTo(other.Age);
    }

    

    public static Person operator +(Person left,Person right)
    {
      var p= new Person("new person",0);
      p.Age = left.Age + right.Age;
      return p;
    }
  }
}
