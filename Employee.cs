// Employee class that implements the IQuittable interface
public class Employee : IQuittable
{
    // Properties of the Employee class
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Id { get; set; }

    // Constructor to initialize Employee properties
    public Employee(string firstName, string lastName, int id)
    {
        FirstName = firstName;
        LastName = lastName;
        Id = id;
    }

    // Implementation of the Quit method from IQuittable interface
    public void Quit()
    {
        // Custom implementation of the Quit method
        Console.WriteLine($"Employee {FirstName} {LastName} (ID: {Id}) has quit their position.");
    }
} 