using CSProjeDemo1.Entity.Base;

namespace CSProjeDemo1.Entity;

public class Library
{
    public Library()
    {
        Members = new List<Member>();
        Books = new List<Book>();
    }
    public List<Member> Members { get; set; }
    public List<Book> Books { get; set; }


    public void AddBook(Book book)
    {
        Books.Add(book);
    }
    public void AddMember(Member member)
    {
        Members.Add(member);
    }
    public void MemberBorrowBook(Member member, Book book)
    {
        member.BorrowABook(book);
    }

    public void MemberReturnBook(Member member, Book book)
    {
        member.ReturnABook(book);
    }
}
