
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Xml.Linq;

namespace BusinessLogic.BLL
{
  public  interface IEmailSenderFactory
  {
    IEmailSender GetSender();
    IXmlConfiguration GetConfig();
  }

  public class EmailSenderFactory : IEmailSenderFactory
  {
    private readonly AppConfiguration _configuration;
    public EmailSenderFactory()
    {
      _configuration = ConfigurationManager.GetSection("appConfig") as AppConfiguration;
    }
    public IEmailSender GetSender()
    {
      
        var sender = Activator.CreateInstance(Type.GetType(_configuration.EmailSenderType));

        return sender as IEmailSender;
      
      
    }

    public IXmlConfiguration GetConfig()
    {
      
      return new XmlConfiguration();
    }
  }
}
