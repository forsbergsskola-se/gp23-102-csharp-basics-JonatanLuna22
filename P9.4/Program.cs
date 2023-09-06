// See https://aka.ms/new-console-template for more information

Console.WriteLine(@"Hej! Here you can divide two numbers and get the reminder of the division.

Give me a number!");

string answer1 = Console.ReadLine();
int x = int.Parse(answer1);

Console.WriteLine("And now text de number which one you want to divide the first one");

string answer2 = Console.ReadLine();
int y = int.Parse(answer2);

int z = x / y;

int r = x % y;

Console.WriteLine($"{answer1} divided by {answer2} is {z} and the reminder is {r}");