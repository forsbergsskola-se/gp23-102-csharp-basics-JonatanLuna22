
Console.WriteLine(@"Hej! Here you can multiply two whole numbers and get the result.

Give me a number!");

string answer1 = Console.ReadLine();
int x = int.Parse(answer1);

Console.WriteLine("And now give me a second one.");

string answer2 = Console.ReadLine();
int y = int.Parse(answer2);

int r = x * y;

Console.WriteLine($"{answer1} multiply by {answer2} is {r}.");