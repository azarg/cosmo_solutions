/// Practice 1. Counting Lowercase Characters in a String
class Program
{
    static void Main(string[] args)
    {
        string text = "C# is amazing!";
        
        //HINT: int lowercaseCount = 0; 
        int lowercaseCount = 0;
        
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            if (char.IsLower(c))
            {
                lowercaseCount++;
            }
        }

        Console.WriteLine(lowercaseCount);  // Initially outputs: "c# IS AMAZING!"
        
        // HINT: Console.WriteLine(lowercaseCount);  // Expected output: 9
    }
}

/// Practice 2. Fix the Uppercase String Processing Function in C#
class Program
{
    static void Main()
    {
        ProcessText("Happy Coding, Friends!");
    }

    static void ProcessText(string text)
    {
        string newText = "";
        for (int i = 0; i < text.Length; i++)
        {
            char ch = text[i];
            // BUG WAS HERE
            if (Char.IsLetter(ch))
            {
                newText += Char.ToUpper(ch);
            }
        }
        Console.WriteLine($"Processed Text: {newText}");
    }
}

/// Practice 3. Encrypting a Message by Shifting Characters
class EncryptionProgram
{
    static string EncryptString(string text)
    {
        char[] encrypted = new char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            char c = text[i];
            // TODO: Check if `c` is a letter different from 'z' and 'Z'. If so, increment by 1.
            // If `c` is 'z', change it to 'a'. If `c` is 'Z', change it to 'A'.
            // Otherwise, keep `c` unchanged and add it to the encrypted list.
            if (char.IsLetter(c) && c != 'z' && c != 'Z') {
                encrypted[i] = (char)(c + 1);
            }
            else if (c == 'z') {
                encrypted[i] = 'a';
            }
            else if (c == 'Z') {
                encrypted[i] = 'A';
            }
            else {
                encrypted[i] = c;
            }
        }
        return new string(encrypted);
    }
    
    static void Main()
    {
        string text = "Hello, C#!";
        string encryptedText = EncryptString(text);
        Console.WriteLine("The encrypted text is: " + encryptedText);  // Should print out "The encrypted text is Ifmmp, D#!"
    }
}

/// Practice 4. Implement Caesar Cipher in C#
public class CaesarCipher
{
    public static string EncryptText(string text)
    {
        string encrypted = "";
        for (int i = 0; i < text.Length; i++)  // use for loop
        {
            char c = text[i];  // get the character at the current index
            if (char.IsLetter(c))  // check if the character is an alphabet
            {
                int shift = 3;
                // TODO: Use the correct ASCII values to shift the character and add it to 'encrypted'
                encrypted += char.IsUpper(c) 
                    ? (char)((c - 65 + shift) % 26 + 65)
                    : (char)((c - 97 + shift) % 26 + 97);
                // Hint 1: 'A' = 65, 'a' = 97
                // Hint 2: you can use modulo (%) operator to create a cycle
                
                // Example:
                // Let's consider 'A', whose ASCII value is 65.
                // Applying the shift of 3, we get: (65 - 65 + 3) % 26 + 65
                // This simplifies to: 3 % 26 + 65 = 3 + 65 = 68, which corresponds to 'D'.
                // Therefore, 'A' shifts to 'D'.
            }
            else
            {
                encrypted += c;  // keep non-alphabet characters unchanged
            }
        }
        return encrypted;
    }

    public static void Main(string[] args)
    {
        // Example text to encrypt
        string originalText = "Hello, C#!";
        // The encrypted_text function call and Console.WriteLine statement should be the same as in the solution
        string encryptedText = EncryptText(originalText);
        Console.WriteLine(encryptedText);  // The correct output after implementing the TODO should be 'Khoor, F#!'
    }
}

/// Practice 5. Encrypting Text using a Shift Cipher in C#
class Program
{
    static string EncryptText(string inputText, int shift){
        char[] output = new char[inputText.Length];
        
        for (int i = 0; i < inputText.Length; i++){
            char c = inputText[i];
            if (char.IsLetter(c)){
                if (char.IsUpper(c)){
                    output[i] =(char) ((c - 'A' + shift) % 26 + 'A');
                }
                else {
                    output[i] =(char) ((c - 'a' + shift) % 26 + 'a');
                }
            }
            else {
                output[i] = c;
            }
        }
        
        return new string(output);
    }
    static void Main()
    {
        // Encrypt the text with a shift of 3
        Console.WriteLine(EncryptText("Hello, C#!", 3));  // Outputs: Khoor, F#!
    }  
}
