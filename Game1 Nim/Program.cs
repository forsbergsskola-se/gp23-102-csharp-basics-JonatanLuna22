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

Console.WriteLine(@"Welcome to Nim!

The objective of this game is to avoid drawing the last match.
You can choose to draw between 1 or 3 matches and the IA will do the same.
Good luck!

So... How many matches do you want to draw?
||||||||||||||||||||||||");

int Pmatch = int.Parse(Console.ReadLine());
  
string sign = "|";

Console.WriteLine("Your turn");

Print:
{
    Console.Write(sign * Pmatch);
    goto Print;
}

