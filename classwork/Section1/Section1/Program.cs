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
string nullString = null; //bad, cause problems / default value of string 
bool isEmptyString = (emptyString == null) || (emptyString == ""); 
isEmptyString = String.IsNullOrEmpty(emptyString); //check if null or empty string 

//literal
string someString = "Hello \"World";
Console.WriteLine("Hello");
Console.WriteLine("World");
Console.WriteLine("hello\nWorld");  //for new line just write console.writeline 
string filePath = "C:\\windpws\\system32";

//Verbatim
filePath = @"C:\windpws\system32"  //escape sequences ignored 