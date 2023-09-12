/*
 Develop a simple calculator program that allows operations such as addition, subtraction, multiplication, and division. Allow the user to choose which operation to perform.

Input: 3, +, 7
Output: 10 
*/

// String.Contains(Char value)

// Identifica que es un float, crea una variable. Identifica el simbolo y asignale una varialble char.

Console.WriteLine("Text an addition, a subtraction, a multiplication or a division in the next format: (x + y)");
string operation = Console.ReadLine();

if (operation.Contains('+'))
{
 Console.WriteLine($"{operation} is an addition.");
}
else if (operation.Contains('-'))
{
 Console.WriteLine($"{operation} is a subtraction.");
}
else if (operation.Contains('*'))
{
 Console.WriteLine($"{operation} is a multiplication.");
}
else if (operation.Contains('/'))
{
 Console.WriteLine($"{operation} is a division.");
}
