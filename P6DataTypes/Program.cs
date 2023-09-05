// See https://aka.ms/new-console-template for more information

using System.IO.Pipes;

string outputString = "Hello World";
Console.WriteLine(outputString);

float decimalValue = 0.3f;
Console.WriteLine(decimalValue);

bool isAwesome = true;
Console.WriteLine(isAwesome);

byte hexByte = 0xa7;
Console.WriteLine(hexByte);

Console.WriteLine($@"{outputString}
{decimalValue}
{isAwesome}
{hexByte}");



