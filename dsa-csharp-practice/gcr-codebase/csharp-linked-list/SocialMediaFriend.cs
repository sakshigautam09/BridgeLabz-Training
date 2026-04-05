using System;
// User Node
class UserNode
{
    public int UserId;
    public string Name;
    public int Age;

    public int[] Friends = new int[10]; // max 10 friends
    public int FriendCount = 0;

    public UserNode Next;

    public UserNode(int id, string name, int age)
    {
        UserId = id;
        Name = name;
        Age = age;
        Next = null;
    }
}

// Singly Linked List
class SocialNetwork
{
    private UserNode head;

    // Add user
    public void AddUser(int id, string name, int age)
    {
        UserNode newUser = new UserNode(id, name, age);
        newUser.Next = head;
        head = newUser;
    }

    // Find user by ID
    private UserNode FindById(int id)
    {
        UserNode temp = head;
        while (temp != null)
        {
            if (temp.UserId == id)
                return temp;
            temp = temp.Next;
        }
        return null;
    }

    // Add friend connection
    public void AddFriend(int id1, int id2)
    {
        UserNode u1 = FindById(id1);
        UserNode u2 = FindById(id2);

        if (u1 == null || u2 == null)
        {
            Console.WriteLine("User not found.");
            return;
        }

        u1.Friends[u1.FriendCount++] = id2;
        u2.Friends[u2.FriendCount++] = id1;

        Console.WriteLine("Friend connection added.");
    }

    // Remove friend
    public void RemoveFriend(int id1, int id2)
    {
        UserNode u1 = FindById(id1);
        UserNode u2 = FindById(id2);

        RemoveFromArray(u1, id2);
        RemoveFromArray(u2, id1);

        Console.WriteLine("Friend connection removed.");
    }

    private void RemoveFromArray(UserNode user, int id)
    {
        for (int i = 0; i < user.FriendCount; i++)
        {
            if (user.Friends[i] == id)
            {
                for (int j = i; j < user.FriendCount - 1; j++)
                    user.Friends[j] = user.Friends[j + 1];

                user.FriendCount--;
                return;
            }
        }
    }

    // Mutual friends
    public void MutualFriends(int id1, int id2)
    {
        UserNode u1 = FindById(id1);
        UserNode u2 = FindById(id2);

        Console.Write("Mutual Friends: ");
        for (int i = 0; i < u1.FriendCount; i++)
        {
            for (int j = 0; j < u2.FriendCount; j++)
            {
                if (u1.Friends[i] == u2.Friends[j])
                    Console.Write(u1.Friends[i] + " ");
            }
        }
        Console.WriteLine();
    }

    // Display friends
    public void DisplayFriends(int id)
    {
        UserNode user = FindById(id);

        Console.Write($"Friends of {user.Name}: ");
        for (int i = 0; i < user.FriendCount; i++)
            Console.Write(user.Friends[i] + " ");

        Console.WriteLine();
    }

    // Count friends
    public void CountFriends()
    {
        UserNode temp = head;
        while (temp != null)
        {
            Console.WriteLine($"{temp.Name} has {temp.FriendCount} friends.");
            temp = temp.Next;
        }
    }
}

// Main
class SocialMediaFriend
{
    static void Main()
    {
        SocialNetwork sn = new SocialNetwork();

        sn.AddUser(1, "Amit", 20);
        sn.AddUser(2, "Riya", 21);
        sn.AddUser(3, "Neha", 22);

        sn.AddFriend(1, 2);
        sn.AddFriend(1, 3);

        sn.DisplayFriends(1);
        sn.MutualFriends(2, 3);
        sn.CountFriends();
    }
}
