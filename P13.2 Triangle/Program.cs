/* Write a program that prints an ASCII Triangle as big as the user desires. Use goto efficiently to write as little code as necessary.

Input: 5
#####
####
###
##
#

*/

Console.WriteLine("How big do you want your right triangle? Tell me a whole number and that will be the lines and columns it will occupy.");
int sharp = int.Parse(Console.ReadLine());

int counter = 0;
  
string sign = "#";

Console.WriteLine("Here is your triangle:");

Print:
if (counter > 0) 
{
  counter++;
  Console.WriteLine(sharp --);
  goto Print;
}


