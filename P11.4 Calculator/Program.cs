/*
 Develop a simple calculator program that allows operations such as addition, subtraction, multiplication, and division. Allow the user to choose which operation to perform.

Input: 3, +, 7
Output: 10
*/

// String.Contains(Char value)

// Identifica que es un float, crea una variable. Identifica el simbolo y asignale una varialble char.

Console.WriteLine("Hej! Give me a number.");
float number1 = float.Parse(Console.ReadLine());

Console.WriteLine("Hej! Give me a second number.");
float number2 = float.Parse(Console.ReadLine());

Console.WriteLine("Now text an addition, a subtraction, a multiplication or a division in the next format: (x + y) with the numbers you gave me.");
string operation = Console.ReadLine();

if (operation.Contains('+'))
{
    float result = number1 + number2;
    Console.WriteLine($"{operation} = {result}.");
}
else if (operation.Contains('-'))
{
    float result = number1 - number2;
    Console.WriteLine($"{operation} = {result}.");
}
else if (operation.Contains('*'))
{
    float result = number1 * number2;
    Console.WriteLine($"{operation} = {result}.");
}
else if (operation.Contains('/'))
{
    float result = number1 / number2;
    Console.WriteLine($"{operation} = {result}.");
}