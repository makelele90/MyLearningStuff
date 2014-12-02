using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AOPClient
{
  class Program
  {
    static void Main(string[] args)
    {
      var container = BootStrapper.RegisterAll();

      var orderDao = container.Resolve<IOrderDao>();

      orderDao.CreateOrder();

      Console.Read();

    }
  }
}
