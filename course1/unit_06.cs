/// Practice 1. Using the Join() Method to Combine String Parts
class Program
{
    static void Main()
    {
        string astronautsData = "Buzz Aldrin, 1930;Yuri Gagarin, 1934;Valentina Tereshkova, 1937";

        // Splitting the string into a list of astronaut info and stripping any whitespace
        string[] astronautsList = astronautsData.Split(';');
        string[] cleanedAstronauts = new string[astronautsList.Length];

        for (int i = 0; i < astronautsList.Length; i++)
        {
            string[] parts = astronautsList[i].Split(',');
            for (int j = 0; j < parts.Length; j++) {
                parts[j] = parts[j].Trim();
            }
            cleanedAstronauts[i] = string.Join(" ", parts);//parts[0].Trim() + " " + parts[1].Trim(); // Modify this line to use the Join() method
        }
        
        Console.WriteLine(string.Join(", ", cleanedAstronauts)); // Output: "Buzz Aldrin 1930, Yuri Gagarin 1934, Valentina Tereshkova 1937"
    }
}

/// Practice 2. Debug the Employee Information Management System
class Program
{
    static void Main()
    {
        // Employee Information Management System

        // A list of employee data
        string employee_data = "Name: John Doe, Age: 30, Role: Engineer";

        // Split employee data into a list
        
        // BUG HERE, USE ',' INSTEAD OF ' '
        string[] employee_info = employee_data.Split(',');

        // Use Trim to clean data and Join to create a string with newlines
        string cleaned_data = string.Join("\n", employee_info.Select(info => info.Trim()));

        // Expected output:
        // Name: John Doe
        // Age: 30
        // Role: Engineer
        Console.WriteLine(cleaned_data);
    }
}

/// Practice 3. Reformatting Book Data in C#
class Program
{
    static void Main()
    {
        // A small piece of code that manages book data.
        // This code will process a simple string containing book data.

        string bookData = "1984,Fiction|War and Peace,Historical|Harry Potter,Fantasy";
        // Splitting the book data by '|' to separate each book's info
        string[] bookList = bookData.Split('|');

        // TODO: For each book, create a formatted string with stripped details and genre popularity note
        for (int i = 0; i < bookList.Length; i++)
        {
            // TODO: Parse the book data and add popularity note if applicable
            string[] parts = bookList[i].Split(",");
            string title = parts[0];
            string genre = parts[1];
            string popularity = genre == "Fiction" || genre == "Fantasy" ? "Popular" : "Not popular";
            Console.WriteLine($"Title: {title} - Genre: {genre} - {popularity}");
            // Example: Title: 1984 - Genre: Fiction - Popular
        }
    }
}

/// Practice 4. Processing Astronaut Exploration Data
public class Program
{
    public static void Main()
    {
        // This function processes astronaut names and planets from a string 
        // then prints out a neat summary of who is exploring which planet.
        void ProcessAstronautData(string data)
        {
            string[] astronautDetails = data.Split(';');
            for (int i = 0; i < astronautDetails.Length; i++)
            {
                // TODO: Extract the astronaut name and explored planet from the detail, strip away the whitespace.
                astronautDetails[i] = astronautDetails[i].Trim();
                string[] nameAndPlanet = astronautDetails[i].Split("-");
                // TODO: Print the statement in the format "Astronaut [name] is exploring [planet]."
                Console.WriteLine($"Astronaut {nameAndPlanet[0]} is exploring {nameAndPlanet[1]}.");
            }
        }

        // String containing astronaut names and planets, separated by semicolons.
        // Each astronaut-planet pair is separated by a dash.
        string astronautData = "    Neil-Mars; Buzz-Jupiter; Sally-Venus    ";
        ProcessAstronautData(astronautData);
    }
}

/// Practice 5. Processing Space Exploration Crew Members' Data
class Program
{
    static void Main()
    {
        // Space exploration crew members' data, containing their names, missions, and roles
        string crewData = "Neil,Armstrong,Apollo 11,C;Buzz,Aldrin,Apollo 11,P;Michael,Collins,Apollo 11,CM";
        
        // TODO: Split the crewData string into an array of individual crew member information using the appropriate delimiter
        string[] crewMemberData = crewData.Split(";");
        
        // TODO: Iterate over the array of crew member data
        for(int i = 0; i < crewMemberData.Length; i++){
            // TODO: For each member, split their data string using commas as delimiters
            string[] crewMemberDetails = crewMemberData[i].Split(",");
            // TODO: Print the crew member's details in a formatted string
            Console.WriteLine($"{crewMemberDetails[0]} {crewMemberDetails[1]} {crewMemberDetails[2]} {crewMemberDetails[3]}");
        }
        // Expected output:
        // Neil Armstrong Apollo 11 C
        // Buzz Aldrin Apollo 11 P
        // Michael Collins Apollo 11 CM
    }
}
