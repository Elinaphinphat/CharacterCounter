using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a String: ");
        string inputChar = Console.ReadLine().ToLower();
        var counter = inputChar
                        .Where(char.IsLetter)
                        .ToLookup(c => c);

        foreach (var c in counter)
        {
            Console.WriteLine("Character: {0} Count: {1}", c.Key, counter[c.Key].Count());
        }
        }
    }   