int hours;

Console.WriteLine("Hours: ");
string value = Console.ReadLine();

hours = Int32.Parse(value);

Console.WriteLine("Pay rate: ");
value = Console.ReadLine();

double payRate = Double.Parse(value);

Console.WriteLine("Your pay is " + (hours * payRate));


int x;
double distanceFromMoon = 0;
//distanceFromMoon = 0;
char letterGrade;
bool isPassing;


string firstName = "Bob", lastName = "Smith";

//firstName = lastName = "Sam";
//firstName = "Sam";
//lastname = "Sam;

//string lastname;

//int iHours; 
//float fRate;

string name;

//block statement *0 or more 

//{
//    decimal payRate;
//}

//distanceFromMoon = 10.5;
isPassing = distanceFromMoon > 10;

int y = 10;

Console.WriteLine(++y);
Console.WriteLine(y);

Console.WriteLine(--y);
Console.WriteLine(y);

Console.WriteLine(y++);
Console.WriteLine(y);

Console.WriteLine(y--);
Console.WriteLine(y);

//STRINGS 

string emptyString = "";
string emptyString2 = String.Empty;
bool areEmptyStringsEqual = emptyString == emptyString2;
string nullString = null;           //bad, cause problems / default value of string 
bool isEmptyString = (emptyString == null) || (emptyString == ""); 
isEmptyString = String.IsNullOrEmpty(emptyString);          //check if null or empty string 

//literal
string someString = "Hello \"World";  
Console.WriteLine("Hello");
Console.WriteLine("World");
Console.WriteLine("hello\nWorld");          //for new line just write console.writeline 
string filePath = "C:\\windpws\\system32";

//Verbatim
filePath = @"C:\windpws\system32";           //escape sequences ignored  at sign at front 

//CONCATENATION 
string fullName = "Bob" + " " + "Smith";
fullName = String.Concat("Bob", "", "Smith");
String someValues = String.Concat("You are ", 10, "Years old", true);
string names = String.Join(", ", "Bob", "Sue", "Jam", "George");

int stringLegnth = fullName.Length;     //tells you how many characters are in that string 
isEmptyString = fullName.Length == 0;

//MANIPULATION 
string upperName = fullName.ToUpper();
string lowerNmae = fullName.ToLower();

fullName = "    Bob Smith    ";
fullName = fullName.Trim();     //fullName.TrimStart().TrimEnd()    string 
filePath = filePath.Trim('\\');

fullName.PadLeft(10);       //.PadRight(10);

//COMPARISON
filePath.StartsWith("C:\\", StringComparison.OrdinalIgnoreCase);
filePath.EndsWith("\\");

//Comparison 1- relatioanl ops (culture aware, case sensitive           //if case does matter 
bool areEqual = firstName == lastName;

string input = Console.ReadLine();
//input if (input == "A")
if (input.ToUpper() == "A")
    Console.WriteLine("A");
else if (input == "B")
    Console.WriteLine("B");
else 
    Console.WriteLine("Other");

//Comparison 2 - Strin.Compare
if (String.Compare(input, "A", StringComparison.OrdinalIgnoreCase) == 0)  //same
    Console.WriteLine("A");
else if (string.Compare(input, "B", true) == 0)                           //same 
    Console.WriteLine("B");

//comparizon 3 - String.Equal (Most likely oto use) 
if (String.Equals(input, "A", StringComparison.OrdinalIgnoreCase))   //dont care about case    bool 
    Console.WriteLine("A");