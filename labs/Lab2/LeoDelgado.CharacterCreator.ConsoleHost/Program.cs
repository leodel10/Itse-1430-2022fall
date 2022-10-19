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
    Console.WriteLine("Hello");
}

void AddCharacter()
{
    Console.WriteLine("Add");
}

void ViewCharacter()
{
    Console.WriteLine("View");
}

void EditCharacter()
{
    Console.WriteLine("Edit");
}

void DeleteCharacter()
{
    Console.WriteLine("Delete");
}

void Quit ()
{
    Console.WriteLine("Are you sure you want to quit? Yes or No");
    var input = Console.ReadLine();

    if (input == "No")
        DisplayMenu();
    else if (input == "Yes") ;
        


}
//while (choice != -1)
//{
//    DisplayMenu();
//    Console.WriteLine();
//    choice = int.Parse(Console.ReadLine());

//;    if (choice > 6 || choice < 0)
//    {
//        Console.WriteLine("Invalid entry. Please select 1-5");
//        continue;
//    }

//    switch(choice)
//    {
//        case 1: CreateCharacter(); break;
//        case 2: AddCharacter(); break;
//        case 3: ViewCharacter(); break;
//        case 4: EditCharacter(); break;
//        case 5: DeleteCharacter(); break;
//        case 6: break;
//    }
//}
