using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using Dapper;

namespace Bookish.DataAccess
{
  public class BookRepository
  {
    public IEnumerable<Book> GetAllBooks()
    {
      using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["MySqlServer"].ConnectionString))
      {
        return db.Query<Book>("SELECT * FROM Books");
      }
    }

    public IEnumerable<Copy> GetCopiesBorrowedByUser(string user)
    {
      using (var db = new SqlConnection(ConfigurationManager.ConnectionStrings["MySqlServer"].ConnectionString))
      {
        return db.Query<Copy, Book, Copy>(
          "SELECT * FROM Copies JOIN Books ON Books.Id = Copies.BookId WHERE Borrower = @user",
          (copy, book) => 
          {
            copy.Book = book;
            return copy;
          },
          new {user});
      }
    }
  }
}