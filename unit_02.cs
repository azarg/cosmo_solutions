/// Practice 2. Refining your packing array

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
