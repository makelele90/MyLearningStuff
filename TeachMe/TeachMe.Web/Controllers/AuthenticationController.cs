using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeachMe.BLL.Services.Classes;
using TeachMe.BLL.Services.Interfaces;
using TeachMe.DAL.Repository.Classes;
using TeachMe.DataContainer.Data;
using TeachMe.Web.Models;

namespace TeachMe.Web.Controllers
{
    public class AuthenticationController : ApiController
    {
      private readonly IAuthenticationService _service = new AuthenticationService(new UserRepository());
      
      [HttpPost]
      public HttpResponseMessage Login([FromBody] LoginModel data)
      {
        var message = Request.CreateResponse(HttpStatusCode.NoContent);

        if (ModelState.IsValid)
        {
          var status = _service.Login(data.Username, data.Password);

          if (status)
          {
            var user = _service.Find(data.Username);
            message = Request.CreateResponse(HttpStatusCode.OK, user);
          }
          
        }
        
        return message;
      }

      [HttpPost]
      public HttpResponseMessage Register([FromBody] RegistrationModel data)
      {
        var message = Request.CreateResponse(HttpStatusCode.NoContent);

        if (ModelState.IsValid)
        {
          var user = new User();
          var status = _service.CreateUser(user);

          if (status)
          {
            
            message = Request.CreateResponse(HttpStatusCode.Created);
            message.Headers.Location = new Uri(Request.RequestUri + "/" + user.Username);
          }

        }

        return message;
      }
    }
}
