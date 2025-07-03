namespace CodingPractise;

public static class MaxNumberFinder
{
    public static void Run()
    {
        List<int> numbers = new List<int> { 22, 31, 99, 11, 1 };
        int result = GetMaxValue(numbers);
        Console.WriteLine("The min value is: " + result);
    }

    private static int GetMaxValue(List<int> numbers)
    {
        return numbers.Max();
    }
}
