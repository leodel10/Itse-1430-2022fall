//Leobardo Delgado ITSE_2409 
using System.Data.SqlTypes;

//string processorChoice = "";
string memoryChoice = "";

DisplayInformation();

var input = -1;
while (input !=0)
{
    DisplayMenu();
    Console.WriteLine();
    input = Int32.Parse(Console.ReadLine());

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
    return;
}


//Functions 

void DisplayInformation()
{
    Console.WriteLine("Leo");
    Console.WriteLine("ITSE 1430");
    Console.WriteLine("Date");
}

void DisplayMenu ()
{
    Console.WriteLine();
    Console.WriteLine("Cart Total: ".PadLeft(18, ' '));
    Console.WriteLine();
    Console.WriteLine("1.Start Order");
    Console.WriteLine("2.View order");
    Console.WriteLine("3.lear Order");
    Console.WriteLine("4.Modify order");
    Console.WriteLine("5.Quit");
}

void StartOrder()
{
    var processorChoice = -1;

    Processor();
    Console.WriteLine();
    Console.WriteLine("Please choose your preffered processor.");
    processorChoice = Int32.Parse(Console.ReadLine());

    //if (processorChoice >6 || processorChoice < 0)
    //{
    //    Console.WriteLine("Please enter choice number 1 through 5");
    //}   
  
    Console.WriteLine("Please choose your memory storage.");
    Memory();
    memoryChoice = Console.ReadLine();

    Console.WriteLine();
    //Console.WriteLine("You chose " + processorChoice + "as your processor and " + memoryChoice + "as your memory."); 
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

    if (choice == "No")
        DisplayMenu();
    else if (choice == "")
        Console.WriteLine("Invalid, please try again");
    else if (choice == "Yes") ;
}

void Processor ()
{
    Console.WriteLine();
    Console.WriteLine ("1.AMD Ryzen 9 5900X  Price: $1410");
    Console.WriteLine ("2.AMD Ryzen 7 5700X  Price: $1270");
    Console.WriteLine ("3.AMD Ryzen 5 5600X  Price: $1200");
    Console.WriteLine ("4.Intel i9-12900K    Price: $1590");
    Console.WriteLine ("5.Intel i7-12700K    Price: $1400");
    Console.WriteLine ("6.Intel i5-12600K    Price: $1280");
}

void Memory()
{
    Console.WriteLine();
    Console.WriteLine("1. 8  GB   Price: $30");
    Console.WriteLine("2. 16 GB  Price: $30");
    Console.WriteLine("3. 32 GB  Price: $30");
    Console.WriteLine("4. 64 GB  Price: $30");
    Console.WriteLine("5. 128 GB  Price: $30");
}