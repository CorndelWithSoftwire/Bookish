using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bookish.DataAccess;
using Bookish.Web.Models;

namespace Bookish.Web.Controllers
{
  public class CatalogueController : Controller
  {
    private readonly BookRepository bookRepository = new BookRepository();
    private const int PageSize = 20;

    public ActionResult Index(int page = 1)
    {
      var allBooks = bookRepository.GetAllBooks().OrderBy(book => book.Title);
      var pageOfBooks = allBooks.Skip((page - 1)*PageSize).Take(PageSize);
      var totalPages = (int)Math.Ceiling(allBooks.Count()/(double)PageSize);

      return View(new CatalogueViewModel(page, totalPages, pageOfBooks));
    }
  }
}