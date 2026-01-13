using System;
public interface IBookService
{
    void AddBook(string title, string author);
    void SortBooks();
    void SearchByAuthor(string author);
    void DisplayBooks();
}
