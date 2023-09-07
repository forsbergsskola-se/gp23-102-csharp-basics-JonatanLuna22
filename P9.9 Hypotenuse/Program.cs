
Console.WriteLine(@"Hej! Let's calculate the hypotenuse of a triangle.);

Give me the length of one of the sides of the triangle.");

string answer1 = Console.ReadLine();
float s1 = float.Parse(answer1);

Console.WriteLine("And now give me the length of the other one.");

string answer2 = Console.ReadLine();
float s2 = float.Parse(answer2);

float x = (s1 * s1) + (s2 * s2);
float h =  MathF.Sqrt(x);

Console.WriteLine($"The hypotenuse of a triangle with a side of {answer1} and a second side of {answer2} is {h}.");