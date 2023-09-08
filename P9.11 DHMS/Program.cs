Console.WriteLine(@"Hej! Give me a number of seconds:");

string answer1 = Console.ReadLine();
int s = int.Parse(answer1);

int m = s / 60;

int sr = s % 60;
Console.WriteLine($"Seconds : {sr}");

int h = m / 60;

int mr = m % 60;
Console.WriteLine($"Minutes : {mr}");

int d = h / 24;

int hr = h % 24;
Console.WriteLine($"Hours : {hr}");

Console.WriteLine($"Days : {d}");

Console.WriteLine($"{d}.{hr}:{mr}:{sr}");  // Output:1.10:17:36

double sd = double.Parse(answer1);

double td = sd / 60 / 60 / 24;

Console.WriteLine($"In total, that's {td} days.");  // Output:In total, that's 1,4288888888888887 Days.