using System;
using System.Reflection;

// --------------------- MaxLength Attribute ---------------------
[AttributeUsage(AttributeTargets.Field)]
public class MaxLengthAttribute : Attribute
{
    public int Value { get; set; }

    public MaxLengthAttribute(int value)
    {
        Value = value;
    }
}

// --------------------- User Class ---------------------
public class User
{
    [MaxLength(10)]
    private string Username;

    public User(string username)
    {
        ValidateMaxLength(username);
        Username = username;
    }

    private void ValidateMaxLength(string value)
    {
        FieldInfo field =
            this.GetType().GetField("Username",
                BindingFlags.NonPublic | BindingFlags.Instance);

        object[] attributes =
            field.GetCustomAttributes(typeof(MaxLengthAttribute), false);

        if (attributes.Length > 0)
        {
            MaxLengthAttribute maxLength =
                (MaxLengthAttribute)attributes[0];

            if (value.Length > maxLength.Value)
            {
                throw new ArgumentException(
                    "Username exceeds maximum length of " + maxLength.Value);
            }
        }
    }
}

// --------------------- Test Program ---------------------
public class MaxLengthAttribute
{
    public static void Main()
    {
        try
        {
            User user1 = new User("Sakshi");   // Valid
            Console.WriteLine("User1 created successfully");

            User user2 = new User("VeryLongUsername"); // Invalid
            Console.WriteLine("User2 created successfully");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
