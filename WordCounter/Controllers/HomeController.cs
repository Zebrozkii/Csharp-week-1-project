using Microsoft.AspNetCore.Mvc;
namespace WordCounter.Controllers
{
    public class HomeController : Controllers
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
    }
}
