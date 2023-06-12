using System;

class Student : Person
{
    public string Program { get; set; }
}

abstract class Employee : Person
{
    public string Department { get; set; }
    public double Salary { get; set; }

    public DateTime DateHired { get; set; }

    public abstract double CalculateBonus();
    public abstract int CalculateVacation();
}
