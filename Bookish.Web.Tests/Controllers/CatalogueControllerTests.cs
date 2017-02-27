using System.Linq;
using System.Web.Mvc;
using Bookish.DataAccess;
using Bookish.Web.Controllers;
using Bookish.Web.Models;
using Bookish.Web.Tests.TestDoubles;
using NUnit.Framework;

namespace Bookish.Web.Tests.Controllers
{
  [TestFixture]
  public class CatalogueControllerTests
  {
    [Test]
    public void Index_ReturnsOnePage()
    {
      var books = Enumerable.Range(1, 100).Select(i => new Book {Title = $"Book #{i}"}).ToList();
      var repository = new StubBookRepository(books);
      var controller = new CatalogueController(repository);

      var viewResult = (ViewResult)controller.Index();

      var model = (CatalogueViewModel)viewResult.Model;
      Assert.Less(model.Books.Count(), books.Count);
    }
  }
}
