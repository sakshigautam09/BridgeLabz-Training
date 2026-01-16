class BookNode
{
    public string Title;
    public BookNode Next;

    public BookNode(string title)
    {
        this.Title = title;
        this.Next = null;
    }
}