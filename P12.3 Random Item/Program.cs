
// Write a program that simulates item drops in a game. Define five different items, and randomly select an item for the player to acquire.

int Water = 0;
int Fire = 1;
int Earth = 2;
int Wind = 3;
int Ray = 4;

int power = Random.Shared.Next(0, 5);

Console.WriteLine(power == Water ? "You have imbued with the power of the Water." : 
power == Fire ? "You have imbued with the power of the Fire." :
power == Earth ? "You have imbued with the power of the Earth." :
power == Wind ? "You have imbued with the power of the Wind." :
"You have imbued with the power of the Ray.");

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