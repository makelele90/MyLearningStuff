using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TeachMe.BLL.Services.Classes;
using TeachMe.BLL.Services.Interfaces;
using TeachMe.DAL.Repository.Classes;
using TeachMe.DataContainer.Data;
using TeachMe.Utility;
using TeachMe.Web.Models;

namespace TeachMe.Web.Controllers
{
    public class AuthenticationController : ApiController
    {
      private readonly IAuthenticationService _service = new AuthenticationService(new UserRepository());

      public HttpResponseMessage Get([FromUri] LoginModel data)
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

      public HttpResponseMessage Post([FromBody] RegistrationModel data)
      {
        var message = Request.CreateResponse(HttpStatusCode.NoContent);

        

        if (ModelState.IsValid)
        {
          var passwordSalt = PasswordHash.GenerateHexSaltString();
          var hashedPassword = PasswordHash.CreateHash(data.Password, passwordSalt);
          var user = new User()
            {
              CreatedOn = DateTime.Now,
              Password = hashedPassword,
              PasswordSalt = passwordSalt,
              Username = data.UserName,
              UserProfile = new UserProfile()
                {
                  FirstName = data.FirstName,
                  LastName = data.LastName,
                  Email = data.Email
                }
            };
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
