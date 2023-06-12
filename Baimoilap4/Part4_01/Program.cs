using System;

class Program
{
    static void Main(string[] args)
    {
        var student = new Student
        {
            Name = "John Doe",
            Email = "johndoe@example.com",
            PhoneNumber = "555-555-5555",
            Program = "Computer Science"
        };
        Console.WriteLine(student);

        Console.WriteLine();

        var faculty = new Faculty
        {
            Name = "Jane Smith",
            Email = "janesmith@example.com",
            PhoneNumber = "555-555-1234",
            Department = "Mathematics",
            Salary = 80000,
            DateHired = new DateTime(2016, 9, 15),
            Rank = "Associate Professor",
            OfficeHours = "MWF 2-4"
        };
        Console.WriteLine(faculty);
        Console.WriteLine($"Bonus: {faculty.CalculateBonus():C}");
        Console.WriteLine($"Vacation weeks: {faculty.CalculateVacation()}");

        Console.WriteLine();

        var staff = new Staff
        {
            Name = "Bob Johnson",
            Email = "bobjohnson@example.com",
            PhoneNumber = "555-867-5309",
            Department = "Human Resources",
            Salary = 60000,
            DateHired = new DateTime(2017, 3, 12),
            Title = "HR Specialist"
        };
        Console.WriteLine(staff);
        Console.WriteLine($"Bonus: {staff.CalculateBonus():C}");
        Console.WriteLine($"Vacation weeks: {staff.CalculateVacation()}");
    }
}
