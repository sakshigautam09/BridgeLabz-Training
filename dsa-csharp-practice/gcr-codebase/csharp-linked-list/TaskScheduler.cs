using System;
class TaskNode
{
    public int Id;
    public string Name;
    public int Priority;
    public string DueDate;
    public TaskNode Next;

    public TaskNode(int id, string name, int priority, string dueDate)
    {
        Id = id;
        Name = name;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }
}
class TaskScheduler
{
    private TaskNode head;
    private TaskNode current;

    // Add at end (simplest)
    public void AddTask(int id, string name, int priority, string dueDate)
    {
        TaskNode newNode = new TaskNode(id, name, priority, dueDate);

        if (head == null)
        {
            head = newNode;
            newNode.Next = head;
            current = head;
            return;
        }

        TaskNode temp = head;
        while (temp.Next != head)
        {
            temp = temp.Next;
        }

        temp.Next = newNode;
        newNode.Next = head;
    }

    // Remove task by ID
    public void RemoveTask(int id)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks available.");
            return;
        }

        TaskNode temp = head;
        TaskNode prev = null;

        while (true)
        {
            if (temp.Id == id)
            {
                if (temp == head)
                {
                    TaskNode last = head;
                    while (last.Next != head)
                        last = last.Next;

                    head = head.Next;
                    last.Next = head;
                }
                else
                {
                    prev.Next = temp.Next;
                }

                Console.WriteLine("Task removed.");
                return;
            }

            prev = temp;
            temp = temp.Next;

            if (temp == head)
                break;
        }

        Console.WriteLine("Task not found.");
    }

    // View current task and move next
    public void NextTask()
    {
        if (current == null)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        Console.WriteLine($"Task: {current.Id}, {current.Name}, Priority: {current.Priority}, Due: {current.DueDate}");
        current = current.Next;
    }

    // Display all tasks
    public void DisplayTasks()
    {
        if (head == null)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        TaskNode temp = head;
        Console.WriteLine("\nTask List:");

        while (true)
        {
            Console.WriteLine($"{temp.Id} - {temp.Name} - Priority {temp.Priority} - Due {temp.DueDate}");
            temp = temp.Next;

            if (temp == head)
                break;
        }
    }

    // Search by priority
    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("No tasks.");
            return;
        }

        TaskNode temp = head;
        bool found = false;

        while (true)
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine($"{temp.Id} - {temp.Name} - Due {temp.DueDate}");
                found = true;
            }

            temp = temp.Next;
            if (temp == head)
                break;
        }

        if (!found)
            Console.WriteLine("No tasks with this priority.");
    }
}
class TaskScheduler
{
    static void Main()
    {
        TaskScheduler scheduler = new TaskScheduler();

        scheduler.AddTask(1, "Submit Assignment", 1, "10-Jan");
        scheduler.AddTask(2, "Project Meeting", 2, "12-Jan");
        scheduler.AddTask(3, "Prepare PPT", 1, "15-Jan");

        scheduler.DisplayTasks();

        scheduler.NextTask();
        scheduler.NextTask();

        scheduler.SearchByPriority(1);

        scheduler.RemoveTask(2);
        scheduler.DisplayTasks();
    }
}
