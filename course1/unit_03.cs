/// Practice 1. Changing a For Loop to a While Loop
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

/// Practice 3. Fix the Fruit Counter Program
class Program
{
    static void Main()
    {
        // List of fruits for the fruit salad
        string[] fruits = { "apple", "banana", "cherry", "kiwi", "mango" };
        // Count the number of fruits in the salad
        int fruitCount = 0;
        // Loop over each fruit in the fruits array
        foreach (var fruit in fruits)
        {
            // The wrong operator is used here, it should increase the count
            fruitCount += 1;  
        }
        Console.WriteLine(fruitCount);  // This should print the total number of fruits in the salad
    }
}

/// Practice 4. Looping Through Fruits
class Program
{
    static void Main()
    {
        // List of fruits to be used in fruit salad
        string[] fruits = { "apple", "banana", "kiwi", "mango" };

        // TODO: Loop over the list of fruits and add them to the fruit salad with a print statement
        for (int i = 0; i < fruits.Length; i++)
        {
            // TODO: Print a statement for adding each fruit to the fruit salad: "Adding [fruit] to the fruit salad."
            Console.WriteLine("Adding " + fruits[i] + " to the fruit salad.");
        }
    }
}

/// Practice 5. Assembling a Sentence of Animal Names
class Program
{
    static void Main()
    {
        // Define an array of animals
        string[] animals = { "dog", "cat", "rabbit", "hamster" };
        
        // Initialize an empty string to build the sentence
        string sentence = "";

        // Use a while loop to concatenate each animal into the sentence
        int index = 0;
        
        // TODO: Create a while loop that assembles a string of animal names separated by spaces, without adding a space after the last animal
        // Hint: Consider using a conditional to determine when to add a space
        while (index < animals.Length) {
            sentence += animals[index];
            index++;
            if (index != animals.Length)
                sentence += " ";
        }
        
        Console.WriteLine(sentence);  // Output the sentence
    }
}

/// Practice 6. Counting Non-Vowel Characters in a String
class Program
{
    static void Main()
    {
        // Define a string named 'word' to represent the phrase we'll work with
        string word = "FRUIT Salad";

        // TODO: Initialize a counter to hold the number of non-vowel characters
        int counter = 0;
        
        // TODO: Use a 'for' loop to iterate over each character in the string
        for(int i = 0; i < word.Length; i++) {
            // TODO: Inside the loop, write a condition to check if it's not a vowel or a space
            // Don't forget that letters can be lowercase and uppercase
            if ("aeiou AEIOU".Contains(word[i]) == false) {
                // TODO: If the condition is true, increase the counter for non-vowel characters
                counter++;
            }
        }

        // TODO: Finally, print the count of non-vowel characters. For the input "FRUIT Salad", the count should be 6
        Console.WriteLine(counter);
    }
}
