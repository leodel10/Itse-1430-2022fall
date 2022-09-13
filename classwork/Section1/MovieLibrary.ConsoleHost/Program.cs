//Movie Definition 
string title = "";
string description = "";

int runLegnth = 0;
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

DisplayInformation();

bool done = false;
do 
{

    MenuOption input = DisplayMenu();
    Console.WriteLine();
    switch (input)
    {
         
        case MenuOption.Add:
        {
            AddMovie();
            break;
        }
        case MenuOption.Edit: EditMovie(); break;
        case MenuOption.View: ViewMovie(); break;
        case MenuOption.Delete: DeleteMovie(); break;
        case MenuOption.Quit: done = true; break;


    };
    //if (input == 'A')
    //    AddMovie();
    //else if (input == 'E')
    //    EditMovie();
    //else if (input == 'V')
    //    ViewMovie();
    //else if (input == 'D')
    //    DeleteMovie();
    //else if (input == 'Q')
    //    break;
} while (!done);

/// Funtions 
/// 

void DisplayInformation ()
{
    Console.WriteLine("Movie Library");
    Console.WriteLine("ITSE sample");
    Console.WriteLine("Fall 2022");
}

MenuOption DisplayMenu()
{
    Console.WriteLine();
    Console.WriteLine("A)dd Movie");
    Console.WriteLine("E)dit movie");
    Console.WriteLine("V)iew Movie");
    Console.WriteLine("D)elete Movie");
    Console.WriteLine("Q)uit");

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.A: return MenuOption.Add;
            case ConsoleKey.E: return MenuOption.Edit;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.D: return MenuOption.Delete;
            case ConsoleKey.Q: return MenuOption.Quit;
        };
           
        //if (key.Key == ConsoleKey.A)
        //    return 'A';
        //else if (key.Key == ConsoleKey.E)
        //    return 'E';
        //else if (key.Key == ConsoleKey.V)
        //    return 'V';
        //else if (key.Key == ConsoleKey.D)
        //    return 'D';
        //else if (key.Key == ConsoleKey.Q)
        //    return 'Q';
    } while (true);

}

bool ReadBoolean ( string message )
{
    Console.Write(message);

    //looking for Y/N
    do { 
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Y)
            return true;
        else if (key.Key == ConsoleKey.N)
        return false;
    } while (true);
}

int ReadInt32 ( string message, int minimumValue, int maximumValue )
{
    Console.Write(message);

    do 
    {
        string value = Console.ReadLine();

        //inline declarations
        //int result;
        //if (Int32.TryParse(value, out result))
        if (Int32.TryParse(value, out int result))
        {
            if (result >= minimumValue && result <= maximumValue)
            return result;
        };

        //if (false)
            //break;      //exit loop
            //continue;     //Exit iteration and goes to next iteretion

        Console.WriteLine("Value must be between " + minimumValue + " and " + maximumValue);
     } while (true);
}

string ReadString ( string message, bool required )
{
    Console.Write(message);

    while (true)
    {
        string value = Console.ReadLine();

        //if value is not empty or not required 
        if (value != "" || !required)
            return value;

        //values is empty and required
        Console.WriteLine("Value is required");
    };
}

void AddMovie ( )
{
    ////string title = ""
    title = ReadString("Enter a title: ", true);

    //string description = "";
    description = ReadString("Enter an optional description: ", false);

    runLegnth = ReadInt32("Enter the run leghtn (in minutes): ",0, 300);

    releaseYear = ReadInt32("Enter the relase year: ", 1900, 2100);
    rating = ReadString("Enter the MPAA rating: ", true);

    isClassic = ReadBoolean("Is this a classic?: ");
}

void EditMovie ()
{ }

void DeleteMovie ()
{
    //no movie
    if (title == "")
        return;

    //not confirmed
    if (!ReadBoolean("are you sure you want to delete movie (Y/N)?"))
        return;

    //todo; delete movie 
    title = "";
   
}

void ViewMovie ()
{
    if (title == "")
    {
        Console.WriteLine("No movies available");
        return;
    };
    Console.WriteLine(title);
    Console.WriteLine(releaseYear);
    Console.WriteLine("Legnth: "+ runLegnth + "mins");
    Console.WriteLine("MPPA Rating: " + rating);
    Console.WriteLine("Classic: " + isClassic);
    Console.WriteLine(description);
}