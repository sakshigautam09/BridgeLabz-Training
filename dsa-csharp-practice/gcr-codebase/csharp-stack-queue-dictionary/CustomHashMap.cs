using System;

class CustomHashMap
{
    const int SIZE = 10;             // Size of the hash map
    // ? -> so that it can also have null values, null represents no value
    static int?[] keys = new int?[SIZE];    // Stores keys
    static int?[] values = new int?[SIZE];  // Stores corresponding values

    // Simple hash function
    static int Hash(int key)
    {
        return key % SIZE;
    }

    // Insert or update a key-value pair
    static void Insert(int key, int value)
    {
        int index = Hash(key);
        int startIndex = index;
        
        // finding next slot
        while (keys[index] != null && keys[index] != key)
        {
            index = (index + 1) % SIZE;
            if (index == startIndex)
            {
                Console.WriteLine("HashMap is full!");
                return;
            }
        }

        keys[index] = key;
        values[index] = value;
    }

    // Get value by key
    static int? Get(int key)
    {
        int index = Hash(key);
        int startIndex = index;

        while (keys[index] != null)
        {
            if (keys[index] == key)
                return values[index];

            index = (index + 1) % SIZE;
            if (index == startIndex)
                break;
        }

        return null;
    }

    // Remove a key-value pair
    static void Remove(int key)
    {
        int index = Hash(key);
        int startIndex = index;

        while (keys[index] != null)
        {
            if (keys[index] == key)
            {
                keys[index] = null;
                values[index] = null;
                return;
            }

            index = (index + 1) % SIZE;
            if (index == startIndex)
                break;
        }
    }

    static void Main()
    {
        // Testing the custom hash map
        Insert(1, 100);
        Insert(2, 200);
        Insert(11, 300); // Collision with key 1 (linear probing)

        Console.WriteLine("Get key 1: " + Get(1));   // 100
        Console.WriteLine("Get key 11: " + Get(11)); // 300

        Remove(1);
        Console.WriteLine("Get key 1 after remove: " + Get(1)); // null

        Insert(21, 400); // Another collision
        Console.WriteLine("Get key 21: " + Get(21)); // 400
    }
}
