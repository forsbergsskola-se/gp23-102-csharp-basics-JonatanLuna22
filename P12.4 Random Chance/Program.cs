﻿
// Write a program that has a 10% chance of showing a secret message. Otherwise it just displays a message saying to try again.

Console.WriteLine("Guess the number I'm thinking of between 0 and 9");
int number = int.Parse(Console.ReadLine());

int right = Random.Shared.Next(0, 10);

Console.WriteLine(number == right ? "You have been imbued with the power of the Water." : 