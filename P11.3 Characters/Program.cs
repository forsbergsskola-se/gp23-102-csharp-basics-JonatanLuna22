
Console.WriteLine("Hej! Text a single character and I will tell you if it is a number, a vowel or a consonant.");
char c = char.Parse(Console.ReadLine());

if (c == '0' || c == '1' || c == '2' || c == '3' || c == '4' || c == '5' || c == '6' || c == '7' || c == '8' || c == '9')
{
    Console.WriteLine($"{c} is a number.");
}
else if (c == 'a' ||c == 'e' ||c == 'i' ||c == 'o' ||c == 'u' ||c == 'A' ||c == 'E' ||c == 'I' ||c == 'O' ||c == 'U')
{
    Console.WriteLine($"{c} is a vowel.");
}
else if (!(c == 'a' ||c == 'e' ||c == 'i' ||c == 'o' ||c == 'u' ||c == 'A' ||c == 'E' ||c == 'I' ||c == 'O' ||c == 'U'))
{
    Console.WriteLine($"{c} is a consonant.");
}

/*
Function to check whether a character is
vowel or not
void vowelOrConsonant(char x)
{
    if (x == 'a' || x == 'e' || x == 'i' || 
        x == 'o' || x == 'u')
        cout << "Vowel" << endl;
    else
        cout << "Consonant" << endl
}
  
Driver code
int main()
{
    vowelOrConsonant('c');
    vowelOrConsonant('e');
    return 0;
}
*/