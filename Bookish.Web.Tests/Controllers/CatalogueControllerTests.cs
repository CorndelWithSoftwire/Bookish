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
      const int numberOfBooks = 100;
      var repository = new BookListBuilder().WithNumberOfBooks(numberOfBooks).CreateBookRepository();
      var controller = new CatalogueController(repository);

      var viewResult = (ViewResult)controller.Index();

      var model = (CatalogueViewModel)viewResult.Model;
      Assert.Less(model.Books.Count(), numberOfBooks);
    }
  }
}
