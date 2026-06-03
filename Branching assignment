using System;

class Program
{
    static void Main(string[] args)
    {
        // ── Welcome Message ───────────────────────────────────────
        // Print the opening line of the program
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
        Console.WriteLine();

        // ── Package Weight ────────────────────────────────────────
        // Ask for and store the package weight as a double
        // (using double to allow decimal values e.g. 49.5 lbs)
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight exceeds the 50 limit
        // If it does, display the error message and end the program
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Ends the program immediately
        }

        // ── Package Width ─────────────────────────────────────────
        // Ask for and store the package width as a double
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // ── Package Height ────────────────────────────────────────
        // Ask for and store the package height as a double
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // ── Package Length ────────────────────────────────────────
        // Ask for and store the package length as a double
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // ── Dimension Check ───────────────────────────────────────
        // Add all three dimensions together
        double totalDimensions = width + height + length;

        // If the total dimensions exceed 50, display error and end the program
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Ends the program immediately
        }

        // ── Calculate Shipping Quote ──────────────────────────────
        // Multiply width x height x length, then multiply by weight, then divide by 100
        double quote = (width * height * length) * weight / 100;

        // ── Display Result ────────────────────────────────────────
        // Print the quote formatted as a dollar amount with 2 decimal places
        // The "C2" format automatically adds the $ sign and rounds to 2 decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: {quote:C2}");
        Console.WriteLine("Thank you!");
    }
}