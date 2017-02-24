using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Bookish.Web.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "A digital library for the 21st century";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Contact the Book(ish) team!";

      return View();
    }
  }
}