using System;

class EmployeeUtilityImpl : IEmployee
{
    public Employee AddEmployee(Employee employee)
    {
        return employee;
    }

    public void CheckAttendance(Employee employee)
    {
        Random random = new Random();
        int attendance = random.Next(0, 2);

        if (attendance == 1)
        {
            employee.IsPresent = true;
        }
        else
        {
            employee.IsPresent = false;
        }
    }
}
