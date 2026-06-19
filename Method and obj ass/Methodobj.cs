using System;

// ── PERSON CLASS (BASE/PARENT CLASS) ─────────────────────────────────────────
// This is the base class that Employee will inherit from
class Person
{
    // Property to store the person's first name (string data type)
    public string FirstName { get; set; }

    // Property to store the person's last name (string data type)
    public string LastName { get; set; }

    // ── VOID METHOD: SAYNAME ──────────────────────────────────────────────
    // This method takes no parameters and writes the full name to the console
    // void means it does not return any value
    public void SayName()
    {
        // Combine FirstName and LastName into a full name and print it
        // Format required: "Name: [full name]"
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}


// ── EMPLOYEE CLASS (DERIVED/CHILD CLASS) ─────────────────────────────────────
// The ": Person" part means Employee INHERITS from Person
// This means Employee automatically gets FirstName, LastName, and SayName()
// without having to rewrite them
class Employee : Person
{
    // Additional property specific to Employee only — not part of Person
    // Stores the employee's ID number (int data type)
    public int Id { get; set; }
}


// ── PROGRAM CLASS ─────────────────────────────────────────────────────────────
class Program
{
    static void Main(string[] args)
    {
        // ── INSTANTIATE AND INITIALIZE AN EMPLOYEE OBJECT ────────────────────
        // Create a new Employee object and set its properties using object initializer syntax
        // Even though FirstName and LastName belong to Person, Employee can use them
        // because Employee inherits from Person
        Employee emp = new Employee
        {
            FirstName = "Sample",
            LastName = "Student"
        };

        // ── CALL THE SUPERCLASS METHOD ────────────────────────────────────────
        // SayName() is defined in the Person class (the superclass)
        // Employee did not define its own SayName() method, so it uses
        // the inherited version directly from Person
        emp.SayName();

        // ── END OF PROGRAM ────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}