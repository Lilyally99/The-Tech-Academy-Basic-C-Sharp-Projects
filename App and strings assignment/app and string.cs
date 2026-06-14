using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ── CREATE LIST OF INTEGERS ─────────────────────────────────────────────

        // Create a List of integers with 6 values to divide
        List<int> numbers = new List<int> { 100, 75, 50, 200, 36, 144 };

        // Display the list to the user so they know what values will be divided
        Console.WriteLine("Numbers in the list: " + string.Join(", ", numbers));


        // ── ASK USER FOR DIVISOR ────────────────────────────────────────────────

        // Ask the user to enter a number to divide each list item by
        Console.Write("Enter a number to divide each value by: ");

        // Read the user's input as a string first (before converting)
        // We read it as string here so we can catch format errors in the try/catch
        string userInput = Console.ReadLine();


        // ── TRY/CATCH BLOCK ─────────────────────────────────────────────────────

        // Wrap the loop in a try/catch block to handle any errors gracefully
        // A try block attempts to run code that might throw an exception
        // If an error occurs inside the try block, execution jumps to the catch block
        try
        {
            // Attempt to convert the user's string input to an integer
            // If the user typed a non-numeric string (e.g. "hello"), this line
            // will throw a FormatException and jump to the catch block below
            int divisor = Convert.ToInt32(userInput);

            // Loop through each integer in the list using a foreach loop
            foreach (int number in numbers)
            {
                // Divide the current list item by the user's divisor
                // If divisor is 0, this will throw a DivideByZeroException
                // and execution will jump to the catch block below
                int result = number / divisor;

                // Display the division calculation and its result to the screen
                Console.WriteLine(number + " ÷ " + divisor + " = " + result);
            }
        }
        catch (DivideByZeroException ex)
        {
            // This catch block runs if the user entered 0 as the divisor
            // DivideByZeroException is thrown when any number is divided by zero
            // ex.Message contains the built-in error description from C#
            Console.WriteLine("Error: Cannot divide by zero. Details: " + ex.Message);
        }
        catch (FormatException ex)
        {
            // This catch block runs if the user entered a non-numeric value (e.g. a string)
            // FormatException is thrown when Convert.ToInt32() receives invalid input
            Console.WriteLine("Error: Invalid input — please enter a number. Details: " + ex.Message);
        }
        catch (Exception ex)
        {
            // This is a general catch block that handles any other unexpected errors
            // It acts as a safety net for exceptions not covered by the blocks above
            Console.WriteLine("An unexpected error occurred: " + ex.Message);
        }


        // ── AFTER TRY/CATCH ─────────────────────────────────────────────────────

        // This line runs regardless of whether an error occurred or not
        // It proves that after the try/catch block, program execution continues normally
        // Even if an exception was caught, the program does not crash and reaches this line
        Console.WriteLine("\nThe program has emerged from the try/catch block and continued execution.");


        // ── END OF PROGRAM ──────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}