using System;
namespace Store;

public class Book
{
    public int Id { get; }
    public string Author { get; }
    public string Isbn { get; }
    public string Title { get; }
    public Book(int id, string isbn, string author, string title)
    {
        Id = id;
        Isbn = isbn;
        Author = author;
        Title = title;
    }

}
