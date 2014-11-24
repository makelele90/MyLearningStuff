
using System.Configuration;

namespace BusinessLogic.BLL
{
  public class AppConfiguration:ConfigurationSection
  {
    [ConfigurationProperty("emailSender")]
    public string EmailSenderType
    {
      get { return this["emailSender"].ToString(); }
      set { this["emailSender"] = value; }
    }
  }
}
