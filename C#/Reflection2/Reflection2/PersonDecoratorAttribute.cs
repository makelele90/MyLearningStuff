using System;
using System.Linq;
namespace Reflection2
{
  public class PersonDecoratorAttribute : Attribute
  {
     public void Prepare(Person source, Person taget)
     {
       var datas = source.GetType().GetProperties().Where(p => p.GetCustomAttributes(false).Any())
                         .Select(p => new
                           {
                             Property = p,
                             Decortator = p.GetCustomAttributes(false).FirstOrDefault(ca => ca is FormatterAttribute)
                           });

       foreach (var data in datas)
       {
         var format = ((FormatterAttribute) data.Decortator).Format;
         var propValue = data.Property.GetValue(source, null).ToString();
         taget.Message = taget.Message.Replace(format, propValue);
       }


     }
  }
}
