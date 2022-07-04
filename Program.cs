int userChoice;

do
{
    Console.Write("1) Add User\n2) Output Users\n3) Export Users\n4) Import Users\n0) Exit\n\tPlease Choose: ");
    try
    {
        userChoice = int.Parse(Console.ReadLine().Trim());
    }
    catch
    {
        userChoice = -1;
    }
    switch (userChoice)
    {
        case 1:
            break;
        case 2:
            break;
        case 3:
            break;
        case 4:
            break;
        case 0:
            break;
        default:
            Console.WriteLine("Please enter a valid input.");
            break;
    }
} while (userChoice != 0);