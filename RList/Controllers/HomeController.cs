using Microsoft.AspNetCore.Mvc;

namespace RList.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      ViewBag.PageTitle = "Best Restaurants";
      return View();
    }
  }
}