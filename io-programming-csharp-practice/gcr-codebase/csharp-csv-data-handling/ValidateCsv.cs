using System;
using System.IO;
using System.Text.RegularExpressions;

class User
{
    private int id;
    private string name;
    private string email;
    private string phone;

    // Constructor
    public User(int id, string name, string email, string phone)
    {
        this.id = id;
        this.name = name;
        this.email = email;
        this.phone = phone;
    }

    public bool IsEmailValid()
    {
        string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
        return Regex.IsMatch(email, emailPattern);
    }

    public bool IsPhoneValid()
    {
        string phonePattern = @"^\d{10}$";
        return Regex.IsMatch(phone, phonePattern);
    }

    public void PrintErrors()
    {
        Console.WriteLine("Invalid Record:");
        Console.WriteLine("ID    : " + id);
        Console.WriteLine("Name  : " + name);
        Console.WriteLine("Email : " + email);
        Console.WriteLine("Phone : " + phone);

        if (!IsEmailValid())
        {
            Console.WriteLine("❌ Error: Invalid Email Format");
        }

        if (!IsPhoneValid())
        {
            Console.WriteLine("❌ Error: Phone number must contain exactly 10 digits");
        }

        Console.WriteLine("--------------------------------");
    }
}

class CSVValidator
{
    private string filePath;

    // Constructor
    public CSVValidator(string filePath)
    {
        this.filePath = filePath;
    }

    public void ValidateData()
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++) // skip header
            {
                string[] data = lines[i].Split(',');

                int id = Convert.ToInt32(data[0]);
                string name = data[1];
                string email = data[2];
                string phone = data[3];

                User user = new User(id, name, email, phone);

                if (!user.IsEmailValid() || !user.IsPhoneValid())
                {
                    user.PrintErrors();
                }
            }
        }
        catch (IOException)
        {
            Console.WriteLine("Error reading CSV file.");
        }
    }
}

class ValidateCsv
{
    static void Main()
    {
        CSVValidator validator = new CSVValidator("users.csv");
        validator.ValidateData();
    }
}
