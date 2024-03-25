using CSProjeDemo1.Entity.Base;
using CSProjeDemo1.Enums;
using CSProjeDemo1.Interfaces;

namespace CSProjeDemo1.Entity;

public class Member : IMember
{
    public Member()
    {
        BorrowedBooks = new List<Book>();
    }

    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string MemberId { get; set; }
    public List<Book> BorrowedBooks { get; set; }

    public void BorrowABook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            throw new Exception($"{book.Title} isimli kitabı ödünç alamazsanız. Ödünç listenizde kitap mevcut!");
        }

        if (book.Status == Status.OduncAlinabilir)
        {
            book.Status = Status.Oduncte;
            BorrowedBooks.Add(book);
        }
        else
        {
            throw new Exception($"{book.Title} ödünç alınamaz!");
        }
    }

    public void ReturnABook(Book book)
    {
        if (BorrowedBooks.Contains(book))
        {
            book.Status = Status.OduncAlinabilir;
            BorrowedBooks.Remove(book);
            Console.WriteLine($"{book.Title} iade edildi.");
        }
        else
        {
            Console.WriteLine($"{book.Title} kitabı zaten ödünç almamışsınız.");
        }
    }
}

