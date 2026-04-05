public class BookLinkedList
{
    private BookNode head;

    public bool AddBook(string title)
    {
        if (Contains(title))
            return false;

        BookNode newNode = new BookNode(title);

        if (head == null)
        {
            head = newNode;
        }
        else
        {
            BookNode temp = head;
            while (temp.Next != null)
                temp = temp.Next;

            temp.Next = newNode;
        }
        return true;
    }

    public bool RemoveBook(string title)
    {
        if (head == null)
            return false;

        if (head.Title == title)
        {
            head = head.Next;
            return true;
        }

        BookNode current = head;
        while (current.Next != null)
        {
            if (current.Next.Title == title)
            {
                current.Next = current.Next.Next;
                return true;
            }
            current = current.Next;
        }
        return false;
    }

    private bool Contains(string title)
    {
        BookNode temp = head;
        while (temp != null)
        {
            if (temp.Title == title)
                return true;
            temp = temp.Next;
        }
        return false;
    }

    public void Display()
    {
        BookNode temp = head;
        while (temp != null)
        {
            Console.WriteLine("  - " + temp.Title);
            temp = temp.Next;
        }
    }
}
