/// change "for loop" to a "while loop"
using System;

class Program
{
    static void Main()
    {
        string[] friends = { "Alice", "Bob", "Charlie", "Daniel" };
        
        int i = 0;
        while (i < friends.Length)
        {
            Console.WriteLine($"Hello, {friends[i]}! Nice to meet you.");
            i++;
        }
    }
}
