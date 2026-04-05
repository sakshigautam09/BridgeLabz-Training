public class GenreNode
{
    public string Genre;
    public BookLinkedList Books;

    public GenreNode(string genre)
    {
        this.Genre = genre;
        this.Books = new BookLinkedList();
    }
}
