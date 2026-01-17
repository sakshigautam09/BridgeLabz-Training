class Tracker
{
    private User[] users;
    private int count;
    public Tracker(int size)
    {
        users = new User[size];
        count = 0;
    }
    // Add a user
    public void AddUser(string name, int steps)
    {
        if (count < users.Length)
        {
            users[count++] = new User(name, steps);
        }
        else
        {
            Console.WriteLine("User limit reached!");
        }
    }
    // Swap helper
    private void Swap(int i, int j)
    {
        User temp = users[i];
        users[i] = users[j];
        users[j] = temp;
    }
    // Bubble Sort descending
    public void BubbleSort()
    {
        for (int i = 0; i < count - 1; i++)
        {
            bool swapped = false;
            for (int j = 0; j < count - i - 1; j++)
            {
                if (users[j].Steps < users[j + 1].Steps)
                {
                    Swap(j, j + 1);
                    swapped = true;
                }
            }
            if (!swapped) break; // Already sorted
        }
    }
    // Display leaderboard
    public void DisplayLeaderboard()
    {
        Console.WriteLine("\n--- Daily Step Count Leaderboard ---");
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine($"{i + 1}. {users[i].Name} - {users[i].Steps} steps");
        }
    }
}