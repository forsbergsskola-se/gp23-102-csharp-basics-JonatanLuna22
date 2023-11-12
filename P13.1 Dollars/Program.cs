
// Write a Program that asks how many Dollars the user wants. Then, the program proceeds to printing that many Dollar Symbols.

using System.Globalization;

Console.WriteLine("How many dollars do you want?");
int dollars = int.Parse(Console.ReadLine());

  
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

