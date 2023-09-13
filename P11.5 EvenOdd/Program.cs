/* Write a program that checks if a given integer is even or odd and displays an appropriate message.

Input: 12
Output: "That's even." */
{
    Console.WriteLine("Hej! Give me a whole number and I will tell you if it is even or odd.");
    int number = int.Parse(Console.ReadLine());

    int remainder = number % 2;   // int r = x % y;

    if (remainder == 0)         // if((num % 2) == 0)
    {
        Console.WriteLine($"{number} is and even number.");
    }
    else 
    {
        Console.WriteLine($"{number} is and odd number.");
    }
}

{
    {
    Console.WriteLine("Hej! Give me a whole number and I will tell you if it is even or odd.");
    int number = int.Parse(Console.ReadLine());

    number % 2 == 0 ? Console.WriteLine($"{number} is and even number.")
        : Console.WriteLine($"{number} is and odd number.")
    }
}

// Variable x ? = Then : Otherwise.
// Example: String x = age <= 12 ? "child" : age >= 12 ? teen : "adult: