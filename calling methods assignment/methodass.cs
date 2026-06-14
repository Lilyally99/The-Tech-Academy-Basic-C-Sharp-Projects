using System;

class Program
{
    static void Main(string[] args)
    {
        // ── INSTANTIATE THE CALCULATOR CLASS ────────────────────────────────────

        // Create a new instance of the Calculator class so we can call its methods
        Calculator calc = new Calculator();


        // ── ASK USER FOR FIRST NUMBER ────────────────────────────────────────────

        // Ask the user to enter the first number (this one is required)
        Console.WriteLine("=== Optional Parameter Calculator ===");
        Console.Write("Enter the first number: ");

        // Read and convert the user's input to an integer
        int firstNumber = Convert.ToInt32(Console.ReadLine());


        // ── ASK USER FOR SECOND NUMBER (OPTIONAL) ───────────────────────────────

        // Inform the user that the second number is optional
        // If they press Enter without typing anything, we will use the default value
        Console.Write("Enter the second number (or press Enter to skip — default is 10): ");

        // Read the second input as a string first so we can check if it is empty
        string secondInput = Console.ReadLine();


        // ── CALL THE METHOD WITH ONE OR TWO NUMBERS ─────────────────────────────

        // Declare a variable to hold the result of the method call
        int result;

        // Check if the user left the second input blank (pressed Enter without typing)
        if (string.IsNullOrWhiteSpace(secondInput))
        {
            // The user did not enter a second number
            // Call the method with only the first number
            // The optional parameter will use its default value of 10
            result = calc.Multiply(firstNumber);

            // Inform the user that the default value was used
            Console.WriteLine("\nNo second number entered — using default value of 10.");
            Console.WriteLine(firstNumber + " x 10 (default) = " + result);
        }
        else
        {
            // The user did enter a second number
            // Convert the second input string to an integer
            int secondNumber = Convert.ToInt32(secondInput);

            // Call the method passing both numbers as arguments
            // The optional parameter is overridden by the user's second number
            result = calc.Multiply(firstNumber, secondNumber);

            // Display the result of the calculation to the screen
            Console.WriteLine("\n" + firstNumber + " x " + secondNumber + " = " + result);
        }


        // ── END OF PROGRAM ───────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}