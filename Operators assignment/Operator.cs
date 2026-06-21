using System;

// ── EMPLOYEE CLASS ────────────────────────────────────────────────────────────
class Employee
{
    // Property to store the employee's ID number (int data type)
    public int Id { get; set; }

    // Property to store the employee's first name (string data type)
    public string FirstName { get; set; }

    // Property to store the employee's last name (string data type)
    public string LastName { get; set; }

    // ── OVERLOADING THE "==" OPERATOR ────────────────────────────────────────
    // This allows us to use "==" directly between two Employee objects
    // Normally "==" would just check if both variables point to the same
    // object in memory — overloading lets us define custom comparison logic
    // Here, two employees are considered EQUAL if their Id values match
    public static bool operator ==(Employee emp1, Employee emp2)
    {
        // Compare the Id property of both Employee objects
        // Return true if the IDs match, false otherwise
        return emp1.Id == emp2.Id;
    }

    // ── OVERLOADING THE "!=" OPERATOR ────────────────────────────────────────
    // C# REQUIRES that "==" and "!=" be overloaded together as a pair
    // This method simply returns the OPPOSITE of the "==" comparison above
    public static bool operator !=(Employee emp1, Employee emp2)
    {
        // The "!" negates the result of the "==" operator
        // If emp1 == emp2 is true, this returns false, and vice versa
        return !(emp1 == emp2);
    }

    // ── REQUIRED OVERRIDES ────────────────────────────────────────────────────
    // Whenever you overload == and !=, C# also expects you to override
    // Equals() and GetHashCode() to keep behavior consistent
    public override bool Equals(object obj)
    {
        // Check if obj is an Employee, then compare using our == operator
        if (obj is Employee otherEmployee)
        {
            return this == otherEmployee;
        }
        return false;
    }

    public override int GetHashCode()
    {
        // Generate a hash code based on the Id property
        return Id.GetHashCode();
    }
}


// ── PROGRAM CLASS ─────────────────────────────────────────────────────────────
class Program
{
    static void Main(string[] args)
    {
        // ── CREATE TWO EMPLOYEE OBJECTS ───────────────────────────────────────

        // Create the first Employee object and assign its property values
        Employee employee1 = new Employee
        {
            Id = 101,
            FirstName = "Sample",
            LastName = "Student"
        };

        // Create the second Employee object with a DIFFERENT Id
        Employee employee2 = new Employee
        {
            Id = 102,
            FirstName = "Jane",
            LastName = "Doe"
        };

        // ── COMPARE THE TWO EMPLOYEE OBJECTS USING == ────────────────────────

        // This calls our custom overloaded "==" operator
        // Since employee1.Id (101) does not equal employee2.Id (102), this is false
        Console.WriteLine("--- Comparing employee1 and employee2 ---");
        Console.WriteLine("employee1 == employee2: " + (employee1 == employee2));
        Console.WriteLine("employee1 != employee2: " + (employee1 != employee2));

        Console.WriteLine();

        // ── CREATE A THIRD EMPLOYEE WITH A MATCHING ID TO TEST EQUALITY ──────

        // Create a third Employee object with the SAME Id as employee1
        Employee employee3 = new Employee
        {
            Id = 101,
            FirstName = "Different",
            LastName = "Name"
        };

        // Even though FirstName and LastName are different, the Id values match
        // so our overloaded "==" operator will return true
        Console.WriteLine("--- Comparing employee1 and employee3 (same Id) ---");
        Console.WriteLine("employee1 == employee3: " + (employee1 == employee3));
        Console.WriteLine("employee1 != employee3: " + (employee1 != employee3));


        // ── END OF PROGRAM ────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}