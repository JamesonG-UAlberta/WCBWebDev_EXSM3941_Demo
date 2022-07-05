using System.IO;

// Store the user's menu choice.
int userChoice;
const string FILE_NAME = "passwords.txt";
do
{
    // Display menu.
    Console.Write("1) Register User\n2) Login\n0) Exit\n\tPlease Choose: ");
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
            using (StreamWriter writer = File.AppendText(FILE_NAME))
            {
                Console.Write("Please enter your desired username: ");
                string newUserName = Console.ReadLine().Trim();
                Console.Write("Please enter your desired password: ");
                string newPassword = Console.ReadLine().Trim();

                // "TestUser", "password"
                // |
                // --> "TestUser|password"
                writer.WriteLine(newUserName + "|" + newPassword);
            }
            break;
        case 2:
            Console.Write("Please enter your username: ");
            string userName = Console.ReadLine().Trim();
            Console.Write("Please enter your password: ");
            string password = Console.ReadLine().Trim();
            bool success = false;

            // Open the existing file and set the cursor at the top (not sensitive to nonexistent files).
            using (StreamReader reader = File.OpenText(FILE_NAME)) { 
                // While we are not at the end of the file.
                string line;

                // This is the "best" solution as is stops iterating once we find what we're looking for. 
                while ((line = reader.ReadLine()) != null && !(success = (line.Split("|")[0] == userName && line.Split("|")[1] == password)));

                // This is easy-ish to read but does unnecessary processing:
                while ((line = reader.ReadLine()) != null)
                {
                    success = success || (line.Split("|")[0] == userName && line.Split("|")[1] == password);
                }

                // This is verbose but only does /some/ unnecessary processing:
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Split("|")[0] == userName && line.Split("|")[1] == password) success = true;
                    /*
                        {
                            success = true;
                        }
                     */
                }
            }

            // Magic of LINQ...
            string[] logins = File.ReadAllLines(FILE_NAME);
            Console.WriteLine(logins.Count(x => x.Split("|")[0] == userName && x.Split("|")[1] == password) == 1 ? "Success!" : "Incorrect password.");
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

