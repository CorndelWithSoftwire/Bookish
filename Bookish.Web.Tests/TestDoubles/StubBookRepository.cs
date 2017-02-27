using System.Collections.Generic;
using System.Linq;
using Bookish.DataAccess;

namespace Bookish.Web.Tests.TestDoubles
{
  public class StubBookRepository : IBookRepository
  {
    private readonly List<Book> books;

    public StubBookRepository(IEnumerable<Book> books)
    {
      this.books = books.ToList();
    }

    public IEnumerable<Book> GetAllBooks()
    {
      return books;
    }

    public IEnumerable<Book> SearchBooks(string searchText)
    {
      throw new System.NotImplementedException();
    }

    public Book GetBook(int id)
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Copy> GetCopiesBorrowedByUser(string user)
    {
      throw new System.NotImplementedException();
    }

    public int AddBook(Book newBook, int copies)
    {
      throw new System.NotImplementedException();
    }
  }
}