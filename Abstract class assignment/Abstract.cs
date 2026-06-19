using System;

// ── ABSTRACT PERSON CLASS (BASE/PARENT CLASS) ────────────────────────────────
// The "abstract" keyword means this class CANNOT be instantiated directly
// You cannot write "new Person()" — it only exists to be inherited from
// Abstract classes are used as a blueprint that other classes must build upon
abstract class Person
{
    // Property to store the person's first name (string data type)
    public string FirstName { get; set; }

    // Property to store the person's last name (string data type)
    public string LastName { get; set; }

    // ── ABSTRACT METHOD: SAYNAME ──────────────────────────────────────────
    // This method has NO body/implementation here — just a declaration
    // The "abstract" keyword means any class that inherits from Person
    // is REQUIRED to provide its own implementation of this method
    public abstract void SayName();
}


// ── EMPLOYEE CLASS (DERIVED/CHILD CLASS) ─────────────────────────────────────
// The ": Person" part means Employee INHERITS from the abstract Person class
// Because Person's SayName() is abstract, Employee MUST implement it below
// or the code will not compile
class Employee : Person
{
    // ── IMPLEMENTING THE ABSTRACT METHOD ──────────────────────────────────
    // The "override" keyword is used to provide the actual implementation
    // of the abstract SayName() method that was declared in Person
    public override void SayName()
    {
        // Combine FirstName and LastName into a full name and print it
        // FirstName and LastName are inherited from the Person class
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}


// ── PROGRAM CLASS ─────────────────────────────────────────────────────────────
class Program
{
    static void Main(string[] args)
    {
        // ── INSTANTIATE AND INITIALIZE AN EMPLOYEE OBJECT ────────────────────
        // We CANNOT do "new Person()" because Person is abstract
        // But we CAN do "new Employee()" because Employee is a concrete class
        // that has fully implemented the abstract SayName() method
        Employee emp = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // ── CALL THE IMPLEMENTED METHOD ───────────────────────────────────────
        // This calls the SayName() method that Employee implemented
        // (the override version, not the abstract declaration from Person)
        emp.SayName();

        // ── END OF PROGRAM ────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}