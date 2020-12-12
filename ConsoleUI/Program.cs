using KataLibrary;
using System;

Console.WriteLine("KATA 003: Isograms\n");

Console.Write("Give me some word: ");
string inputWord = Console.ReadLine();

bool isTheWordAnIsogram = Kata.IsIsogram(inputWord);

if (isTheWordAnIsogram)
    Console.WriteLine("\nYour word IS an isogram!");
else
    Console.WriteLine("\nYour word IS NOT an isogram!");

Console.Write("\nPress any key...");
Console.ReadKey();