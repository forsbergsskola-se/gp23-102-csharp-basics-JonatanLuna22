// See https://aka.ms/new-console-template for more information

Console.WriteLine("Give me a number.");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Another one.");
int number2 = int.Parse(Console.ReadLine());

Console.WriteLine("And the last one.");
int number3 = int.Parse(Console.ReadLine());

// The smallest number

if (number1 < number2 && number1 < number3)
{
    Console.WriteLine($"The number {number1} is the smallest.");
}
else if (number2 < number1 && number2 < number3)
{
    Console.WriteLine($"The number {number2} is the smallest.");
}
else (number3 < number1 && number3 < number2)
{
    Console.WriteLine($"The number {number3} is the smallest.");
}

// The greatest number

if (number1 > number2 && number1 > number3)
{
    Console.WriteLine($"And the number {number1} is the greatest.");
}
else if (number2 > number1 && number2 > number3)
{
    Console.WriteLine($"And the number {number2} is the greatest.");
}
else (number3 > number1 && number3 > number2)
{
    Console.WriteLine($"And the number {number3} is the greatest.");
}