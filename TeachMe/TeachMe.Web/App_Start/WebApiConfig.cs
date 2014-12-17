

using System.Web.Http;

namespace TeachMe.Web
{
  public static class WebApiConfig
  {
    public static void Register(HttpConfiguration config)
    {
      config.Routes.MapHttpRoute(
          name: "usernameValidation",
          routeTemplate: "api/Authentication/IsUsernameAvailable",
          defaults: new { controller = "Authentication", action = "IsUsernameAvailable" }
      );
      config.Routes.MapHttpRoute(
          name: "DefaultApi",
          routeTemplate: "api/{controller}/{id}",
          defaults: new { id = RouteParameter.Optional }
      );
    }
  }
}
