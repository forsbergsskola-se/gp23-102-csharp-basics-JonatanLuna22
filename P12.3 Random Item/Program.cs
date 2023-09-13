
// Write a program that simulates item drops in a game. Define five different items, and randomly select an item for the player to acquire.

int Water = 0;
int Fire = 1;
int Earth = 2;
int Wind = 3;
int Ray = 4;

int number = Random.Shared.Next(0, 5);

string power = number == Water ? "Water." : number == Fire ? "Fire." : number == Earth ? "Earth." : number == Wind ? "Wind." : "Ray";

Console.WriteLine($"You have been imbued with the power of the {power}");

/*
if (power == Water)
{
  Console.WriteLine("You have imbued with the power of the Water.");
}
else if (power == Fire)
{
  Console.WriteLine("You have imbued with the power of the Fire.");
}
else if (power == Earth)
{
  Console.WriteLine("You have imbued with the power of the Earth.");
}
else if (power == Wind)
{
  Console.WriteLine("You have imbued with the power of the Wind.");
}
else
{
  Console.WriteLine("You have imbued with the power of the Ray.");
}
*/

/*
Console.WriteLine(power == Water ? "You have been imbued with the power of the Water." :
power == Fire ? "You have been imbued with the power of the Fire." :
power == Earth ? "You have been imbued with the power of the Earth." :
power == Wind ? "You have been imbued with the power of the Wind." :
"You have been imbued with the power of the Ray.");
*/