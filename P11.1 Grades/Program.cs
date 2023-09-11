/* bool isChild = age <= child;
bool isTeenager = age > child && age < adult;
bool isAdult = age >= adult; */

Console.WriteLine(@"Hej! Give me a number between 0 and 100 and I will place it in one of the following scales:

A: 90-100

B: 80-89

C: 70-79

D: 60-69

F: <60");

int number = int.Parse(Console.ReadLine()); 

if (number <= 100 && number > 89)
{
    Console.WriteLine(@$"The number {number} is in the scale 
A: 90-100.");
}
else if (number <= 89 && number > 79)
{
    Console.WriteLine(@$"The number {number} is in the scale 
B: 80-89.");
}
else if (number <= 79 && number > 69)
{
    Console.WriteLine(@$"The number {number} is in the scale 
C: 70-79.");
}
else if (number <= 69 && number > 59)
{
    Console.WriteLine(@$"The number {number} is in the scale 
D: 60-69.");
}
else
{
    Console.WriteLine(@$"The number {number} is in the scale 
F: <60.");
}    


