
using System;

class Staff : Employee
{
    public string Title { get; set; }

    public override double CalculateBonus()
    {
        return 0.06 * Salary;
    }

    public override int CalculateVacation()
    {
        int yearsOfService = DateTime.Now.Year - DateHired.Year;
        return yearsOfService >= 5 ? 4 : 3;
    }
}