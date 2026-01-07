public interface IEmployee
{
    Employee AddEmployee(Employee employee);
    void CheckAttendance(Employee employee); //UC-1
    void CalculateDailyWage(Employee employee); //UC-2
    void CalculatePartTimeWage(Employee employee);  // UC-3
    void CalculateMonthlyWage(Employee employee);  // UC-5
    void CalculateWageTillCondition(Employee employee);  // UC-6
}
