using System;

class Program
{
    static void Main(string[] args)
    {
        // ── WHILE LOOP SECTION ──────────────────────────────────────────────────

        // Declare a counter variable to track how many times the loop has run
        int counter = 1;

        // While loop: keeps running as long as the boolean condition (counter <= 5) is true
        // Once counter exceeds 5, the condition becomes false and the loop stops
        while (counter <= 5)
        {
            // Print the current counter value to the console
            Console.WriteLine("While loop - Count: " + counter);

            // Increment the counter by 1 each time the loop runs
            // This prevents the loop from running forever (infinite loop)
            counter++;
        }

        // Print a blank line to separate the two loop sections visually
        Console.WriteLine();


        // ── DO WHILE LOOP SECTION ───────────────────────────────────────────────

        // Declare a second counter variable for the do-while loop
        int doCounter = 1;

        // Do-while loop: always runs the code block at least once BEFORE checking the condition
        // This is the key difference from a regular while loop
        do
        {
            // Print the current doCounter value to the console
            Console.WriteLine("Do-While loop - Count: " + doCounter);

            // Increment the doCounter by 1 each time the loop runs
            doCounter++;

        }
        // The boolean condition is checked HERE, after the code block runs
        // The loop continues as long as doCounter <= 5 is true
        while (doCounter <= 5);


        // ── END OF PROGRAM ──────────────────────────────────────────────────────

        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}