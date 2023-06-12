
using System;

class Faculty : Employee
{
    public string Rank { get; set; }
    public string OfficeHours { get; set; }

    public override double CalculateBonus()
    {
        return 1000 + 0.05 * Salary;
    }

    public override int CalculateVacation()
    {

        int yearsOfService = DateTime.Now.Year - DateHired.Year;
        int vacationWeeks = yearsOfService >= 3 ? 5 : 4;

        if (Rank == "Senior Lecturer")
        {
            vacationWeeks++;
        }

        return vacationWeeks;
    }
}