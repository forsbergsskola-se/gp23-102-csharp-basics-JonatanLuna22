/*

Write a program that prints the following pretty ASCII pattern of the size that the user desires. Use goto efficiently to write as little code as necessary.

Input: 5
#-#-#-#-#-
-#-#-#-#-#
#-#-#-#-#-
-#-#-#-#-#
#-#-#-#-#-

*/

Console.WriteLine("Hej! I will create a pattern for you. Give me a whole number and that will be the size of the pattern (x times x).");
int sharps = int.Parse(Console.ReadLine());
  
string sign = "#";

Console.WriteLine("Here is your pattern:");

int counter2 = 0;
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
    if (counter2 < sharps -1)
    {
        counter2++;
        Console.WriteLine();
        goto PrintRow;
    }
}