using System;

class Program
{
    static void Main(string[] args)
    {
        // ── PART 1: CREATE STRING ARRAY ─────────────────────────────────────────

        // Create a one-dimensional array of strings with 5 elements
        string[] names = { "Alice", "Bob", "Charlie", "Diana", "Edward" };


        // ── PART 2: ASK USER FOR INPUT ──────────────────────────────────────────

        // Ask the user to type some text that will be added to each string
        Console.WriteLine("Enter some text to append to each name:");

        // Read and store the user's text input
        string userText = Console.ReadLine();


        // ── PART 3: FIRST LOOP — APPEND USER TEXT TO EACH ARRAY ELEMENT ────────

        // Loop through each index of the array
        // This loop updates each element silently — nothing is printed here
        for (int i = 0; i < names.Length; i++)
        {
            // Append the user's text to the end of the current array element
            // The updated value is stored back into the same index position
            names[i] = names[i] + userText;
        }


        // ── PART 4: SECOND LOOP — PRINT EACH UPDATED STRING ────────────────────

        // Print a header line so the output is clear to the user
        Console.WriteLine("\nHere are the updated names:");

        // Loop through the array again now that all elements have been updated
        for (int i = 0; i < names.Length; i++)
        {
            // Print each updated string to the console one at a time
            Console.WriteLine(names[i]);
        }
// ── PART 5: INFINITE LOOP (BROKEN VERSION — SAVED AS REQUIRED) ─────────
 
        // THE FOLLOWING LOOP WAS INTENTIONALLY WRITTEN AS AN INFINITE LOOP FIRST:
        // The loop below had no exit condition — it would run forever because
        // the counter variable (loopCount) was never being incremented,
        // so the condition (loopCount < 5) would always remain true.
        //
        // BROKEN VERSION (do not run — shown here for reference):
        // int loopCount = 0;
        // while (loopCount < 5)
        // {
        //     Console.WriteLine("This would loop forever: " + loopCount);
        //     // FIX NEEDED: loopCount was missing here, causing the infinite loop
        // }
 
 
        // ── PART 5 (FIXED): INFINITE LOOP CORRECTED ─────────────────────────────
 
        // FIX APPLIED: loopCount++ was added inside the loop body
        // This increments the counter by 1 on each iteration so that
        // the condition (loopCount < 5) eventually becomes false and the loop stops
        // Without this increment, the loop would never end (infinite loop)
 
        // Declare and initialize the counter variable to 0
        int loopCount = 0;
 
        // The while loop runs as long as loopCount is less than 5
        while (loopCount < 5)
        {
            // Print the current loop count to the console
            Console.WriteLine("Loop iteration: " + loopCount);
 
            // FIX: Increment loopCount by 1 each iteration
            // This is what was missing in the broken infinite loop version
            // Without this line, loopCount would stay 0 forever
            loopCount++;
        }
 
        // Confirm to the user that the loop has finished running
        Console.WriteLine("Loop complete — the infinite loop has been fixed!");
 
 
        
        // ── PART 6: LOOP USING "<" (LESS THAN) OPERATOR ────────────────────────
 
        // This loop uses the "<" operator to compare the counter to a limit
        // The loop runs while the counter is STRICTLY LESS THAN 5
        // This means it will execute for values 0, 1, 2, 3, 4 (5 iterations total)
        // The value 5 itself is NOT included because 5 is not less than 5
 
        // Declare and initialize the counter variable
        int countA = 0;
 
        Console.WriteLine("\n--- Loop using < operator ---");
 
        // Loop continues as long as countA is strictly less than 5
        while (countA < 5)
        {
            // Print the current value of countA to the console
            Console.WriteLine("< loop — countA is: " + countA);
 
            // Increment countA by 1 so the loop eventually ends
            countA++;
        }
 
        // Confirm the loop has finished and explain the last value printed
        Console.WriteLine("< loop finished. Last value printed was 4 (stopped before reaching 5).");
 
 
        // ── PART 7: LOOP USING "<=" (LESS THAN OR EQUAL TO) OPERATOR ───────────
 
        // This loop uses the "<=" operator to compare the counter to a limit
        // The loop runs while the counter is LESS THAN OR EQUAL TO 5
        // This means it will execute for values 0, 1, 2, 3, 4, 5 (6 iterations total)
        // Unlike the "<" loop above, the value 5 IS included because 5 equals 5
 
        // Declare and initialize a new counter variable
        int countB = 0;
 
        Console.WriteLine("\n--- Loop using <= operator ---");
 
        // Loop continues as long as countB is less than or equal to 5
        while (countB <= 5)
        {
            // Print the current value of countB to the console
            Console.WriteLine("<= loop — countB is: " + countB);
 
            // Increment countB by 1 so the loop eventually ends
            countB++;
        }
 
        // Confirm the loop has finished and explain the difference from the "<" loop
        Console.WriteLine("<= loop finished. Last value printed was 5 (5 was included because 5 <= 5 is true).");
 
        // ── PART 8: LIST SEARCH WITH UNIQUE ITEMS ───────────────────────────────
 
        // Create a List of strings where every item is unique (no duplicates)
        // Using a List instead of an array because Lists are more flexible
        List<string> cities = new List<string>
        {
            "Toronto",
            "Vancouver",
            "Calgary",
            "Ottawa",
            "Montreal",
            "Edmonton",
            "Winnipeg",
            "Halifax"
        };
 
        // Display the list to the user so they know what to search for
        Console.WriteLine("\n--- List Search ---");
        Console.WriteLine("Cities in the list: " + string.Join(", ", cities));
 
        // Ask the user to type the text they want to search for in the list
        Console.Write("Enter a city name to search for: ");
 
        // Read and store the user's search input
        string searchText = Console.ReadLine();
 
        // Declare a boolean variable to track whether a match was found
        // It starts as false — if a match is found it will be set to true
        bool matchFound = false;
 
        // Loop through each index of the list to search for the user's input
        for (int i = 0; i < cities.Count; i++)
        {
            // Check if the current list item matches the user's search text
            // Using OrdinalIgnoreCase so the search is not case-sensitive
            // e.g. "toronto" will still match "Toronto"
            if (cities[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
            {
                // A match was found — display the index to the user
                Console.WriteLine("Match found! \"" + cities[i] + "\" is at index " + i + " in the list.");
 
                // Set matchFound to true so we know a match was found
                matchFound = true;
 
                // STOP THE LOOP: break exits the loop immediately once a match is found
                // Without this, the loop would keep running through the rest of the list
                // unnecessarily even after a match has already been found
                break;
            }
        }
 
        // After the loop finishes, check if no match was ever found
        // If matchFound is still false, the user's input was not in the list
        if (!matchFound)
        {
            // Inform the user that their search text does not exist in the list
            Console.WriteLine("\"" + searchText + "\" is not on the list. Please try again.");
        }
 // ── PART 9: LIST WITH DUPLICATES — FIND ALL MATCHES ────────────────────
 
        // Create a List of strings that intentionally contains duplicate values
        // At least two items in the list are identical so multiple matches can be found
        List<string> animals = new List<string>
        {
            "Lion",
            "Tiger",
            "Elephant",
            "Tiger",    // duplicate — appears again at a different index
            "Giraffe",
            "Lion",     // duplicate — appears again at a different index
            "Zebra"
        };
 
        // Display the list to the user so they know what to search for
        Console.WriteLine("\n--- Duplicate List Search ---");
        Console.WriteLine("Animals in the list: " + string.Join(", ", animals));
 
        // Ask the user to type the text they want to search for in the list
        Console.Write("Enter an animal name to search for: ");
 
        // Read and store the user's search input
        string duplicateSearch = Console.ReadLine();
 
        // Declare a boolean to track whether at least one match was found
        // Starts as false — will be set to true if any match is found
        bool duplicateMatchFound = false;
 
        // Loop through every index in the list — NO break statement here
        // This ensures ALL matching indices are found, not just the first one
        for (int i = 0; i < animals.Count; i++)
        {
            // Check if the current list item matches the user's search text
            // Using OrdinalIgnoreCase so the search is not case-sensitive
            if (animals[i].Equals(duplicateSearch, StringComparison.OrdinalIgnoreCase))
            {
                // A match was found — display which index it was found at
                Console.WriteLine("Match found! \"" + animals[i] + "\" is at index " + i + " in the list.");
 
                // Set duplicateMatchFound to true to record that at least one match exists
                duplicateMatchFound = true;
 
                // NOTE: There is NO break statement here on purpose
                // Without break, the loop continues checking ALL remaining items
                // This allows every duplicate match to be found and displayed
            }
        }
 
        // After the loop completes, check if no match was ever found
        // If duplicateMatchFound is still false, the input was not in the list at all
        if (!duplicateMatchFound)
        {
            // Inform the user that their search text does not exist anywhere in the list
            Console.WriteLine("\"" + duplicateSearch + "\" is not on the list.");
        }

        // ── PART 10: FOREACH LOOP — DETECT DUPLICATES AS WE GO ─────────────────
 
        // Create a List of strings that contains at least two identical items
        // This list is used to demonstrate duplicate detection using a foreach loop
        List<string> colours = new List<string>
        {
            "Red",
            "Blue",
            "Green",
            "Blue",     // duplicate of index 1
            "Yellow",
            "Red",      // duplicate of index 0
            "Purple"
        };
 
        Console.WriteLine("\n--- Foreach Duplicate Detector ---");
 
        // Create a new empty List to keep track of items we have already seen
        // Each time we encounter an item, we will add it to this list
        // If we see an item that is already in this list, it is a duplicate
        List<string> seenItems = new List<string>();
 
        // Use a foreach loop to iterate through every item in the colours list
        // foreach automatically moves through each element one at a time
        foreach (string colour in colours)
        {
            // Check if the current item already exists in our seenItems list
            // Contains() returns true if the item has already been encountered
            if (seenItems.Contains(colour))
            {
                // The item already exists in seenItems — it is a duplicate
                Console.WriteLine(colour + " - this item is a duplicate");
            }
            else
            {
                // The item has not been seen before — it is unique so far
                Console.WriteLine(colour + " - this item is unique");
 
                // Add this item to seenItems so future duplicates can be detected
                // From this point on, if this item appears again it will be flagged
                seenItems.Add(colour);
            }
        }
 