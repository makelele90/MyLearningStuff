using System.Web.Http;

namespace WebApiDemo
{
  public class SecondController:ApiController
  {
    public string Get()
    {
      return "this is second controller";
    }
  }
}