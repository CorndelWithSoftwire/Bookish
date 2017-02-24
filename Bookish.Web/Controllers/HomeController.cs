using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;
using Microsoft.AspNet.Identity;

namespace Bookish.Web.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    private readonly BookRepository bookRepository = new BookRepository();

    public ActionResult Index()
    {
      var currentUser = User.Identity.GetUserId();
      var copiesBorrowed = bookRepository.GetCopiesBorrowedByUser(currentUser);

      return View(copiesBorrowed);
    }

    [AllowAnonymous]
    public ActionResult About()
    {
      ViewBag.Message = "A digital library for the 21st century";

      return View();
    }

    [AllowAnonymous]
    public ActionResult Contact()
    {
      ViewBag.Message = "Contact the Book(ish) team!";

      return View();
    }
  }
}