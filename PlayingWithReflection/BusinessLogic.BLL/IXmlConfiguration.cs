using System;
using System.Linq;
using System.Xml.Linq;

namespace BusinessLogic.BLL
{
  public interface IXmlConfiguration
  {
     string Host { get; set; }
     string Number { get; set; }
     string EmailAddress { get; set; }
  }
  public class XmlConfiguration:IXmlConfiguration
  {
    public XmlConfiguration()
    {
      var xmlDoc = XDocument.Load("configdata.xml");


      var properties =
        typeof(XmlConfiguration).GetProperties()
        .Where(p => p.GetCustomAttributes(typeof(ConfigAttribute), false).Any()).ToList();

      properties.ForEach(p =>
        {

          var xmlValue = xmlDoc.Descendants("myconfigs").Select(d => d.Element(p.Name).Value).SingleOrDefault();

          p.SetValue(this,xmlValue,null);
        });
      
    }
    [Config]
    public string Host { get; set; }
    [Config]
    public string Number { get; set; }
     [Config]
    public string EmailAddress { get; set; }
  }

  public class ConfigAttribute:Attribute
  {
   
  }
}
