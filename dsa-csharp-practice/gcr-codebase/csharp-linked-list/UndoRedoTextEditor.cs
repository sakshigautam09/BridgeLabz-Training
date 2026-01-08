using System;

// Doubly Linked List Node
class TextNode
{
    public string Text;
    public TextNode Prev;
    public TextNode Next;

    public TextNode(string text)
    {
        Text = text;
        Prev = null;
        Next = null;
    }
}

// Text Editor
class TextEditor
{
    private TextNode head;
    private TextNode current;
    private int size = 0;
    private const int MAX = 10;

    // Add new state
    public void AddState(string text)
    {
        TextNode newNode = new TextNode(text);

        if (current != null)
            current.Next = null;

        newNode.Prev = current;

        if (current != null)
            current.Next = newNode;

        current = newNode;

        if (head == null)
            head = newNode;

        size++;
        if (size > MAX)
            head = head.Next;
    }

    // Undo
    public void Undo()
    {
        if (current != null && current.Prev != null)
            current = current.Prev;
    }

    // Redo
    public void Redo()
    {
        if (current != null && current.Next != null)
            current = current.Next;
    }

    // Display current text
    public void Display()
    {
        if (current != null)
            Console.WriteLine("Current Text: " + current.Text);
        else
            Console.WriteLine("No text available.");
    }
}

// Main
class UndoRedoTextEditor
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("Hello");
        editor.AddState("Hello World");
        editor.AddState("Hello World!");

        editor.Display();

        editor.Undo();
        editor.Display();

        editor.Redo();
        editor.Display();
    }
}
