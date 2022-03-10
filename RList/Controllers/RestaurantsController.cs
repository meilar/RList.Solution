using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using RList.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Rlist.Controllers
{
  public class RestaurantsController : Controller
  {
    private readonly RListContext _db;
    public RestaurantsController(RListContext db)
    {
      _db = db;
    }
    public ActionResult Index()
    {
      List<Restaurant> model = _db.Restaurants.Include(restaurant => restaurant.Cuisine).ToList();
      ViewBag.PageTitle = "View All Restaurants";
      return View(model);
    }
  }
}

