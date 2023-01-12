﻿string firstName = string.Empty;
string lastName = string.Empty;
string middleName = string.Empty;
int age = 0;
double salary = 0.0;



Console.Write("Please enter your first name");
firstName = Console.ReadLine();

Console.Write("Please enter your middle name");
middleName = Console.ReadLine();

Console.Write("Please enter your last name");
lastName = Console.ReadLine();


Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());


Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());


Person person = new Person(firstName, lastName, age, salary);

if (string.IsNullOrEmpty(middleName))
{
    Console.WriteLine($"The name entered is {person.GetFullName()}");
}
else
{
    Console.WriteLine($"The name entered is {person.GetFullName(middleName)}");
}

Console.WriteLine($"The age entered is {person.Age}");
Console.WriteLine($"The salary entered is {person.GetSalary()}");

