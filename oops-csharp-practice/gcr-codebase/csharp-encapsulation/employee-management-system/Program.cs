using System;

class Program
{
    static void Main()
    {
        Employee[] employees = new Employee[4];

        FullTimeEmployee emp1 = new FullTimeEmployee(101, "Alice", 50000);
        emp1.AssignDepartment("HR");

        FullTimeEmployee emp2 = new FullTimeEmployee(102, "Bob", 60000);
        emp2.AssignDepartment("Finance");

        PartTimeEmployee emp3 = new PartTimeEmployee(103, "Charlie", 500, 80);
        emp3.AssignDepartment("Support");

        PartTimeEmployee emp4 = new PartTimeEmployee(104, "Diana", 600, 60);
        emp4.AssignDepartment("Marketing");

        employees[0] = emp1;
        employees[1] = emp2;
        employees[2] = emp3;
        employees[3] = emp4;

        Console.WriteLine("=== Employee Details ===\n");

        for (int i = 0; i < employees.Length; i++)
        {
            employees[i].DisplayDetails();
            Console.WriteLine("Calculated Salary: " + employees[i].CalculateSalary());

            IDepartment dept = employees[i] as IDepartment;
            if (dept != null)
            {
                Console.WriteLine(dept.GetDepartmentDetails());
            }
        }
    }
}
