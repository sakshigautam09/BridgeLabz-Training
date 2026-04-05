using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

class Student
{
    public string Name;
    public int Age;
    public string[] Subjects;
}

class Car
{
    public string Brand;
    public int Year;
}

class Program
{
    static void Main(string[] args)
    {
        // 1️) Create Student JSON (user input)
        Student student = new Student();

        Console.Write("Enter student name: ");
        student.Name = Console.ReadLine();

        Console.Write("Enter student age: ");
        student.Age = int.Parse(Console.ReadLine());

        Console.Write("Enter number of subjects: ");
        int subjectCount = int.Parse(Console.ReadLine());

        student.Subjects = new string[subjectCount];
        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write("Enter subject " + (i + 1) + ": ");
            student.Subjects[i] = Console.ReadLine();
        }

        string studentJson = JsonConvert.SerializeObject(student, Formatting.Indented);
        Console.WriteLine("\n1️⃣ Student JSON:");
        Console.WriteLine(studentJson);

        // 2) Convert Car object to JSON (user input)
        Car car = new Car();

        Console.Write("\nEnter car brand: ");
        car.Brand = Console.ReadLine();

        Console.Write("Enter car year: ");
        car.Year = int.Parse(Console.ReadLine());

        Console.WriteLine("\n Car JSON:");
        Console.WriteLine(JsonConvert.SerializeObject(car, Formatting.Indented));

        // 3) Read JSON file & extract specific fields
        string fileData = File.ReadAllText("user.json");
        JObject userObj = JObject.Parse(fileData);

        Console.WriteLine("\nExtracted Fields from file:");
        Console.WriteLine("Name: " + userObj["name"]);
        Console.WriteLine("Email: " + userObj["email"]);

        // 4) Merge JSON objects (file + car)
        JObject carObj = JObject.FromObject(car);
        userObj.Merge(carObj);

        Console.WriteLine("\n Merged JSON:");
        Console.WriteLine(userObj.ToString());

        // 5) Validate JSON using Schema (from file)
        string schemaText = File.ReadAllText("schema.json");
        JSchema schema = JSchema.Parse(schemaText);

        bool valid = userObj.IsValid(schema);
        Console.WriteLine("\n Schema Validation Result:");
        Console.WriteLine(valid);

        // 6) Convert List of Cars to JSON Array (user input)
        Console.Write("\nHow many cars do you want to add: ");
        int carCount = int.Parse(Console.ReadLine());

        List<Car> carList = new List<Car>();

        for (int i = 0; i < carCount; i++)
        {
            Car c = new Car();

            Console.Write("Enter car brand: ");
            c.Brand = Console.ReadLine();

            Console.Write("Enter car year: ");
            c.Year = int.Parse(Console.ReadLine());

            carList.Add(c);
        }

        Console.WriteLine("\n Car List JSON Array:");
        Console.WriteLine(JsonConvert.SerializeObject(carList, Formatting.Indented));

        // 7) Filter age > user input
        Console.Write("\nEnter minimum age to filter: ");
        int minAge = int.Parse(Console.ReadLine());

        int ageFromFile = (int)userObj["age"];

        Console.WriteLine("\nFilter Result:");
        if (ageFromFile > minAge)
        {
            Console.WriteLine("User passed age filter");
            Console.WriteLine(userObj.ToString());
        }
        else
        {
            Console.WriteLine("User did NOT pass age filter");
        }

        Console.ReadLine();
    }
}
