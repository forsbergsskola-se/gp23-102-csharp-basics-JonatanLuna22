/*
Console.WriteLine("What time is it?");
int time = int.Parse(Console.ReadLine());

if (time < 12)
{
    Console.WriteLine("Good Morning!");
}
else if (time < 18)
{
    Console.WriteLine("Good Day!");
}
else
{
    Console.WriteLine("Good evening!");
}
*/

Console.WriteLine("What's your age?");
string answer1 = Console.ReadLine();
int age = int.Parse(answer1);

// Age

if (age <= 12)
{
    Console.WriteLine("You are a child.");
}
else if (age > 13 && age < 19)
{
    Console.WriteLine("You are a teenager.");
}
else 
{ 
    Console.WriteLine("You are an adult.");
}    

Console.WriteLine("Give me another number.");
string answer2 = Console.ReadLine();
int number = int.Parse(answer2);

// Random number

if (number == age)
{
    Console.WriteLine("It is the same number than your age.");
}
else if (number < age)
{
    Console.WriteLine($"Your age is greater than {answer2}.");
    goto bigage
}
else
{
    Console.WriteLine($"{answer2} is greater than your age.");
}

// Even or odd

big

if (number % 2 == 0)
{
    Console.WriteLine($"And {answer2} is an even number.");
}    
else
    Console.WriteLine($"And {answer2} is an odd number.");    

// This is not the way: bool odd = 1 || 3 || 5 || 7 || 9;


