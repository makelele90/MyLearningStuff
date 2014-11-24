using System;

namespace PlayingWithReflection
{
  public interface IXmlConfiguration
  {
     string Host { get; set; }
     string Number { get; set; }
     string EmailAddress { get; set; }
  }
  public class XmlConfiguration:IXmlConfiguration
  {
    [Config]
    public string Host { get; set; }
    [Config]
    public string Number { get; set; }
    public string EmailAddress { get; set; }
  }

  public class ConfigAttribute:Attribute
  {
    
  }
}
