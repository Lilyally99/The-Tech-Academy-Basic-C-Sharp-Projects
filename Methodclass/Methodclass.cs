using System;

class Program
{
    static void Main(string[] args)
    {
        // ── INSTANTIATE THE MATHDISPLAY CLASS ───────────────────────────────────

        // Create a new instance of the MathDisplay class
        // We must instantiate it before we can call any of its methods
        MathDisplay math = new MathDisplay();


        // ── CALL THE METHOD BY PASSING IN TWO NUMBERS ───────────────────────────

        // Call the SquareAndDisplay method the standard way
        // The first argument (5) maps to firstNumber
        // The second argument (8) maps to secondNumber
        Console.WriteLine("--- Call 1: Standard method call ---");
        math.SquareAndDisplay(5, 8);


        // Print a blank line to visually separate the two method calls
        Console.WriteLine();


        // ── CALL THE METHOD USING NAMED PARAMETERS ───────────────────────────────

        // Call the same method again but this time specifying parameters BY NAME
        // Named parameters let you explicitly state which argument maps to which parameter
        // This makes the code easier to read and understand for other developers
        // The order of named parameters does not matter — you could even swap them around
        Console.WriteLine("--- Call 2: Named parameter method call ---");
        math.SquareAndDisplay(firstNumber: 12, secondNumber: 99);


        // ── END OF PROGRAM ───────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}