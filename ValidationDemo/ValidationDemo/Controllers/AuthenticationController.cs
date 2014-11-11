using System.Web.Mvc;
using ValidationDemo.Models;

namespace ValidationDemo.Controllers
{
    public class AuthenticationController : Controller
    {
        //
        // GET: /Authentication/

      public ActionResult Register()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Register(RegistrationModel model)
        {
          return View();
        }

    }
}
