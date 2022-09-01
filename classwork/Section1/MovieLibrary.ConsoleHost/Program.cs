//Movie Definition 
string title = "";
string description = "";
int runLegnth = 0;
int releaseYear = 1900;
string rating = "";
bool isClassic = false;

AddMovie();

int ReadInt32 ( string message )
{
    Console.Write(message);

    string value = Console.ReadLine();
    //inline declarations
    //int result;
    //if (Int32.TryParse(value, out result))
    if (Int32.TryParse(value, out int result)) ;
    return result;

    //TODO loop
    return -1;
}

string ReadString ( string message )
{
    Console.Write(message);
    string value = Console.ReadLine();

    return value;
}

void AddMovie ( )
{
    ////string title = ""
    title = ReadString("Enter a title: ");

    //string description = "";
    description = ReadString("Enter an optional description: ");

    runLegnth = ReadInt32("Enter the run leghtn (in minutes): ");

    releaseYear = ReadInt32("Enter the relase year: ");
    rating = ReadString("Enter the MPAA rating: ");

    Console.WriteLine("is this a classic?: ");
}