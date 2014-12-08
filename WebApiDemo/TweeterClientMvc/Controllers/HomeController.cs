using System.Net.Http;
using System.Web.Mvc;

namespace TweeterClientMvc.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      HttpHeader model = null;
      var client = new HttpClient();

     

      var task = client.GetAsync("http://headers.jsontest.com")
        .ContinueWith((taskwithresponse) =>
          {
            var response = taskwithresponse.Result;

            var readTask = response.Content.ReadAsAsync<HttpHeader>();

            readTask.Wait();
            model = readTask.Result;

          });

      task.Wait();

      return View(model);
    }

    public ActionResult About()
    {
      ViewBag.Message = "Your app description page.";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Your contact page.";

      return View();
    }
  }
}
