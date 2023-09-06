// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hej! Here You can covert minutes to seconds. Give it a try!");
string answer = Console.ReadLine();
int m = int.Parse(answer);
int s = m * 60;
Console.WriteLine($"{answer} minutes are {s} seconds");