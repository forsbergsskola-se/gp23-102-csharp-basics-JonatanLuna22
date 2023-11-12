
// && = and
// || = or
// !Do the opposite. !false = true !!false = true 
// bool can be use with yes or no, on or  off, true or false.

/*
int itemCosts = 500;
Console.WriteLine($"The item costs: {itemCosts}");
Console.WriteLine("How much you got?");
string userInput = Console.ReadLine(); // "400"
int userMoney = int.Parse(userInput); // 400

Console.WriteLine("Let's see... do you have enough?");
bool enough = userMoney >= itemCosts;
Console.WriteLine(enough);
*/

int child = 12;
int teenager = 13;
int adult = 19;

Console.WriteLine("What's your age?");

string answer1 = Console.ReadLine();
int age = int.Parse(answer1);

bool isChild = age <= child;
bool isTeenager = age > child && age < adult;
bool isAdult = age >= adult;

Console.WriteLine($@"You are a child: {isChild}
You are a teenager = {isTeenager}
You are an adult: {isAdult} ");