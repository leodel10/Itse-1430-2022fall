﻿//Movie Definition 
using MovieLibrary;

//Movie movie = new Movie();
//movie.title = "Jaws";
//movie.releaseYear = 1997;

DisplayInformation();
Movie movie = null;
//bool done = false;
var done = false;
do 
{
    //Type Inferencing - Compiler figures out type based upon context 
    //MenuOption input = DisplayMenu();
    var input = DisplayMenu();
    Console.WriteLine();
    switch (input)
    {
         
        case MenuOption.Add:
        {
            var theMovie = AddMovie();
            movie = theMovie.Clone();
            break;
        }
        case MenuOption.Edit: EditMovie(); break;
        case MenuOption.View: ViewMovie(movie); break;
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
    //Console.WriteLine("----------");
    Console.WriteLine("".PadLeft(10, '-'));
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
        //if (Int32.TryParse(value, out int result))
        if (Int32.TryParse(value, out var result))
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

Movie AddMovie ()
{
    Movie movie = new Movie ();

    ////string title = ""
    //movie.title = ReadString("Enter a title: ", true);
    movie.SetTitle(ReadString("Enter a title: ", true));

    //string description = "";
    movie._description = ReadString("Enter an optional description: ", false);

    movie._runLegnth = ReadInt32("Enter the run leghtn (in minutes): ",0, 300);

    movie._releaseYear = ReadInt32("Enter the relase year: ", 1900, 2100);
    movie._rating = ReadString("Enter the MPAA rating: ", true);

    movie._isClassic = ReadBoolean("Is this a classic?: ");

    return movie; 
}

Movie GetSelectedMovie()
{
    return movie;
}

void EditMovie ()
{ }

void DeleteMovie ()
{

    var selectedMovie = GetSelectedMovie();
    //no movie
    if (selectedMovie == null)
        return;

    //not confirmed
    if (!ReadBoolean($"are you sure you want to delete movie '{selectedMovie.GetTitle}' (Y/N)?"))
        return;

    //todo; delete movie 
    movie = null;
}

void ViewMovie ( Movie movie )
{
    if (movie == null)
    {
        Console.WriteLine("No movies available");
        return;
    };

    //String Formatting 
    //Option 1- Concatenation
    //Console.WriteLine("Legnth: "+ runLegnth + "mins");

    //Optioin 2 - String.Format

    //Option 3 - String interpolation (cleaner than string.formtat)
    //Console.WriteLine($"Length: {runLegnth} mins");
    //string someValue = $"Length: {runLegnth} mins";

    //ToString
    //Console.WriteLine($"{movie.title} ({movie._releaseYear})");
    Console.WriteLine($"{movie.GetTitle()} ({movie._releaseYear})");
    //Console.WriteLine(releaseYear);
    //Console.WriteLine(releaseYear.ToString());

    //Console.WriteLine("Legnth: "+ runLegnth + "mins");
    //Console.WriteLine(String.Format("Length: {0} mins", runLegnth));
    //Console.WriteLine("Length: {0} mins", runLegnth);
    Console.WriteLine($"Length: {movie._runLegnth} mins");

    Console.WriteLine($"Rated: {movie._rating}");
    //Console.WriteLine($"This {(isClassic? "Is" : "Is Not")} a Classic: ");
    Console.WriteLine($"Is Classic: {(movie._isClassic ? "Yes" : "No")}");
    Console.WriteLine(movie._description);
}