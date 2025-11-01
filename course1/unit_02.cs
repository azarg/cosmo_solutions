/// Practice 1. Refining your packing array

class MainClass {
    public static void Main (string[] args) {
        // A packing list for a journey using C# arrays
        string[] travel_items = new string[] { "passport", "camera", "sunscreen", "hat" };
        string travel_message = "Ready for the adventure!";

        // Currently, sunglasses are being appended to the array.
        // Your task is to add them at index 2 instead.
        Array.Resize(ref travel_items, travel_items.Length + 1);
        
        // After resizing, the array has one extra space at the end
        // We want to shift "sunscreen" and "hat" by one index
        // Array.Copy copies "length" number of characters from source array starting at "sourceIndex", to destination array starting at "destinationIndex"
        int sourceIndex = 2;
        int destinationIndex = 3;
        int length = 2;
        Array.Copy(travel_items, sourceIndex, travel_items, destinationIndex, length);
        
        // An alternative is to use a for loop
        // for (int i = travel_items.Length - 1; i > sourceIndex; i--) {
        //    travel_items[i] = travel_items[i - 1];
        // }
        
        
        travel_items[2] = "sunglasses"; // sunglasses appended at the end
        
        Console.WriteLine("Updated travel items: " + string.Join(", ", travel_items)); // Your bag should look like this: passport, camera, sunscreen, sunglasses, hat

        // Accessing the first and the last item packed
        string first_item = travel_items[0];
        string last_item = travel_items[travel_items.Length - 1];

        Console.WriteLine($"First packed item: {first_item}, last packed item: {last_item}");
        Console.WriteLine("Travel message in lowercase: " + travel_message.ToLower());
    }
}

/// Practice 2. Fixing the Suitcase Packing Array

public class Program
{
    public static void Main()
    {
        // Start by creating an array representing suitcase items
        string[] suitcase = new string[] { "shirt", "shorts", "toothbrush", "shoes" };

        // Let's resize the array to add "sunglasses" at the end of our suitcase
        Array.Resize(ref suitcase, suitcase.Length + 1);
        suitcase[suitcase.Length - 1] = "sunglasses";

        // Oops! We forgot socks. Let's shift items to insert socks at index 2
        Array.Resize(ref suitcase, suitcase.Length + 1);
        for (int i = suitcase.Length - 1; i > 2; i--)
        {
            suitcase[i] = suitcase[i - 1];
        }
        suitcase[2] = "socks";
        Console.WriteLine("Updated suitcase: " + string.Join(", ", suitcase));

        // Now, let's get the first and last item from the suitcase
        string firstItem = suitcase[1];
        
        // BUG: SHOULD BE -1 NOT -2
        string lastItem = suitcase[suitcase.Length - 1];
        Console.WriteLine(firstItem + ", " + lastItem);

        // Finally, let's remove "toothbrush" as we prefer to buy a new one at our destination
        
        // BUG: SHOULD BE "toothbrush" NOT "toothpaste"
        int toothbrushIndex = Array.IndexOf(suitcase, "toothbrush");
        for (int i = toothbrushIndex; i < suitcase.Length - 1; i++)
        {
            suitcase[i] = suitcase[i + 1];
        }
        Array.Resize(ref suitcase, suitcase.Length - 1);
        Console.WriteLine(string.Join(", ", suitcase));
    }
}

/// Practice 3. Packing a Travel Bag with Arrays in C#

class MainClass {
    public static void Main() {
        // Let's simulate packing a bag for travel with arrays and explore some operations!

        // Packing our bag with initial items
        string[] bag = { "t-shirt", "shorts", "sandals" };

        // TODO: Add 'sunglasses' to our bag at the end (resize the array first)
        Array.Resize(ref bag, bag.Length + 1);
        bag[bag.Length - 1] = "sunglasses";

        // TODO: Add 'hat' to our bag in the end of the list (resize the array first)
        Array.Resize(ref bag, bag.Length + 1);
        bag[bag.Length - 1] = "hat";
        
        // Let's check the item at the top of the bag which is the last item we packed
        string topItem = bag[bag.Length - 1];
        Console.WriteLine(topItem);
        
        // Printing out our bag to see all items packed
        Console.WriteLine(string.Join(", ", bag));
    }
}

/// Practice 4. Checking Packing List and Determining Item Position
class Program
{
    static void Main()
    {
        string[] packingList = { "clothes", "toothbrush", "passport", "camera" };
        string itemToCheck = "passport";

        // TODO: Write a line of code to check if the itemToCheck is in the packingList
        // TODO: Find the index of itemToCheck in the array if it is packed, otherwise set it to -1
        int itemIndex = Array.IndexOf(packingList, itemToCheck);
        bool isItemPacked = false;
        if (itemIndex != -1) isItemPacked = true;
        
        // Alternative solution
        /*
        int itemIndex = -1;
        bool isItemPacked = false;
        for(int i = 0; i < packingList.Length; i++)
        {
            if (packingList[i] == itemToCheck)
            {
                itemIndex = i;
                isItemPacked = true;
            }
        }
        */
        
        // Print out the results
        Console.WriteLine("Is the item packed? " + isItemPacked);
        Console.WriteLine("Item index: " + itemIndex);
    }
}

/// Practice 5. Packing Your Virtual Suitcase in C#

class MainClass {
    public static void Main() {
                
        // TODO: Initialize an array named 'suitcase' with items such as "shirt", "shorts", "toothbrush", and "passport".
        string[] suitcase = new string[] { "shirt", "shorts", "toothbrush", "passport"};
        
        //  Declare a `journeyFarewell` string variable for your goodbye message 
        //  TODO: Assign a farewell message to the variable (e.g., "Bon voyage, traveler!")
        string journeyFarewell = "Bon voyage, traveler!";
        
        //  Access the first and last item in your suitcase
        //  TODO: Print the first item in the suitcase
        //  TODO: Print the last item in the suitcase
        Console.WriteLine(suitcase[0]);
        Console.WriteLine(suitcase[suitcase.Length - 1]);

        //  Send off with a farewell in uppercase
        //  TODO: Print the farewell message in uppercase
        Console.WriteLine(journeyFarewell);
        
    }
}

/// Practice 6. Space Explorer String Manipulation

class MainClass {
    public static void Main() {
        // Given mission name
        string missionName = "Sort";

        // TODO: Print the first and the last character of the mission name
        Console.WriteLine(missionName[0]);
        Console.WriteLine(missionName[missionName.Length - 1]);
        
        // TODO: The mission needs a minor update. We aim to change its first letter to 'P' and the last letter to 'k', obtaining the word "Pork".
        // Remember, strings in C# are immutable, so you cannot alter them directly.
        string updatedName = "P" + missionName.Substring(1, 2) + 'k';
        
        // TODO: Print the updated mission name
        Console.WriteLine(updatedName);
    }
}
