using System.Web.Mvc;
using TeachMe.Web.Models;

namespace TeachMe.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      var userModel = new LoginModel();
      return View(userModel);
    }
    public ActionResult Register()
    {
      var model = new RegistrationModel();
      return View(model);
    }
  }
}
