Write a C# program to create a method that takes a string as input and throws an exception if the string does not contain vowels.
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        try
        {
            CheckForVowels(input);
            Console.WriteLine("The string contains at least one vowel.");
        }
        catch (NoVowelException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    static void CheckForVowels(string input)
    {
        if (string.IsNullOrWhiteSpace(input))
        {
            throw new ArgumentException("Input cannot be empty or whitespace.");
        }

        string vowels = "aeiouAEIOU";

        for (int i = 0; i < input.Length; i++)
        {
            if (vowels.Contains(input[i]))
            {
                return; // Vowel found
            }
        }

        throw new NoVowelException("The string does not contain any vowels.");
    }
}

public class NoVowelException : Exception
{
    public NoVowelException(string message) : base(message) { }
}
Write a C# program that reads a list of integers from the user and throws an exception if any numbers are duplicates.



