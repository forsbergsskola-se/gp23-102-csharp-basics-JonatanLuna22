﻿/* Output:Welcome to Nim!
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

So... How many matches do you want to draw?");
 
string sign = "|";

int matches = 24;

Print1:
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
}
{ 
Console.WriteLine();
int Pmatches = int.Parse(Console.ReadLine());
    matches -= Pmatches;
    goto Print1;
}

// Reduzco, escribo, goto

// int Pmatch = int.Parse(Console.ReadLine());
// Console.WriteLine("Your turn");

/*
if (sharps > 0 && sharps > counter5) 
{
    int counter = 0;
    Print:
    if (counter < sharps)
    {
        counter++;
        Console.Write(sign);
        goto Print;
    }
    
     
string sign = "$";

Console.Write("Here is your dollars: ");

int counter = 0;
Print:
if (counter < dollars)
{
    counter++;
    Console.Write(sign);
    goto Print;
}
*/
