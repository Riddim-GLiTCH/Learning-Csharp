using System;

Console.WriteLine("Hi there! What's your name?");
Console.Write("> ");

string userName = Console.ReadLine();

// Funciton to get the Time
// ToDo: Enable Spellcheck on Comments
DateTime now = DateTime.Now;
int currentHour = now.Hour;

// Greet the user based on the Time
if (currentHour < 12)
{
    Console.WriteLine($"Good Morning, {userName}!");
}
else if (currentHour < 17)
{
    Console.WriteLine($"Good Afternoon, {userName}!");
}
else
{
    Console.WriteLine($"Good Night, {userName}!");
}

// Wait for the user to close the program
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
