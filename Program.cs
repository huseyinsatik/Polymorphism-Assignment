// Main program class that demonstrates polymorphism with IQuittable interface
class Program
{
    static void Main(string[] args)
    {
        // Create an Employee object
        Employee employee = new Employee("John", "Doe", 12345);

        // Using polymorphism: Creating an IQuittable object using the Employee instance
        IQuittable quittableEmployee = employee;

        // Call the Quit method through the interface reference
        quittableEmployee.Quit();

        // Keep console window open
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
} 