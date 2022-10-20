//Leobardo Delgado 
//LAB 2
//ITSE 1430 Creating a character 

Console.WriteLine();



var done = false;
do
{
    var choice = DisplayMenu();
    Console.WriteLine();
    switch (choice)
    {
        case MenuOption.Create: CreateCharacter(); break; 
        case MenuOption.Add: AddCharacter(); break;
        case MenuOption.View: ViewCharacter(); break;
        case MenuOption.Edit: EditCharacter(); break;
        case MenuOption.Delete: DeleteCharacter(); break;
        case MenuOption.Quit: Quit(); break;
    };
}while (!done);



//functions
MenuOption DisplayMenu()
{
    Console.WriteLine("C. Create a character");
    Console.WriteLine("A. Add a character");
    Console.WriteLine("V. View Character");
    Console.WriteLine("E. Edit a character");
    Console.WriteLine("D. Delete a character");
    Console.WriteLine("Q. Quit program");
    Console.WriteLine();

    do
    {
        ConsoleKeyInfo key = Console.ReadKey(true);
        switch (key.Key)
        {
            case ConsoleKey.C: return MenuOption.Create;
            case ConsoleKey.A: return MenuOption.Add;
            case ConsoleKey.V: return MenuOption.View;
            case ConsoleKey.E: return MenuOption.Edit;
            case ConsoleKey.D: return MenuOption.Delete;
            case ConsoleKey.Q: return MenuOption.Quit;
        };

    } while (true) ;

}

void CreateCharacter()
{
    Console.WriteLine("Create Character");
}

void AddCharacter()
{
    Console.WriteLine("Add Character");
}

void ViewCharacter()
{
    Console.WriteLine("View character");
}

void EditCharacter()
{
    Console.WriteLine("Edit character");
}

void DeleteCharacter()
{
    Console.WriteLine("Delete character");
}

void Quit ()
{
    Console.WriteLine("Are you sure you want to quit? Yes or No");
    var input = Console.ReadLine();

    if (input == "No")
        DisplayMenu();
    else if (input == "Yes") ;
        


}
