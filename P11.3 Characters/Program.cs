
char vowel = ("a" || "e" || "i" || "o" || "u" || "A" || "E" || "I" || "O" || "U");
    
Console.WriteLine("Hej! Give a simple character and I will tell you if it is a number, vowel or consonant.");

char character = char.Parse(Console.ReadLine());

if (character = char vowel)
{
    Console.WriteLine(@$"The number {number} is in the scale 
A: 90-100.");
}
else if (number <= 89 && number > 79)
{
    Console.WriteLine(@$"The number {number} is in the scale 
B: 80-89.");
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