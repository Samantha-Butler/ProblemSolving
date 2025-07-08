namespace CodingPractise;

public static class RemoveVowels
{
    public static void Run()
    {
        Console.Write("Enter a word: ");
        string? word = Console.ReadLine();

        // Exit early if input is null or empty
        if (string.IsNullOrEmpty(word))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string vowels = "aeiouAEIOU";
        string result = "";

        foreach (char c in word)
        {
            if (!vowels.Contains(c))
            {
                result += c;
            }
        }

        Console.WriteLine($"Without vowels: {result}");
    }
}