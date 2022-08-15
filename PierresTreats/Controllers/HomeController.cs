using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using PierresTreats.Models;
using System.Linq;


namespace PierresTreats.Controllers
{
    public class HomeController : Controller
    {
         private readonly PierresTreatsContext _db;

    public HomeController(PierresTreatsContext db)
    {
      _db = db;
    }


      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

         public ActionResult SeeAll()
    {
      List<Flavor> flavors = _db.Flavors.ToList();
      List<Treat> treats = _db.Treats.ToList();
      return View((flavors, treats));
    }

    }
}