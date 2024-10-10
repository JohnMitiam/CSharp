// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello World!");
Console.WriteLine("Its me Jacko!");
Console.WriteLine(" ");

Console.WriteLine("*We are Learning Integers");
decimal a = 42.1M; // explicit type
Console.WriteLine($"Integer a = {a}");
decimal b = 38.2M;
Console.WriteLine($"Integer b = {b}");
decimal c = a + b;
Console.WriteLine($"The answer to a + b is {c}");
Console.WriteLine(" ");

Console.WriteLine("*We're Learning IF's Statements");
int d = 5;
int e = 5;
int f = 10;
int g = d + e + f;


if (g == 20)
{
    Console.WriteLine("The answer is equal to 20");
}
else
{
    if ((g < 20) && (d == e))
    {
        Console.WriteLine("The first numer is equal to the second");
        Console.WriteLine($"The Answer is less than 20 so, integer D + integer E is {f}");

    }
    else
    {
        Console.WriteLine("the answer is greater than 20");
        Console.WriteLine("Or the first number is not equal to the second");
    }
}