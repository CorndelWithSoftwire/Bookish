using System.Collections.Generic;

namespace Bookish.DataAccess
{
  public interface IBookRepository
  {
    IEnumerable<Book> GetAllBooks();
    IEnumerable<Book> SearchBooks(string searchText);
    Book GetBook(int id);
    IEnumerable<Copy> GetCopiesBorrowedByUser(string user);
    int AddBook(Book newBook, int copies);
  }
}