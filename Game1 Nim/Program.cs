/* Output:Welcome to Nim!
Output:|||||||||||||||||||||||| (24)
Output:How many matches do you want to draw?
Input:3
Output:||||||||||||||||||||| (21)
Output:The AI draws 3 matches.
Output:|||||||||||||||||| (18)
...
Output:|||
Output:The AI draws 2 matches.
Output:|
Output:How many matches do you want to draw?
Input: 1
Output:You drew the last match. You lose.
*/

Console.WriteLine(@"Welcome to Nim! A two players competitive game.

The objective of this game is to win! How? Try to avoid drawing the last match.
You can choose to draw between 1 or 3 matches and the IA will do the same.
Good luck!

So... How many matches do you want to draw?");

string sign = "|";

int matches = 24;

Print1:
if (matches == 1)
{
    Console.WriteLine(@"|
    You get the last match... Game over!");
    goto end;
}
if (matches > 0)
{
        int counter1 = 0;
        Print2:
        if (matches > counter1)
        {
            counter1++;
            Console.Write(sign);
            goto Print2;
        }
        Console.Write($" {matches}");
        Console.WriteLine();
}
{ 
    Ask:
Console.WriteLine();
Console.WriteLine("It's your turn.");
int Pmatches = int.Parse(Console.ReadLine()); // ask input
// if input is invalid then go back to ask input
    if (Pmatches < 0 || Pmatches > 3)
    {
        goto Ask;
    }
    matches -= Pmatches;
    
}

if (matches > 0)
{
    int counter1 = 0;
    Print4:
    if (matches > counter1)
    {
        counter1++;
        Console.Write(sign);
        goto Print4;
    }
    Console.Write($" {matches}");
    Console.WriteLine();
}

// AI Move
if (matches == 5 || matches == 9 || matches == 13 || matches == 17 || matches == 21)
{
int random = Random.Shared.Next(1, 4);
Console.WriteLine();
Console.WriteLine($"It's my turn. I draw {random}.");
matches -= random;
}
if (matches == 2 || matches == 6 || matches == 10 || matches == 14 || matches == 18 || matches == 22)
{
    Console.WriteLine();
    Console.WriteLine("It's my turn. I draw 1.");
    matches -= 1;
}
if (matches == 3 || matches == 7 || matches == 11 || matches == 15 || matches == 19 || matches == 23)
{
    Console.WriteLine();
    Console.WriteLine("It's my turn. I draw 2.");
    matches -= 2;
}
if (matches == 4 || matches == 8 || matches == 12 || matches == 16 || matches == 20)
{
    Console.WriteLine();
    Console.WriteLine("It's my turn. I draw 3.");
    matches -= 3;
}
goto Print1;

end:;