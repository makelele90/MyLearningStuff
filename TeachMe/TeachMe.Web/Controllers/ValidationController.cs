using System.Web.Mvc;
using TeachMe.BLL.Services.Classes;
using TeachMe.BLL.Services.Interfaces;
using TeachMe.DAL.Repository.Classes;

namespace TeachMe.Web.Controllers
{
    public class ValidationController :Controller
    {
      private readonly IAuthenticationService _service;

      public ValidationController()
      {
        _service=new AuthenticationService(new UserRepository());
      }
      public JsonResult IsUsernameAvailable(string username)
      {
        var user = _service.Find(username);

        if (user!=null)
        {
         return  Json(string.Format("{0} is not available",username),JsonRequestBehavior.AllowGet);
        }

        return  Json(true,JsonRequestBehavior.AllowGet);
      }
    }
}
