// See https://aka.ms/new-console-template for more information

{
    Console.WriteLine(@"Hej! Here you can divide numbers.

Give me a number!");

    string answer1 = Console.ReadLine();
    int x = int.Parse(answer1);

    Console.WriteLine("And now text de number which one you want to divide the first one");

    string answer2 = Console.ReadLine();
    int y = int.Parse(answer2);

    float z =(float) x / y;

    Console.WriteLine($"{answer1} divided by {answer2} is {z}");
}


//Another option down here.

{
    Console.WriteLine(@"Hej! Here you can divide whole numbers.

Give me a number!");

    string answer1 = Console.ReadLine();
    float x = float.Parse(answer1);

    Console.WriteLine("And now text de number which one you want to divide the first one");

    string answer2 = Console.ReadLine();
    float y = float.Parse(answer2);

    float z = x / y;

    Console.WriteLine($"{answer1} divided by {answer2} is {z}");
}
