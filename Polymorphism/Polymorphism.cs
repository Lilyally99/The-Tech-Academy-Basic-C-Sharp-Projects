using System;

// ── ABSTRACT PERSON CLASS (BASE/PARENT CLASS) ────────────────────────────────
// The "abstract" keyword means this class CANNOT be instantiated directly
abstract class Person
{
    // Property to store the person's first name (string data type)
    public string FirstName { get; set; }

    // Property to store the person's last name (string data type)
    public string LastName { get; set; }

    // Abstract method — must be implemented by any class that inherits Person
    public abstract void SayName();
}


// ── INTERFACE: IQUITTABLE ─────────────────────────────────────────────────────
// An interface defines a CONTRACT — a list of methods that any class
// implementing this interface MUST provide an implementation for
// Interfaces contain no actual code, only method signatures (declarations)
interface IQuittable
{
    // Method declaration only — no implementation here
    // Any class that implements IQuittable must write its own Quit() method
    void Quit();
}


// ── EMPLOYEE CLASS (INHERITS PERSON, IMPLEMENTS IQUITTABLE) ──────────────────
// Employee inherits from the abstract Person class (using ":")
// Employee ALSO implements the IQuittable interface (separated by a comma)
// A class can inherit from only ONE class, but can implement MULTIPLE interfaces
class Employee : Person, IQuittable
{
    // ── IMPLEMENTING THE ABSTRACT METHOD FROM PERSON ──────────────────────
    public override void SayName()
    {
        // Combine FirstName and LastName into a full name and print it
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }

    // ── IMPLEMENTING THE QUIT METHOD FROM IQUITTABLE ──────────────────────
    // Because Employee implements IQuittable, it MUST provide this method
    // Note: interface methods do not use the "override" keyword like abstract methods do
    public void Quit()
    {
        // Print a resignation message including the employee's name
        Console.WriteLine(FirstName + " " + LastName + " has decided to quit their job.");
    }
}


// ── PROGRAM CLASS ─────────────────────────────────────────────────────────────
class Program
{
    static void Main(string[] args)
    {
        // ── INSTANTIATE AND INITIALIZE AN EMPLOYEE OBJECT ────────────────────
        Employee emp = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // Call the inherited SayName() method
        emp.SayName();

        // ── POLYMORPHISM: CREATE AN OBJECT OF TYPE IQUITTABLE ────────────────
        // This is polymorphism in action — we are declaring a variable
        // of the INTERFACE type (IQuittable) but assigning it an Employee object
        // This works because Employee implements the IQuittable interface
        // The variable "quittableEmployee" can only "see" the members of
        // IQuittable (in this case, just the Quit() method) — even though
        // the actual object underneath is a full Employee
        IQuittable quittableEmployee = emp;

        // Call the Quit() method through the IQuittable interface reference
        // Even though we are calling it through the interface type,
        // it still runs Employee's actual implementation of Quit()
        quittableEmployee.Quit();

        // ── END OF PROGRAM ────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}