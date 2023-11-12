// if (n >= 0 && n <= 9)
//if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')

Console.WriteLine("Hej! Text a single character and I will tell you if it is a number, a vowel or a consonant.");
char c = char.Parse(Console.ReadLine());

if (c >= '0' && c <= '9')
{
    Console.WriteLine($"{c} is a number.");
}
else if (c == 'a' ||c == 'e' ||c == 'i' ||c == 'o' ||c == 'u' ||c == 'A' ||c == 'E' ||c == 'I' ||c == 'O' ||c == 'U')
{
    Console.WriteLine($"{c} is a vowel.");
}
else 
{
    Console.WriteLine($"{c} is a consonant.");
}
    
// if (x == 'a' || x == 'e' || x == 'i' || x == 'o' || x == 'u')

// Variable x ? = Then : Otherwise.
// Example: String x = age <= 12 ? "child" : age >= 12 ? teen : "adult: