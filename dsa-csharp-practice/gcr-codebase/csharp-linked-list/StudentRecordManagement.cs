using System;
public class StudentNode
{
    public int RollNumber;
    public string Name;
    public int Age;
    public char Grade;
    public StudentNode Next;

    public StudentNode(int rollNumber, string name, int age, char grade)
    {
        RollNumber = rollNumber;
        Name = name;
        Age = age;
        Grade = grade;
        Next = null;
    }
}
// Manages the Singly Linked List
public class StudentLinkedList
{
    private StudentNode head;

    public StudentLinkedList()
    {
        head = null;
    }

    // Add at beginning
    public void AddAtBeginning(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);
        newNode.Next = head;
        head = newNode;
    }

    // Add at end
    public void AddAtEnd(int roll, string name, int age, char grade)
    {
        StudentNode newNode = new StudentNode(roll, name, age, grade);

        if (head == null)
        {
            head = newNode;
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null)
            temp = temp.Next;

        temp.Next = newNode;
    }

    // Add at specific position (1-based index)
    public void AddAtPosition(int roll, string name, int age, char grade, int position)
    {
        if (position <= 1 || head == null)
        {
            AddAtBeginning(roll, name, age, grade);
            return;
        }

        StudentNode newNode = new StudentNode(roll, name, age, grade);
        StudentNode temp = head;
        int count = 1;

        while (temp.Next != null && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        newNode.Next = temp.Next;
        temp.Next = newNode;
    }

    // Delete by Roll Number
    public void DeleteByRollNumber(int roll)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        if (head.RollNumber == roll)
        {
            head = head.Next;
            Console.WriteLine("Student deleted.");
            return;
        }

        StudentNode temp = head;
        while (temp.Next != null && temp.Next.RollNumber != roll)
        {
            temp = temp.Next;
        }

        if (temp.Next == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        temp.Next = temp.Next.Next;
        Console.WriteLine("Student deleted.");
    }

    // Search by Roll Number
    public void SearchByRollNumber(int roll)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                Console.WriteLine($"Found → Roll: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    // Update Grade by Roll Number
    public void UpdateGrade(int roll, char newGrade)
    {
        StudentNode temp = head;

        while (temp != null)
        {
            if (temp.RollNumber == roll)
            {
                temp.Grade = newGrade;
                Console.WriteLine("Grade updated successfully.");
                return;
            }
            temp = temp.Next;
        }

        Console.WriteLine("Student not found.");
    }

    // Display all students
    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("No student records available.");
            return;
        }

        StudentNode temp = head;
        Console.WriteLine("\n--- Student Records ---");
        while (temp != null)
        {
            Console.WriteLine($"Roll: {temp.RollNumber}, Name: {temp.Name}, Age: {temp.Age}, Grade: {temp.Grade}");
            temp = temp.Next;
        }
    }
}

class StudentRecordManagement
{
    static void Main()
    {
        StudentLinkedList list = new StudentLinkedList();

        list.AddAtEnd(101, "Alice", 20, 'A');
        list.AddAtBeginning(102, "Bob", 21, 'B');
        list.AddAtPosition(103, "Charlie", 19, 'C', 2);

        list.DisplayAll();

        list.SearchByRollNumber(102);
        list.UpdateGrade(103, 'A');

        list.DisplayAll();

        list.DeleteByRollNumber(101);
        list.DisplayAll();
    }
}