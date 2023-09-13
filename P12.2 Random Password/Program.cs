
// Design a program that generates a random password with 6 characters, digits or symbols.

Console.WriteLine("Hej! This is your new random password:");

char a = (char)Random.Shared.Next(33, 65);
char b = (char)Random.Shared.Next(33, 65);
char c = (char)Random.Shared.Next(33, 65);
char d = (char)Random.Shared.Next(33, 65);
char e = (char)Random.Shared.Next(33, 65);
char f = (char)Random.Shared.Next(33, 65);

Console.WriteLine(@$"Your new password is:
{a}{b}{c}{d}{e}{f}");