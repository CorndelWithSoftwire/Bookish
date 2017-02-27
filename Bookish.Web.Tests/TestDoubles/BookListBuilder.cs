using System.Collections.Generic;
using System.Linq;
using Bookish.DataAccess;

namespace Bookish.Web.Tests.TestDoubles
{
  public class BookListBuilder
  {
    private int numberOfBooks = 10;
    private List<string> bookNames;

    public BookListBuilder WithNumberOfBooks(int number)
    {
      numberOfBooks = number;
      return this;
    }

    public BookListBuilder WithBookNamed(string name)
    {
      if (bookNames == null)
      {
        bookNames = new List<string>();
      }

      bookNames.Add(name);
      return this;
    }

    private IEnumerable<string> GenerateBookNames()
    {
      foreach (var name in bookNames)
      {
        yield return name;
      }

      int i = 0;
      while (true)
      {
        yield return $"Book #{i}";
        i++;
      }
    }

    public StubBookRepository CreateBookRepository()
    {
      var books = GenerateBookNames().Take(numberOfBooks)
        .Select(title => new Book { Title = title });

      return new StubBookRepository(books);
    }
  }
}