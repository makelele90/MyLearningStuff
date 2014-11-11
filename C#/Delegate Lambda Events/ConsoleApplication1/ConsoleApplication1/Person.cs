using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
  class Person
  {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public  int Age { get; set; }

    public override string ToString()
    {
      return FirstName + " " + LastName;
    }
  }
}
