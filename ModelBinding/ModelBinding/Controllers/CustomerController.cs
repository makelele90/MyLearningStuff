using System.Web.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
  public class CustomerController : Controller
  {
    //
    // GET: /Customer/

    public ActionResult Index()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Index(CustomerModel model)
    {
      return View(model);
    }

  }
}
