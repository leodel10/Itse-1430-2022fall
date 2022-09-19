//Leobardo Delgado ITSE_2409 

DisplayInformation();

int input = -1;
while (input !=0)
{
    DisplayMenu();
    Console.WriteLine();
    input = Convert.ToInt32(Console.ReadLine());

    if (input > 5 || input <0)
    {
        Console.WriteLine("Invalid choice. Please select 1 - 5: ");
        continue;
    }

    switch (input)
    {
        case 1: StartOrder(); break;
        case 2: ViewOrder(); break;
        case 3: ClearOrder(); break;
        case 4: ModifyOrder(); break;
        case 5: Quit(); break;

    }
}

    //if (input == 1)
    //    StartOrder();
    //else if (input == 2)
    //    ViewOrder();
    //else if (input == 3)
    //    ClearOrder();
    //else if (input == 4)
    //    ModifyOrder();
    //else if (input == 5)
    //    Quit();
    //break;









//Functions 

void DisplayInformation()
{
    Console.WriteLine("Leo");
    Console.WriteLine("ITSE 1430");
    Console.WriteLine("Date");
}

bool ReadBoolean ( string message )
{
    Console.Write(message);

    //looking for Y/N
    do
    {
        ConsoleKeyInfo key = Console.ReadKey();
        if (key.Key == ConsoleKey.Y)
            return true;
        else if (key.Key == ConsoleKey.N)
            return false;
    } while (true);
}



void DisplayMenu ()
{
    Console.WriteLine();
    Console.WriteLine("1.Start Order");
    Console.WriteLine("2.View order");
    Console.WriteLine("3.lear Order");
    Console.WriteLine("4.Modify order");
    Console.WriteLine("5.Quit");


}

void StartOrder()
{
    Console.WriteLine("Start Order has been executed");
}

void ViewOrder()
{
    Console.WriteLine("View Order has been executed");
}

void ClearOrder ()
{
    Console.WriteLine("Clear Order has been executed");
}

void ModifyOrder ()
{
    Console.WriteLine("Modify Order has been executed");
}


void Quit ()
{
    string choice = "";

    Console.WriteLine("Are you sure to exit the program?: Yes/No");
    choice = Console.ReadLine();
    
    if (choice == "yes")
        


    return;
 

}

