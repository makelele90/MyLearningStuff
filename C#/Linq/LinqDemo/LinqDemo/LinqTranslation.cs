using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinqDemo
{
  class LinqTranslation
  {

    public void Start()
    {
      var entity = new northwindEntities();
     /* var numbers = new [] { 1,3,5,9,7,3,6,9,3,1,7};

      var results = numbers.Where(n => n < 5).Select(n=>n+5);
      
      //Translation

     // var results2 = Enumerable.Where(numbers, n => n < 5);

      foreach (var num in results) Console.WriteLine(num);

     // foreach (var num in results2) Console.WriteLine(num);

      var entity = new northwindEntities();



      var result0 = from e in entity.Employees
                    select new { e.FirstName, e.LastName };


      var result1 = entity.Employees.Select(e => new { e.FirstName,e.LastName});

      var result2 = Enumerable.Select(entity.Employees, e => new gdhhdh(e.FirstName,e.LastName));

      var result3 = Enumerable.Select(entity.Employees,em=> CompilerMethod(em));

      
      foreach (var e in result3)
      {
        Console.WriteLine(e.FirstName +" "+e.LastName);
      } */



      var results4 = from c in entity.Customers
                     group c by c.Country;


      var results5 = entity.Customers.GroupBy(c => c.Country);

      //Get country with the most people in it and order in descending order

      var results6 = results5.OrderByDescending(c => c.Count()).Select(c => new {Country = c.Key, NumberOfCustomers = c.Count()});

      //using the <let> clause

      var results7 = from g in results5
                     let numberCustomers = g.Count()
                     orderby numberCustomers descending
                     select new {Country = g.Key, NumCustomers = numberCustomers};


      //Understand into

      var results8= from c in entity.Customers
                    group c by c.Country into g
                    let numberCustomers = g.Count()
                    orderby numberCustomers descending
                    select new { Country = g.Key, NumCustomers = numberCustomers };


      //Grouping with multiple field

      var resluts9 = from c in entity.Customers
                     orderby c.Country
                     group c by new {c.Country, c.City};



      var result10 = from c in entity.Customers
                     group c.ContactName by new {c.Country, c.City};

      var result11 = entity.Customers.GroupBy(c => new {c.Country, c.City}, c => c.ContactName);


      
      foreach (var group in result11)
      { Console.WriteLine(group.Key);

      foreach (var name in group)
        Console.WriteLine(" " + name);
      }


      

      


    }

    public gdhhdh CompilerMethod(Employee em)
    {

      return new gdhhdh(em.FirstName, em.LastName);
    }
  }



  class gdhhdh
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public gdhhdh(string firstname,string lastname)
    {
      FirstName = firstname;
      LastName = lastname;
    }
  
  }
}
