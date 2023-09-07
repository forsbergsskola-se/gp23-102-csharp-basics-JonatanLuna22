
Console.WriteLine(@"Hej! Here you can calculate your BMI

How much do you weight in kilograms?");

string answer1 = Console.ReadLine();
float w = float.Parse(answer1);

Console.WriteLine("And how tall are you in meters?");

string answer2 = Console.ReadLine();
float h = float.Parse(answer2);

float r = w / (h * h);

Console.WriteLine($"Your BMI is {r}.");