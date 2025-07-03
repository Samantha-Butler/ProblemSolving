namespace CodingPractise
{
    public static class MinNumberFinder
    {
        public static void Run()
        {
            List<int> numbers = new List<int> { 22, 31, 99, 11, 1 };
            int result = GetMinValue(numbers);
            Console.WriteLine("The min value is: " + result);
        }

        private static int GetMinValue(List<int> numbers)
        {
            return numbers.Min();
        }
    }
}