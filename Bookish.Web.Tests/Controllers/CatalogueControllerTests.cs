using System.Linq;
using System.Web.Mvc;
using Bookish.Web.Controllers;
using Bookish.Web.Models;
using NUnit.Framework;

namespace Bookish.Web.Tests.Controllers
{
  [TestFixture]
  public class CatalogueControllerTests
  {
    [Test]
    public void Index_ReturnsOnePage()
    {
      var controller = new CatalogueController();

      var viewResult = (ViewResult)controller.Index();

      var model = (CatalogueViewModel)viewResult.Model;
      Assert.LessOrEqual(20, model.Books.Count());
    }
  }
}
