
Console.WriteLine("Please pass me a seed.");
int seed = int.Parse(Console.ReadLine());

Random random = new Random(seed);

int number1 = random.Next(0, 5);
int number2 = random.Next(0, 5);
int number3 = random.Next(0, 5);

Console.WriteLine(@$"Now I will give you three random numbers between 0 and 5 based on the seed you gave me:
{number1}
{number2}
{number3}");

double number4 = random.NextDouble()*0.5;
double number5 = random.NextDouble()*0.5;
double number6 = random.NextDouble()*0.5;

Console.WriteLine(@$"And now I will give you three random numbers between 0 and 0,5 based on the seed you gave me:
{number4}
{number5}
{number6}");

double number7 = random.NextDouble()*(0.7-0.2)+0.2;
double number8 = random.NextDouble()*(0.7-0.2)+0.2;
double number9 = random.NextDouble()*(0.7-0.2)+0.2;

Console.WriteLine(@$"And now I will give you three random numbers between 0 and 0,5 based on the seed you gave me:
{number7}
{number8}
{number9}");

Console.WriteLine(":Give me a crit chance between 0,0 (0%) and 1,0 (100%)");
double crit = double.Parse(Console.ReadLine());

// 1

    if (Random.Shared.NextDouble() < crit) // Why I removed "Shared." and I get an error?
    {
        Console.WriteLine("Crit");
    }
    else 
    {
        Console.WriteLine("No Crit");
    }

// 2

    if (Random.Shared.NextDouble() < crit)
    {
        Console.WriteLine("Crit");
    }
    else  
    {
        Console.WriteLine("No Crit");
    }

// 3

    if (Random.Shared.NextDouble() < crit)
    {
        Console.WriteLine("Crit");
    }
    else  
    {
        Console.WriteLine("No Crit");
    }

// 4

    if (Random.Shared.NextDouble() < crit)
    {
        Console.WriteLine("Crit");
    }
    else  
    {
        Console.WriteLine("No Crit");
    }

// 5

    if (Random.Shared.NextDouble() < crit)
    {
        Console.WriteLine("Crit");
    }
    else  
    {
        Console.WriteLine("No Crit");
    }

