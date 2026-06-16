using System;

// ── MATHHELPER CLASS ─────────────────────────────────────────────────────────
// A regular class that must be instantiated before its methods can be called
class MathHelper
{
    // ── PART 1: VOID METHOD THAT DIVIDES BY 2 ───────────────────────────────
    // This method takes one integer parameter and divides it by 2
    // void means it does not return a value — it just displays output to the screen
    public void DivideByTwo(int number)
    {
        // Divide the received number by 2
        int result = number / 2;

        // Display the result of the division to the screen
        Console.WriteLine("Void method result: " + number + " divided by 2 = " + result);
    }

    // ── PART 4: METHOD WITH OUTPUT PARAMETERS ───────────────────────────────
    // The 'out' keyword allows this method to pass a value BACK to the caller
    // through the parameter, even though the method return type is void
    public void DivideByTwoWithOutput(int number, out int result)
    {
        // Perform the division and assign it to the out parameter
        // The 'out' parameter must be assigned a value inside the method
        result = number / 2;
    }

    // ── PART 5: METHOD OVERLOADING ───────────────────────────────────────────
    // Overload 1: DivideByTwo that accepts a DOUBLE instead of an integer
    // This allows decimal results (e.g. 7.5 / 2 = 3.75)
    public void DivideByTwo(double number)
    {
        // Divide the double value by 2 and store the result
        double result = number / 2;

        // Display the result — this version shows decimal places
        Console.WriteLine("Overloaded method (double) result: " + number + " divided by 2 = " + result);
    }

    // Overload 2: DivideByTwo that accepts TWO integers
    // Divides the first number by 2, then adds the second number to the result
    public void DivideByTwo(int number, int bonus)
    {
        // Divide the first number by 2
        int result = number / 2;

        // Add the bonus to the result
        int finalResult = result + bonus;

        // Display the full calculation to the screen
        Console.WriteLine("Overloaded method (two ints) result: (" + number + " / 2) + " + bonus + " = " + finalResult);
    }
}


// ── PART 6: STATICHELPER CLASS (STATIC CLASS) ────────────────────────────────
// A static class CANNOT be instantiated with the 'new' keyword
// Its methods are called directly using the class name e.g. StaticHelper.Greet()
// Static classes are useful for utility/helper functions that don't need state
static class StaticHelper
{
    // This static method displays a simple greeting message
    // It does not require an instance of the class to be called
    public static void Greet()
    {
        // Print a message to show the static class method is working
        Console.WriteLine("Hello from the StaticHelper static class!");
    }
}


// ── PROGRAM CLASS ────────────────────────────────────────────────────────────
// This is the main entry point of the console application
class Program
{
    static void Main(string[] args)
    {
        // ── PART 2: INSTANTIATE THE MATHHELPER CLASS ─────────────────────────────
        // Create a new instance of MathHelper so we can call its methods
        // StaticHelper does NOT need to be instantiated — it is called directly
        MathHelper math = new MathHelper();

        // ── PART 3: ASK USER FOR A NUMBER AND CALL THE VOID METHOD ──────────────
        // Ask the user to enter a number to divide by two
        Console.WriteLine("=== Divide By Two Program ===");
        Console.Write("Enter a number to divide by two: ");

        // Read and convert the user's input to an integer
        int userNumber = Convert.ToInt32(Console.ReadLine());

        // Call the void DivideByTwo method, passing in the user's number
        // This method divides the number by 2 and displays the result
        Console.WriteLine();
        Console.WriteLine("--- Part 1 & 3: Void Method ---");
        math.DivideByTwo(userNumber);

        // ── PART 4: CALL THE METHOD WITH AN OUTPUT PARAMETER ────────────────────
        // Declare a variable to receive the value from the out parameter
        // The 'out' variable does not need to be initialized before passing it
        int outputResult;

        // Call the method with the out parameter
        // The method will assign the divided value to outputResult
        math.DivideByTwoWithOutput(userNumber, out outputResult);

        // Display the result received through the output parameter
        Console.WriteLine();
        Console.WriteLine("--- Part 4: Output Parameter Method ---");
        Console.WriteLine("Output parameter result: " + userNumber + " divided by 2 = " + outputResult);

        // ── PART 5: CALL THE OVERLOADED METHODS ─────────────────────────────────
        Console.WriteLine();
        Console.WriteLine("--- Part 5: Method Overloading ---");

        // Call the overloaded version that accepts a double
        // This shows a decimal result unlike the integer version
        math.DivideByTwo(7.5);

        // Call the overloaded version that takes two integers
        // Divides the first by 2 then adds the bonus
        math.DivideByTwo(20, 5);

        // ── PART 6: CALL THE STATIC CLASS METHOD ────────────────────────────────
        Console.WriteLine();
        Console.WriteLine("--- Part 6: Static Class ---");

        // Call the static method directly using the class name
        // No instance needed — static classes are called by name only
        StaticHelper.Greet();

        // ── END OF PROGRAM ───────────────────────────────────────────────────────
        // Pause the console so the output stays visible until the user presses Enter
        Console.ReadLine();
    }
}