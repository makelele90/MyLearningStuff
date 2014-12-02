using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using WcfImplimentation.DLL;

namespace HostingWcf
{
  class Program
  {
    static void Main(string[] args)
    {
      //hosting the service
      var host = new ServiceHost(typeof(ArithmeticService));

      host.Open();

      Console.WriteLine("Type a key to terminated");
      Console.ReadKey();
      host.Close();
    }
  }
}
