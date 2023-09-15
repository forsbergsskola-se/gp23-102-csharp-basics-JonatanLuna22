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
    You get the last match. I'm sorry you didn't have a chance. 
    Game over!");
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

// Player Move
{ 
    Ask:
Console.WriteLine();
Console.WriteLine("It's your turn.");
int Pmatches = int.Parse(Console.ReadLine()); 
   
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
Console.WriteLine(@$"It's my turn.
{random}");
matches -= random;
goto Print1;
}

if (matches%4 == 2)
{
    Console.WriteLine();
    Console.WriteLine(@"It's my turn.
1.");
    matches -= 1;
    goto Print1;
    
}
if (matches%2 == 1)
{
    Console.WriteLine();
    Console.WriteLine(@"It's my turn.
2.");
    matches -= 2;
    goto Print1;
    
}

if (matches%2 == 0)
{
    Console.WriteLine();
    Console.WriteLine(@"It's my turn.
3.");
    matches -= 3;
}
goto Print1;

end:;