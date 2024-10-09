// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");

string firstName = "   John   ";

firstName = firstName.Trim();

string lastName = "   Mitiam   ";

Console.WriteLine();

string name = $"I am {firstName} {lastName.Trim()}";

Console.WriteLine(name.ToUpper());

Console.WriteLine(name);

Console.WriteLine(name.StartsWith("I"));

Console.WriteLine(name.Length);
