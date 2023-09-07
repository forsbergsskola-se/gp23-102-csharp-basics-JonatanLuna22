
Console.WriteLine(@"Hej! I can transform seconds in minutes and give you a remaining in seconds);
Give me a number that represents seconds:");

string answer1 = Console.ReadLine();
int s = int.Parse(answer1);

float m = s / 60;

int r = s % 60;

Console.WriteLine($"{answer1} seconds are {m} minutes and {r}seconds.");