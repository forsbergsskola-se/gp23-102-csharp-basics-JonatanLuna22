// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hej! Here You can covert minutes to seconds. Give it a try!");
string minutes = Console.ReadLine();
int m = int.Parse(minutes);
int s = m * 60;
Console.WriteLine($"{minutes} minutes are {s} seconds");