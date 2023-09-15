/*

Output:I have picked a number (1-100). It's your turn to guess it!
Input:32
Output:Nope! My number is Greater!
Input:60
Output: Nope! My number is Smaller!
Input:42
Output: That's the number! Well played!

*/

int Rnumber = Random.Shared.Next(0, 100);

Console.WriteLine("I have picked a number (1-100). You have 10 tries to guess it!");

int tries = 0;

Again:
int Pnumber = int.Parse(Console.ReadLine());
tries++;

if (tries < 10)
{
   if (Pnumber == Rnumber)
   {
      Console.WriteLine($"Congratulation {Pnumber} is the number I picked. You win!");
   }

   else if (Pnumber < Rnumber)
   {
      Console.WriteLine($"Nope! My number is greater! You have {10 - tries} tries left.");
   }

   else
   {
      Console.WriteLine($"Nope! My number is smaller! You have {10 - tries} tries left.");
   }

   goto Again;
}
Console.WriteLine("You run out of tries. Game over!");