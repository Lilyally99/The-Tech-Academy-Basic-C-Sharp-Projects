using System;

class Program
{
    static void Main(string[] args)
    {
        // ── ASK THE USER FOR A NUMBER ────────────────────────────────────────────

        // Ask the user to enter a number to perform math operations on
        Console.WriteLine("=== Math Operations Program ===");
        Console.Write("Enter a number to perform math operations on: ");

        // Read the user's input and convert it from a string to an integer
        int userNumber = Convert.ToInt32(Console.ReadLine());


        // ── CREATE AN INSTANCE OF THE MATHOPERATIONS CLASS ───────────────────────

        // Instantiate (create a new object of) the MathOperations class
        // We need to do this before we can call any of its methods
        MathOperations math = new MathOperations();


        // ── CALL EACH METHOD AND DISPLAY THE RESULTS ─────────────────────────────

        // Call the DoubleIt method, passing the user's number as the argument
        // The method returns the doubled value which we store in the result variable
        int doubleResult = math.DoubleIt(userNumber);

        // Display the result of the DoubleIt method to the screen
        Console.WriteLine("\n--- Results ---");
        Console.WriteLine("Double it:   " + userNumber + " x 2 = " + doubleResult);


        // Call the SquareIt method, passing the user's number as the argument
        // The method returns the squared value which we store in the result variable
        int squareResult = math.SquareIt(userNumber);

        // Display the result of the SquareIt method to the screen
        Console.WriteLine("Square it:   " + userNumber + " x " + userNumber + " = " + squareResult);


        // Call the AddTen method, passing the user's number as the argument
        // The method returns the value with 10 added, stored in the result variable
        int addTenResult = math.AddTen(userNumber);

        // Display the result of the AddTen method to the screen
        Console.WriteLine("Add ten:     " + userNumber + " + 10 = " + addTenResult);


        // ── END OF PROGRAM ───────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}