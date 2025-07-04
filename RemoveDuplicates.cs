namespace CodingPractise;

public static class RemoveDuplicates
{
    public static List<int> RemoveDuplicate(List<int> inputList)
    {
        return inputList.Distinct().ToList();
    }

    public static void Run()
    {
        List<int> inputList = new List<int> { 10, 10, 3, 4, 5, 10 };
        List<int> answer = RemoveDuplicate(inputList);
        Console.WriteLine(string.Join(", ", answer));
    }
}
