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
  
string sign = "#-";
string sign2 = "-#";

Console.WriteLine("Here is your pattern:");

int counter5 = 0;
int counter2 = 0;
int counter3 = 0;
PrintRow:

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
     Console.WriteLine();
     if (counter2 < sharps -1)
     { 
        counter5++;
        counter2++;
    }
}

if (sharps > 0 && sharps > counter5)
{
    int counter4 = 0;
    Print2:
    if (counter4 < sharps)
    {
        counter4++;
        Console.Write(sign2);
        goto Print2;
    }
    Console.WriteLine();
    if (counter3 < sharps -1)
    {
        counter5++;
        counter3++;
        goto PrintRow;
    }
}
