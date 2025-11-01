/// Practice 1. Changing Loop Control with Break Statements
int[] temperatures = { 18, 22, 30, 35 };

for (int i = 0; i < temperatures.Length; i++)
{
    if (temperatures[i] < 20)
    {
        Console.WriteLine("It is below 20.");
        break;
    }
    else if (temperatures[i] > 25)
    {
        Console.WriteLine("It is warm outside.");
        continue;
    }
    Console.WriteLine("Might be chilly, dress appropriately.");
}


/// Practice 2. Iterating Through Temperatures in C#
class Program
{
    static void Main()
    {
        int[] temperatures = new int[]{18, 22, 30, 35};
        int i = 0;
        while (i < temperatures.Length)
        {
            if (temperatures[i] > 20)
            {
                Console.WriteLine("Temperature " + temperatures[i] + " is greater than 20.");
            }
            else {
                Console.WriteLine("Temperature " + temperatures[i] + " might require a jacket.");    
            }
            i++;
        }
    }
}

/// Practice 3. Controlling Flow Based on Temperature Conditions
class Program
{
    static void Main()
    {
        // List of temperatures with mixed weather conditions
        int[] temperatures = { 3, 18, 21, 28, 35, 19, 22 };

        for (int i = 0; i < temperatures.Length; i++)
        {
            int temp = temperatures[i];
            if (temp > 30) {
                // TODO: Print "It's really hot." and exit the loop if temperature is above 30
                Console.WriteLine("It's really hot");
                break;
            } else if (temp < 20) {
                // TODO: Print "It's quite chilly." and skip to the next iteration if temperature is below 20
                Console.WriteLine("It's quite chilly");
                continue;
            }

            Console.WriteLine("Lovely weather.");
        }
    }
}

/// Practice 4. Control Loop Temperature Messages
int[] temperatures = {16, 14, 20, 22, 19, 13};

// TODO: Loop through temperatures to suggest clothing
for (int i = 0; i < temperatures.Length; i++)
{
    int temp = temperatures[i];
    if (temp < 15)
    {
        Console.WriteLine("Wear warm clothes.");
        // TODO: If it's cold outside, we stop checking the temperatures. Add the needed line to interrupt the loop.
        break;
    }
    else if (temp >= 20)
    {
        Console.WriteLine("You can wear light clothes.");
        // TODO: Add a line here that will skip the final print statement when it's warm enough for light clothes.
        continue;
    }
    Console.WriteLine("Consider a light jacket.");  // Suggestion for in-between temperatures
}

/// Practice 5. Conditional Looping with Temperature Analysis
class Program
{
    static void Main()
    {
        // TODO: Define an array of `temperatures`
        int[] temperatures = new int[] { 10, 22, 30, 31, 15 };

        // TODO: Write a loop to go through each temperature in the list
            // TODO: Add an 'if' statement to check if the temperature is over a really hot threshold
                // TODO: Print a message for being really hot and then exit the loop
            // TODO: Add an 'else if' condition before the general temperature message to check if it's too cold
                // TODO: For temperatures that are too cold, print a specific message and skip to the next one
            // TODO: Print a message saying the temperature is nice for all other cases
            
        for(int i = 0; i < temperatures.Length; i++) {
            int temp = temperatures[i];
            if (temp > 30) {
                Console.WriteLine("It is really hot");
                break;
            }
            else if (temp < 20) {
                Console.WriteLine("It is really cold");
                continue;
            }
            Console.WriteLine("It is really nice");
        }
    }
}
