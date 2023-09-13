
// Write a Program that asks how many Dollars the user wants. Then, the program proceeds to printing that many Dollar Symbols.

Console.WriteLine("How many dollars do you want?");
int dollars = int.Parse(Console.ReadLine());

int counter = 0;
  
string sign = "$";

Console.Write("Here is your dollars: ");

Print:
if (counter < dollars)
{
  counter++;
  Console.Write(sign);
  goto Print;
}

/*
Console.WriteLine("$" * dollars);
*/