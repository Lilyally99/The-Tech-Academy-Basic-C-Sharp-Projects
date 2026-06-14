using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // ── PART 1: STRING ARRAY ────────────────────────────────────────────────

        // Create a one-dimensional array of strings with 5 elements
        string[] fruits = { "Apple", "Banana", "Cherry", "Mango", "Strawberry" };

        // Display the available indices to the user so they know what to choose
        Console.WriteLine("=== String Array ===");
        Console.WriteLine("Available indices: 0 to " + (fruits.Length - 1));

        // Ask the user to enter an index number
        Console.Write("Enter an index to see the fruit at that position: ");

        // Read the user's input and convert it to an integer
        int stringIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index the user entered is within the valid range of the array
        if (stringIndex >= 0 && stringIndex < fruits.Length)
        {
            // If valid, display the string at the chosen index
            Console.WriteLine("The fruit at index " + stringIndex + " is: " + fruits[stringIndex]);
        }
        else
        {
            // If the index does not exist, display an error message to the user
            Console.WriteLine("Sorry, that index does not exist in the string array.");
        }

        // Print a blank line to separate sections visually
        Console.WriteLine();


        // ── PART 2: INTEGER ARRAY ───────────────────────────────────────────────

        // Create a one-dimensional array of integers with 5 elements
        int[] numbers = { 10, 25, 37, 42, 58 };

        // Display the available indices to the user so they know what to choose
        Console.WriteLine("=== Integer Array ===");
        Console.WriteLine("Available indices: 0 to " + (numbers.Length - 1));

        // Ask the user to enter an index number
        Console.Write("Enter an index to see the number at that position: ");

        // Read the user's input and convert it to an integer
        int intIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index the user entered is within the valid range of the array
        if (intIndex >= 0 && intIndex < numbers.Length)
        {
            // If valid, display the integer at the chosen index
            Console.WriteLine("The number at index " + intIndex + " is: " + numbers[intIndex]);
        }
        else
        {
            // If the index does not exist, display an error message to the user
            Console.WriteLine("Sorry, that index does not exist in the integer array.");
        }

        // Print a blank line to separate sections visually
        Console.WriteLine();


        // ── PART 3: LIST OF STRINGS ─────────────────────────────────────────────

        // Create a List of strings (Lists are more flexible than arrays — they can grow and shrink)
        List<string> colors = new List<string> { "Red", "Blue", "Green", "Yellow", "Purple" };

        // Display the available indices to the user so they know what to choose
        Console.WriteLine("=== List of Strings ===");
        Console.WriteLine("Available indices: 0 to " + (colors.Count - 1));

        // Ask the user to enter an index number
        Console.Write("Enter an index to see the color at that position: ");

        // Read the user's input and convert it to an integer
        int listIndex = Convert.ToInt32(Console.ReadLine());

        // Check if the index the user entered is within the valid range of the list
        // Note: Lists use .Count instead of .Length to get the number of elements
        if (listIndex >= 0 && listIndex < colors.Count)
        {
            // If valid, display the string at the chosen index
            Console.WriteLine("The color at index " + listIndex + " is: " + colors[listIndex]);
        }
        else
        {
            // If the index does not exist, display an error message to the user
            Console.WriteLine("Sorry, that index does not exist in the list.");
        }


        // ── END OF PROGRAM ──────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}