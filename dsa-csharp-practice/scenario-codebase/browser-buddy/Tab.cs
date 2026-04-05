using System;
class Tab
{
    private Node current;
    public Tab(string homepage)
    {
        current = new Node(homepage);
        Console.WriteLine("Opened: " + homepage);
    }
    public void Visit(string url)
    {
        Node newNode = new Node(url);
        current.Next = newNode;
        newNode.Prev = current;
        current = newNode;

        Console.WriteLine("Visited: " + url);
    }
    public void Back()
    {
        if (current.Prev != null)
        {
            current = current.Prev;
            Console.WriteLine("Back: " + current.Url);
        }
        else
        {
            Console.WriteLine("No back page");
        }
    }
    public void Forward()
    {
        if (current.Next != null)
        {
            current = current.Next;
            Console.WriteLine("Forward: " + current.Url);
        }
        else
        {
            Console.WriteLine("No forward page");
        }
    }
    public string GetCurrentPage()
    {
        return current.Url;
    }
}
