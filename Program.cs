string userChoice = "";
int runningInt = 1;
do
{ 
    string userName;
    Console.WriteLine("1) Example of Integer\n2) Example of Float\n3) Example of String\n4) Example of Boolean\nQ) Quit");
    Console.Write("Please Make A Selection: ");
    userChoice = Console.ReadLine().Trim().ToUpper();
    switch (userChoice)
    {
        case "1":
            // Ref must have a value when the function is called.
            DisplayInteger(ref runningInt);
            break;
        case "2":
            DisplayFloat();
            break;
        case "3":
            // Out should typically not have a value when the function is called (if it did, why not use ref?).
            DisplayString(out userName);
            break;
        case "4":
            DisplayBoolean();
            break;
        case "Q":
            break;
        default:
            Console.WriteLine("Please try again, that was not a valid input.");
            break;
    }
} while (userChoice != "Q");
 
void DisplayInteger(ref int toDisplay)
{
    Console.WriteLine("Here is an integer: " + toDisplay + ". It is " + (toDisplay % 2 == 0 ? "even." : "odd."));
    toDisplay++;
}
void DisplayFloat()
{
    Console.WriteLine("Here is a float: " + 3.14f + ".");
}
void DisplayString(out string userName)
{
    Console.Write("Please enter your name: ");
    userName = Console.ReadLine().Trim();
    Console.WriteLine("Here is a string: \"Hello, " + userName + "\".");
}
void DisplayBoolean()
{
    Console.WriteLine("You only have two possble values for booleans: "+true+" / "+false+".");
}