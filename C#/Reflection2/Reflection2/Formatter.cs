using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Reflection2
{
  public class FormatterAttribute : Attribute
  {
    public FormatterAttribute(string format)
    {
      Format = format;
    }

    public string Format { get; set; }
  }
}
