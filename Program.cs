// Welcome to C#!

// In order to write something to the console, we use Console.WriteLine().
// This is very similar to output() in the web console, or console.log() in the debug console.
Console.WriteLine("Hello, World!");

// In order to read something from the console, we use Console.ReadLine().
// Typically, the ReadLine() would be assigned to a variable to store the result, but it can also be used for "Press enter to continue..." prompts.
Console.WriteLine("Press enter to continue...");
Console.ReadLine();

// A lot of the syntax for C# is idenitcal to JavaScript. This includes comments, delimiters (semicolons for statements and braces for code blocks), and general operators.

// Two main differences are that C# is strongly typed while JavaScript is weakly typed, and C# is compiled while JavaScript is interpreted.

int myInt = 0; // NOT let or var.

// Compiled means that C# converts the entire program to machine language ahead of time, while JavaScript reads each line one by one.
// Typically this will mean that syntax errors, etc will be caught before the program even runs, meaning unhandled exceptions will be less common in that scenario.

string userName;

Console.Write("Please enter your name: ");
userName = Console.ReadLine();
Console.WriteLine("Hello, " + userName + "!");

Console.Write("Please enter a number between 1 and 10: ");

// Since converting a user input to an integer is "dangerous", we put it in a try so that we can catch any exceptions.
try
{
    myInt = int.Parse(Console.ReadLine());
    // This method also works to convert.
    Convert.ToInt32("1");
    if (myInt < 1 || myInt > 10)
    {
        Console.WriteLine("You're not great at these instructions...");
    }
    else
    {
        for (int i = 1; i <= myInt; i++)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
}
catch (Exception e)
{
    Console.WriteLine("ERROR: " + e.Message);
}

// Since validation takes space, we can move the validation into a dedicated function to keep our main program concise. 
GetIntSafe("Please enter any valid number: ");

// Ternary operators are essentially an if/else in one line (condition ? valIfTrue : valIfFalse):
Console.WriteLine("Your number is: " + (myInt % 2 == 1 ? "Odd" : "Even"));


// Docstrings allow other developers to see what a function does at a glance.

int GetIntSafe(string prompt)
// Safely returns an int input from the user, based on the prompt. No formatting is done to the prompt, it is expected to be ready to go.
{
    int output = 0;
    bool valid = false;
    while (!valid)
    {
        Console.Write(prompt);
        try
        {
            output = int.Parse(Console.ReadLine());
            valid = true;
        }
        catch (Exception e)
        {
            Console.WriteLine("ERROR: " + e.Message);
            Console.WriteLine("Please try again.");
        }
    }
    return output;
}



int var1 = 10, var2 = 5, var3=0;
Console.WriteLine("Var1: " + var1 + " Var2: " + var2 + " Var3: " + var3);
ExampleFunction(var1, ref var2, out var3);
Console.WriteLine("Var1: " + var1 + " Var2: " + var2 + " Var3: " + var3);


void ExampleFunction(int number, ref int reference, out int output)
{
    number++;
    reference++;
    output = 1;
}