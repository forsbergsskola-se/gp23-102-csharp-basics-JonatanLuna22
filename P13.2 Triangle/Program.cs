/* Write a program that prints an ASCII Triangle as big as the user desires. Use goto efficiently to write as little code as necessary.

Input: 5
#####
####
###
##
#

*/

Console.WriteLine("How big do you want your right triangle? Tell me a whole number and that will be the lines and columns it will occupy.");
int sharps = int.Parse(Console.ReadLine());
  
string sign = "#";

Console.WriteLine("Here is your triangle:");

PrintRow:
if (sharps > 0)
{
    int counter = 0;
    Print:
    if (counter < sharps)
    {
        counter++;
        Console.Write(sign);
        goto Print;
    }

    sharps--;
    Console.WriteLine();
    goto PrintRow;
}

/*
string sign = "$";

Console.Write("Here is your dollars: ");

Print:
if (counter < dollars)
{
  counter++;
  Console.Write(sign);
  goto Print;
}
*/
