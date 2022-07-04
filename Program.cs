using System.IO;

// Store the user's menu choice.
int userChoice;
// Store the user names.
List<string> users = new List<string>();
do
{
    // Display menu.
    Console.Write("1) Add User\n2) Output Users\n3) Export Users\n4) Import Users\n0) Exit\n\tPlease Choose: ");
    try
    {
        // Read the user's choice.
        userChoice = int.Parse(Console.ReadLine().Trim());
    }
    catch
    {
        // If the int.Parse fails, then assign a value that will trip the default switch case.
        userChoice = -1;
    }
    // Clear the console to keep it clean.
    Console.Clear();
    // Decide what to do based on the user's choice.
    switch (userChoice)
    {
        case 1:
            // Read a name.
            Console.Write("Please enter the user's name: ");
            // Add the name to the list.
            users.Add(Console.ReadLine().Trim());
            break;
        case 2:
            // For each name in the list, output it to the console.
            foreach (string user in users) Console.WriteLine(user);
            break;
        case 3:
            // Get the file name.
            Console.Write("Please name your file: ");
            string fileNameOut =  Console.ReadLine().Trim();
            // Initialize the file and set the cursor at the top.
            using (StreamWriter writer = File.CreateText(fileNameOut + ".txt"))
            {
                // For each name in the list, write a line with that name to the file.
                foreach (string user in users) writer.WriteLine(user);
            }
            break;
        case 4:
            // Get the file name.
            Console.Write("Which file: ");
            string fileNameIn = Console.ReadLine().Trim();
            // Open the existing file and set the cursor at the top (not sensitive to nonexistent files).
            using (StreamReader reader = File.OpenText(fileNameIn + ".txt"))
            {
                // While we are not at the end of the file.
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    // Add each line to the list.
                    users.Add(line);
                }
            }
            break;
        case 0:
            // Exit.
            break;
        default:
            // Display an error if the menu choice is invalid.
            Console.WriteLine("Please enter a valid input.");
            break;
    }
    // Add a space of padding before re-showing the menu.
    Console.WriteLine();
// Exit on 0.
} while (userChoice != 0);

