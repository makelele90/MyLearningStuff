using System;
using System.Web.Http;

namespace WebApiDemo
{
  public class HelloApiController:ApiController
  {
    public string Get()
    {
      return "hello from API at" + DateTime.Now.ToString();
    }
  }
}