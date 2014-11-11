using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  class Program
  {
    static void Main(string[] args)
    {
      var people = new List<Person>()
      {
        new Person{FirstName = "francis", LastName = "tchatchoua",Age = 16},
        new Person{FirstName = "francis1", LastName = "tchatchoua1",Age = 19},
        new Person{FirstName = "francis2", LastName = "tchatchoua2",Age = 28},
        new Person{FirstName = "francis3", LastName = "tchatchoua3",Age = 31},
        new Person{FirstName = "francis4", LastName = "tchatchoua4",Age = 24},
        new Person{FirstName = "francis5", LastName = "tchatchoua5",Age = 50}

      };

      var peopleResult = people.Where(x => IsMultipleOfTwo(x)).Select(x => x);

      foreach (var person in peopleResult)
      {
        Console.WriteLine(person);
      }

      Console.Read();
    }

    public static bool IsMultipleOfTwo(Person person)
    {
      return person.Age % 2==0;
    }
  }
}
