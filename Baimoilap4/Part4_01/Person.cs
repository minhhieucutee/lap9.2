using System;

class Person
{
    public string Name { get; set; }
    public string PhoneNumber { get; set; }
    public string Email { get; set; }

    public override string ToString()
    {
        return $"{GetType().Name} - Name: {Name}, Email: {Email}";
    }
}