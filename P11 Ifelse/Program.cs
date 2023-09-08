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
string answer = Console.ReadLine();
int age = int.Parse(answer);

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
