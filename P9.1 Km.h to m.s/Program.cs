// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hej! Here You can covert km/h to m/s. Give it a try!");
string answer = Console.ReadLine();
float kmh = int.Parse(answer);
float ms = kmh / 18 * 5;
Console.WriteLine($"{answer} k/m are {ms} m/s");