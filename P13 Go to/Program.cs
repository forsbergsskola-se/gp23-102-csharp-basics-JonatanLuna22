/*

Output:I have picked a number (1-100). It's your turn to guess it!
Input:32
Output:Nope! My number is Greater!
Input:60
Output: Nope! My number is Smaller!
Input:42
Output: That's the number! Well played!

PSEUDOCODE:
myNumber := random number between 1 and 100
explain rules to user
USER_TURN:
ask user for number
guess := user input

if myNumber is less than guess then
   tell user to guess lower
   go back to USER_TURN
end if

if myNumber is greater than guess then
   tell user to guess higher
   go back to USER_TURN
end if

if myNumber is equal to guess then
   tell user he won
end if

*/
int Rnumber = Random.Shared.Next(0, 10);

Console.WriteLine("I have picked a number (1-100). It's your turn to guess it!");

Again:
int Pnumber = int.Parse(Console.ReadLine());

if (Pnumber == Rnumber)
{Console.WriteLine($"Congratulation {Pnumber} is the number I picked. You win!");}

else if (Pnumber < Rnumber)
{Console.WriteLine("Nope! My number is greater!");}

else
{Console.WriteLine("Nope! My number is smaller!");}
goto Again;
