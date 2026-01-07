using System;

class Employee
{
    private int employeeId;
    private string employeeName;
    private bool isPresent;

    public int EmployeeId
    {
        get { return employeeId; }
        set { employeeId = value; }
    }

    public string EmployeeName
    {
        get { return employeeName; }
        set { employeeName = value; }
    }

    public bool IsPresent
    {
        get { return isPresent; }
        set { isPresent = value; }
    }

    public override string ToString()
    {
        string status = isPresent ? "Present" : "Absent";
        return "Employee Id: " + employeeId +
               " Name: " + employeeName +
               " Attendance: " + status;
    }
}
