using System;

namespace BusinessLogic.BLL
{
  public class SmtpEmailSender:IEmailSender
  {
    public void Send()
    {
      Console.WriteLine("Sending email using smtp email");
    }
  }
}