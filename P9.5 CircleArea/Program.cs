// See https://aka.ms/new-console-template for more information

//Circle's area (A = π r²)

Console.WriteLine(@"Hej! I can calculate the area of a circle for you.

Give me the radius of a circle in cm.");

string answer1 = Console.ReadLine(); 
float r = float.Parse(answer1); // Simplification: float r = float.Parse(Console.ReadLine());

float a = 3.1416f * (r * r); // I can also use "Mathf.PI" or "float.pi" instead of 3.1416f.

Console.WriteLine($"The are of a circle with a radius of {answer1}cm is {a}cm");