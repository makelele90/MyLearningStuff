using System;

namespace BusinessLogic.BLL
{
  public class EmailQueueSender : IEmailSender
  {
    public void Send()
    {
      Console.WriteLine("Sending email using email queue");
    }
  }
}