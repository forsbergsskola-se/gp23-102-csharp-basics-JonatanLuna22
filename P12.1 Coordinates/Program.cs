
// Develop a program that generates random X and Y coordinates for an enemy in a 2D game world with 100x100 coordinates. Display these coordinates to the user.

Console.WriteLine("Hej player! The coordinates for the Boss are:");

int X = Random.Shared.Next(0, 100);
Console.WriteLine($"{X} for X");

int Y = Random.Shared.Next(0, 100);
Console.WriteLine($"{Y} for Y");



