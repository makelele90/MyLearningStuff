using System;
using System.Linq;

namespace LinqDemo
{
  class Joins
  {

    public void Start()
    {
      var DB = new northwindEntities();

      var results = from c in DB.Customers
                    join o in DB.Orders on c.CustomerID equals o.CustomerID
                    orderby c.ContactName
                    select new {Customer = c, Order = o};

      //Join and order
      var results2 = DB.Customers.Join(DB.Orders, c => c.CustomerID, o => o.CustomerID,
                                       (c, o) => new {c, o})
                       .OrderBy(tp => tp.c.ContactName)
                       .Select(tp => new {tp.c.ContactName, tp.o.OrderDate});
                    
       //find best customer

      var result12 = from c in DB.Customers
                     join o in DB.Orders on c.CustomerID equals o.CustomerID

                     group o by c
                     into g
                     let numOrders=g.Count()
                     orderby numOrders descending
                     select new
                       {
                        g.Key.ContactName ,numOrders
                       };


      //var result12_1= DB.Customers.Join(DB.Orders,c=>c.CustomerID,o=>o.CustomerID,(c,o)=>new {c,o})
      //          .GroupBy(pt=>pt.c,tp=>tp.o)

                      
      // results13 better than results12
      var result13 = from c in DB.Customers.Take(5)
                     join o in DB.Orders on c.CustomerID equals o.CustomerID into thisCustomerOrders
                     let numOrders = thisCustomerOrders.Count()
                       orderby numOrders descending
                       select new
                       {
                         c.ContactName,numOrders
                       };

      int[] a =new int[]{};

      var res = from d in a
                select a;

      foreach(var item in res)
        Console.WriteLine(item);
      foreach (var result in result13.Take(12))
      {
        Console.WriteLine(result.ContactName+" "+result.numOrders);
      }
     
    }
  }
}
