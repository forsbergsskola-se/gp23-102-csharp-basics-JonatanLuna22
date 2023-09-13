/* Write a program that checks if a given integer is even or odd and displays an appropriate message.

Input: 12
Output: "That's even." */

{
    Console.WriteLine("Hej! Give me a whole number and I will tell you if it is even or odd.");
    int number = int.Parse(Console.ReadLine());

    int remainder = number % 2; // int r = x % y;

    if (remainder == 0) // if((num % 2) == 0)
    {
        Console.WriteLine($"{number} is and even number.");
    }
    else
    {
        Console.WriteLine($"{number} is and odd number.");
    }
}

{
    Console.WriteLine("Hej! Give me a whole number and I will tell you if it is even or odd.");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine(number % 2 == 0 ? $"{number} is and even number." : $"{number} is and odd number.");
}

/*
 Option 1
    string response1;
    response1 = number % 2 == 0 ? "even" : "odd";
    if (number % 2 == 0)
    {
        response1 = "even";
    }
    else
    {
        response1 = "odd";
    }
    
Option 2
    if (number % 2 == 0)
    {
        Console.WriteLine("even");
    }
    else
    {
        Console.WriteLine("odd");
    }
*/

// Variable x ? = Then : Otherwise.
// Example: String x = age <= 12 ? "child" : age >= 12 ? teen : "adult:
