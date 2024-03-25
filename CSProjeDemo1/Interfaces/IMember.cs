using CSProjeDemo1.Entity.Base;

namespace CSProjeDemo1.Interfaces;

public interface IMember
{
    string FirstName { get; set; }
    string LastName { get; set; }
    string MemberId { get; set; }
    List<Book> BorrowedBooks { get; set; }

    void BorrowABook(Book book);
    void ReturnABook(Book book);
}
