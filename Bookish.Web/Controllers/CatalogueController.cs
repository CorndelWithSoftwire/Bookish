using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;

namespace Bookish.Web.Controllers
{
  public class CatalogueController : Controller
  {
    private readonly BookRepository bookRepository = new BookRepository();

    public ActionResult Index()
    {
      var books = bookRepository.GetAllBooks();

      return View(books);
    }
  }
}