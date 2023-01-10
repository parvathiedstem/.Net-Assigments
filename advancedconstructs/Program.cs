using System.Globalization;

Console.Write("enter number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

void Add(int a, int b)
{
    Console.WriteLine($"Addision: {a + b}");
}
Add(num1,num2);
Add(1,3);

int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b > largest)
    {
        largest = b;
    }
    if (c > largest) 
    {
        c = largest;
    }
    return largest;
}
int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"Largest number is {largest}");

//concatination

string firstName = "parvathi";
string lastName = "sreekumar";


string fullName = firstName + " " + lastName;

// Length of a string 

int length = fullName.Length;
Console.WriteLine($"First name has  {length} letters");

//Replace string parts
string newLaststName = lastName.Replace("kumar", "in");
Console.WriteLine($"New last Name is {newLaststName}");

//spilt
string toSplit = "parvathi, jenu, asif, megu";
string[] names = toSplit.Split(',');
for(int i=0;i < names.Length;i++)
{
    Console.WriteLine(names[i]);
}

//compare

string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";

if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullstring is empty or null");
}
if (string.IsNullOrWhiteSpace(whiteSpaceString))
{
    Console.WriteLine("nullDtring is empty or null");
}
int res = firstName.CompareTo(lastName);

if (firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstname and lastname are equal");
}
if (firstName.Equals(lastName))
{
    Console.WriteLine("firstname and lastname are equal");
}


//DateTime related functionality

// Empty DateTime

DateTime date = new DateTime();

// Create DateTime from data

DateTime dateOfBirth = new DateTime(1998, 1, 25);
Console.WriteLine($"Date of Birth is {dateOfBirth}:");

//Create DteTime from string

DateTime parsedDate = DateTime.Parse("3/31/2000",CultureInfo.InvariantCulture);
Console.WriteLine($"Parsed date is {parsedDate}");

// Create DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current time is {now}");

// Date to ticks
Console.WriteLine($"Current time is {now.Ticks}");

// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");

// Dateonly

DateOnly dob = DateOnly.FromDateTime(dateOfBirth);

// TimeOnly

TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth);

// Exeption Hndling

Console.Write("Enter number 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());

try
{
    double quotient = num1 / num2;
    Console.WriteLine($"Result is {quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");
}
catch (Exception ex)
{
    throw ex;
}
finally
{
    Console.WriteLine("Exited the program");
}
// Arrays
//initialize a fixed size array

int[] marks = new int[5]; //0 based index (0-4)

// iterate an array
for (int i = 0; i< marks.Length; i++)
{
    Console.Write("Enter marks : ");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}

//print an array of elements

for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}
string[] name = new string[] {"parvathi", "megu", "jenu"};


//Lists

List<string> devs = new List<string>();
string dev = string.Empty;

while(!dev.Equals("-1"))
{
    Console.Write("Enter the name of developer:");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}

foreach (string n in devs)
{
    Console.WriteLine(name);
}