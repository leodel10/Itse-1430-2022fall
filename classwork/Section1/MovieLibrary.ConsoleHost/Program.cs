//Movie Definition 
string title = "";
string description = "";


int runLegnth = 0;
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

AddMovie();

bool ReadBoolean ( string message )
{
    Console.Write(message);

    //looking for Y/N
    ConsoleKeyInfo key = Console.ReadKey();
    if (key.Key == ConsoleKey.Y)
        return true;
    else if (key.Key == ConsoleKey.N)
        return false;

        //TODO eror
        return false;
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